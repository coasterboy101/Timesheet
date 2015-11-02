using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timesheet
{
	public partial class frmNewEntry : Form
	{
		private DataTable dtProjects;
		private DataTable dtClients;
		private DataTable dtTasks;

		private DatabaseFunctions dbFunctions;

		private string employeeId;

		public frmNewEntry(string employeeId)
		{
			InitializeComponent();

			this.employeeId = employeeId;

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);
		}

		private void frmNewEntry_Load(object sender, EventArgs e)
		{
			// Set clndrDate to the current date.
			clndrDate.TodayDate = DateTime.Today;
			clndrDate.SetDate(DateTime.Today);

			// Load the list of Projects from the database, then add them to cboProjects.
			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("p_EmpId", employeeId));

			dtProjects = dbFunctions.FillStoredProc("Load_Employee_Projects", dbParams);
			if (dtProjects.Rows.Count > 0)
			{
				foreach (DataRow dr in dtProjects.Rows)
				{
					cboProject.Items.Add(String.Format("{0} {1}", dr["ProjectId"].ToString(), dr["ProjectName"].ToString()));
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check the values the user entered, and if they are acceptable,
			// create a new entry in the database and close the form.
			if (CheckInput())
			{
				string projectId = cboProject.SelectedItem.ToString().Split(' ').First();
				string clientId = cboClient.SelectedItem.ToString().Split(' ').First();
				string taskId = cboTask.SelectedItem.ToString().Split(' ').First();

				int hours = Convert.ToInt32(cboHours.SelectedItem.ToString());
				int minutes = Convert.ToInt32(cboMinutes.SelectedItem.ToString());
				decimal time = 0;

				switch (minutes)
				{
					case 0:
						time = hours;
						break;
					case 15:
						time = (decimal)(hours + 0.25);
						break;
					case 30:
						time = (decimal)(hours + 0.5);
						break;
					case 45:
						time = (decimal)(hours + 0.75);
						break;
				}

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_Date", clndrDate.SelectionStart));
				dbParams.Add(new MySqlParameter("p_Hours", time));
				dbParams.Add(new MySqlParameter("p_ProjectId", projectId));
				dbParams.Add(new MySqlParameter("p_ClientId", clientId));
				dbParams.Add(new MySqlParameter("p_TaskId", taskId));
				dbParams.Add(new MySqlParameter("p_EmpId", employeeId));

				dbFunctions.ExecuteStoredProc("Add_Timesheet", dbParams);
				Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form and do nothing with the data.
			Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Clear all of the combo boxes and reset the calendar to the current date.
			cboProject.ResetText();
			cboClient.ResetText();
			cboTask.ResetText();
			cboHours.ResetText();
			cboMinutes.ResetText();

			cboClient.Items.Clear();
			cboTask.Items.Clear();

			clndrDate.SetDate(DateTime.Today);
		}

		private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadClients(cboProject.SelectedItem.ToString().Split(' ').First());
		}

		private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadTasks(cboClient.SelectedItem.ToString().Split(' ').First());
		}

		private bool CheckInput()
		{
			if (clndrDate.SelectionStart == null || clndrDate.SelectionStart > DateTime.Today)
			{
				MessageBox.Show("Please select a valid date.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (cboProject.SelectedItem == null)
			{
				MessageBox.Show("Please select a project to list the task under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (cboClient.SelectedItem == null)
			{
				MessageBox.Show("Please select a client to list the task under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (cboTask.SelectedItem == null)
			{
				MessageBox.Show("Please select a task to list the task under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (cboHours.SelectedItem == null)
			{
				MessageBox.Show("Please select the number of hours spent on this task.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (cboMinutes.SelectedItem == null)
			{
				MessageBox.Show("Please select the number of minutes spent on this task.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void LoadClients(string projectId)
		{
			// Load the list of Clients from the database, then add them to cboClient.
			dtClients = dbFunctions.FillStoredProc("Load_Clients", new List<MySqlParameter>());
			DataRow[] drs = dtClients.Select(String.Format("ProjectId={0}", projectId));
			DataTable projectClients;

			cboClient.Items.Clear();

			if (drs.Length > 0)
			{
				projectClients = drs.CopyToDataTable();

				foreach (DataRow dr in projectClients.Rows)
				{
					cboClient.Items.Add(String.Format("{0} {1}", dr["ClientId"].ToString(), dr["ClientName"].ToString()));
				}
			}
		}

		private void LoadTasks(string clientId)
		{
			// Load the list of Tasks from the database, then add them to cboClient.
			dtTasks = dbFunctions.FillStoredProc("Load_Tasks", new List<MySqlParameter>());
			DataRow[] drs = dtTasks.Select(String.Format("ClientId={0}", clientId));
			DataTable clientTasks;

			cboTask.Items.Clear();

			if (drs.Length > 0)
			{
				clientTasks = drs.CopyToDataTable();

				foreach (DataRow dr in clientTasks.Rows)
				{
					cboTask.Items.Add(String.Format("{0} {1}", dr["TaskId"].ToString(), dr["TaskName"].ToString()));
				}
			}
		}
	}
}
