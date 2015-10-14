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
	public partial class frmTimesheet : Form
	{
		private string employeeType;

		public frmTimesheet(string employeeType)
		{
			InitializeComponent();

			this.employeeType = employeeType;
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
		}

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
			// Open frmNewEntry
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

		private void frmTimesheet_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
