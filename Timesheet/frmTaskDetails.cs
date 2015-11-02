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
	public partial class frmTaskDetails : Form
	{
		private DataTable dtProjects;
		private DataTable dtClients;

		private DataRow drTask;

		private DatabaseFunctions dbFunctions;

		public frmTaskDetails()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);
		}

		public frmTaskDetails(DataRow drTask)
		{
			InitializeComponent();

			this.drTask = drTask;

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);
		}

		private void frmTaskDetails_Load(object sender, EventArgs e)
		{
			// Load the list of Projects from the database, then add them to cboProjects.
			dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());

			if (dtProjects.Rows.Count > 0)
			{
				foreach (DataRow dr in dtProjects.Rows)
				{
					cboProject.Items.Add(String.Format("{0} {1}", dr["ProjectId"].ToString(), dr["ProjectName"].ToString()));
				}
			}

			// Check for any data being passed from frmProjects, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
			if (drTask != null)
			{
				txtName.Text = drTask["TaskName"].ToString();
				txtDescription.Text = drTask["TaskDescription"].ToString();
				cboProject.SelectedItem = String.Format("{0} {1}", drTask["ProjectId"].ToString(), drTask["ProjectName"].ToString());
				LoadClients(drTask["ProjectId"].ToString());
				cboClient.SelectedItem = String.Format("{0} {1}", drTask["ClientId"].ToString(), drTask["ClientName"].ToString());
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Depending on whether or not the task exists, either update a row or
			// create a new one, then close the form.
			if (cboProject.SelectedItem != null && cboClient.SelectedItem != null)
			{
				string projectId = cboProject.SelectedItem.ToString().Split(' ').First();
				string clientId = cboClient.SelectedItem.ToString().Split(' ').First();

				// Depending on whether or not the task exists, either update a row or
				// create a new one, then close the form.
				if (drTask != null)
				{
					List<MySqlParameter> dbParams = new List<MySqlParameter>();
					dbParams.Add(new MySqlParameter("p_TaskId", drTask["TaskId"].ToString()));
					dbParams.Add(new MySqlParameter("p_TaskName", txtName.Text));
					dbParams.Add(new MySqlParameter("p_TaskDescription", txtDescription.Text));
					dbParams.Add(new MySqlParameter("p_ProjectId", projectId));
					dbParams.Add(new MySqlParameter("p_ClientId", clientId));

					dbFunctions.ExecuteStoredProc("Update_Task", dbParams);
				}
				else
				{
					List<MySqlParameter> dbParams = new List<MySqlParameter>();
					dbParams.Add(new MySqlParameter("p_TaskName", txtName.Text));
					dbParams.Add(new MySqlParameter("p_TaskDescription", txtDescription.Text));
					dbParams.Add(new MySqlParameter("p_ProjectId", projectId));
					dbParams.Add(new MySqlParameter("p_ClientId", clientId));

					dbFunctions.ExecuteStoredProc("Add_Task", dbParams);
				}

				Close();
			}
			else if (cboProject.SelectedItem == null)
			{
				MessageBox.Show("Please select a project to list the task under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Please select a client to list the task under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
			Close();
		}

		private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadClients(cboProject.SelectedItem.ToString().Split(' ').First());
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
	}
}
