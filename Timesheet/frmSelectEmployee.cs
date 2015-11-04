using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Timesheet
{
	public partial class frmSelectEmployee : Form
	{
		private DataTable dtEmployees;
		private DataRow drProject;

		private DatabaseFunctions dbFunctions;

		public frmSelectEmployee(DataRow drProject)
		{
			InitializeComponent();

			dtEmployees = new DataTable("Employees");

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			this.drProject = drProject;
		}

		private void frmSelectEmployee_Load(object sender, EventArgs e)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("p_ProjectId", drProject["ProjectId"].ToString()));

			dtEmployees = dbFunctions.FillStoredProc("Load_Non_Project_Employees", dbParams);

			// If any employees are returned, add them to the combo box.
			if (dtEmployees.Rows.Count > 0)
			{
				foreach (DataRow dr in dtEmployees.Rows)
				{
					cboEmployees.Items.Add(String.Format("{0} {1}", dr["FirstName"].ToString(), dr["LastName"].ToString()));
				}
      }
			// No employees returned, show a warning dialog and close the window.
			else
			{
				MessageBox.Show("No employees are available to be added to this project.", "No employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Close();
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (cboEmployees.SelectedItem != null)
			{
				string[] employeeName = cboEmployees.SelectedItem.ToString().Split(' ');
				DataRow drEmployee = dtEmployees.Select(String.Format("FirstName='{0}' AND LastName='{1}'", 
					employeeName[0], employeeName[1])).First();
				
				List<MySqlParameter> param = new List<MySqlParameter>();
				param.Add(new MySqlParameter("p_EmpId", drEmployee["EmpId"].ToString()));
				param.Add(new MySqlParameter("p_ProjectId", drProject["ProjectId"].ToString()));

				dbFunctions.ExecuteStoredProc("Add_Project_Employee", param);
				Close();
			}
			else
			{
				MessageBox.Show("Please select an employee to add to the project.", "No employee selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
