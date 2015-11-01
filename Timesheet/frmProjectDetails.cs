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
	public partial class frmProjectDetails : Form
	{
		private DatabaseFunctions dbFunctions;

		private DataRow drProject;

		private DataTable dtProjectEmployees;

		private bool projectExists;

		/// <summary>
		/// Initializes the form with all fields empty.
		/// </summary>
		public frmProjectDetails()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			dtProjectEmployees = new DataTable("ProjectEmployees");

			drProject = null;
			projectExists = false;
		}

		/// <summary>
		/// Initializes the form with the values from the provided datarow.
		/// </summary>
		/// <param name="drProject">A datarow containing valid project information.</param>
		public frmProjectDetails(DataRow drProject)
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			this.drProject = drProject;
			projectExists = true;
		}

		private void frmProjectDetails_Load(object sender, EventArgs e)
		{
			// Check for any data being passed from frmProjects, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
			if (drProject != null)
			{
				txtName.Text = drProject["ProjectName"].ToString();
				txtDescription.Text = drProject["ProjectDescription"].ToString();

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ProjectId", Convert.ToInt32(drProject["ProjectId"].ToString())));

				dtProjectEmployees = dbFunctions.FillStoredProc("Load_Project_Employees", dbParams);

				foreach (DataRow dr in dtProjectEmployees.Rows)
				{
					lstEmployees.Items.Add(String.Format("{0} {1}", dr["FirstName"].ToString(), dr["LastName"].ToString()));
				}
			}
			// Disable the Employees list if the project doesn't exist.
			else
			{
				lstEmployees.Enabled = false;
				btnAdd.Enabled = false;
				btnRemove.Enabled = false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check for the required input, if it isn't there. exit immediately.
			if (!CheckInput())
				return;

			// Depending on whether or not the project exists, either update a row or
			// create a new one, then close the form.
			if (projectExists)
			{
				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ProjectId", Convert.ToInt32(drProject["ProjectId"].ToString())));
				dbParams.Add(new MySqlParameter("p_ProjectName", txtName.Text));
				dbParams.Add(new MySqlParameter("p_ProjectDescription", txtDescription.Text));

				dbFunctions.ExecuteStoredProc("Update_Project", dbParams);
			}
			else
			{
				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ProjectName", txtName.Text));
				dbParams.Add(new MySqlParameter("p_ProjectDescription", txtDescription.Text));

				dbFunctions.ExecuteStoredProc("Add_Project", dbParams);
			}

			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
			Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmSelectEmployee newForm = new frmSelectEmployee(drProject);
			newForm.FormClosing += NewForm_FormClosing;
			newForm.Show();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (lstEmployees.SelectedItem != null)
			{
				string[] employeeName = lstEmployees.SelectedItem.ToString().Split(' ');
				DataRow drEmployee = dtProjectEmployees.Select(String.Format("FirstName='{0}' AND LastName='{1}'",
					employeeName[0], employeeName[1])).First();

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_EmpId", drEmployee["EmpId"].ToString()));
				dbParams.Add(new MySqlParameter("p_ProjectId", drProject["ProjectId"].ToString()));

				dbFunctions.ExecuteStoredProc("Delete_Project_Employee", dbParams);

				RefreshEmployees();
			}
			else
			{
				MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void NewForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			RefreshEmployees();
		}

		private void RefreshEmployees()
		{
			List<MySqlParameter> param = new List<MySqlParameter>();
			param.Add(new MySqlParameter("p_ProjectId", drProject["ProjectId"].ToString()));

			dtProjectEmployees = dbFunctions.FillStoredProc("Load_Project_Employees", param);

			lstEmployees.Items.Clear();
			foreach (DataRow dr in dtProjectEmployees.Rows)
			{
				lstEmployees.Items.Add(String.Format("{0} {1}", dr["FirstName"].ToString(), dr["LastName"].ToString()));
			}
		}

		private bool CheckInput()
		{
			// Check for empty input.
			if (String.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show("Please enter the project's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus();
				return false;
			}
			// Input requirements satisfied, return true.
			else
			{
				return true;
			}
		}
	}
}
