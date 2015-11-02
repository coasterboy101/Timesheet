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
	public partial class frmTimesheet : Form
	{
		private DataTable dtTimesheet;

		private DataRow drEmployee;

		private DatabaseFunctions dbFunctions;	

		private string employeeType;

		public frmTimesheet(DataRow drEmployee)
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			this.drEmployee = drEmployee;
			employeeType = drEmployee["EmployeeType"].ToString();
		}

		private void frmTimesheet_Load(object sender, EventArgs e)
		{
			// Check the user's privledge level, if they are HR or an admin, show btnReports, btnEmployees, and btnProjects.
			switch (employeeType)
			{
				case "Standard": // Standard User
					break;
				case "HR": // HR Personnel
					btnReports.Visible = true;
					btnEmployees.Visible = true;
					btnProjects.Visible = true;
					break;
				case "Manager": // Manager
					btnReports.Visible = true;
					btnEmployees.Visible = true;
					btnProjects.Visible = true;
					break;
				case "Admin": // Admin
					btnReports.Visible = true;
					btnEmployees.Visible = true;
					btnProjects.Visible = true;
					break;
			}

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("p_EmpId", drEmployee["EmpId"].ToString()));

			dtTimesheet = dbFunctions.FillStoredProc("Load_Timesheet", dbParams);

			dataGrdTimesheet.DataSource = dtTimesheet;
		}

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
			frmNewEntry newForm = new frmNewEntry(drEmployee["EmpId"].ToString());
			newForm.FormClosed += NewForm_FormClosed;
			newForm.Show();
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			// Open frmReports
		}

		private void btnEmployees_Click(object sender, EventArgs e)
		{
			frmEmployees newForm = new frmEmployees();
			newForm.Show();
		}

		private void btnProjects_Click(object sender, EventArgs e)
		{
			frmProjects newForm = new frmProjects();
			newForm.Show();
		}

		private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("p_EmpId", drEmployee["EmpId"]));

			dtTimesheet = dbFunctions.FillStoredProc("Load_Timesheet", dbParams);

			dataGrdTimesheet.DataSource = dtTimesheet;
		}

		private void frmTimesheet_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
