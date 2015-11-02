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
	public partial class frmLogin : Form
	{
		private DatabaseFunctions dbFunctions;

		private DataTable dtUsers;

		public frmLogin()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			dtUsers = new DataTable("Employees");
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			List<MySqlParameter> cmdParams = new List<MySqlParameter>();
			cmdParams.Add(new MySqlParameter("p_EmpId", Convert.ToInt32(txtUserId.Text)));
			cmdParams.Add(new MySqlParameter("p_Password", txtPassword.Text));

			dtUsers = dbFunctions.FillStoredProc("Auth_User", cmdParams);

			// Check the given user ID and password against the database, if it is incorrect, there will be no rows.
			if (dtUsers.Rows.Count != 0)
			{
				// Make sure that they are still employed.
				if (Convert.ToInt32(dtUsers.Rows[0]["Status"].ToString()) == 1)
				{
					frmTimesheet newTimesheet = new frmTimesheet(dtUsers.Rows[0]);
					newTimesheet.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("You are no longer listed as an employee. Please contact your administrator if you beleive this"
							+ " is an error.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("The User ID or Password you have entered is incorrect.", "Authentication Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
