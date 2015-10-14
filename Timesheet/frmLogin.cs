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
		private DataTable dtEmployees;

		public frmLogin()
		{
			InitializeComponent();

			dtEmployees = new DataTable("Employees");
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			using (MySqlConnection dbConnection = new MySqlConnection(Properties.Settings.Default.timesheetConnectionString))
			{
				dbConnection.Open();

				MySqlCommand dbCommand = new MySqlCommand("LoadUsers", dbConnection);
				dbCommand.CommandType = CommandType.StoredProcedure;
				dbCommand.Parameters.Add(new MySqlParameter("p_EmpId", txtUserId.Text));
				dbCommand.Parameters.Add(new MySqlParameter("p_Password", txtPassword.Text));

				MySqlDataAdapter dbAdapter = new MySqlDataAdapter(dbCommand);
				dbAdapter.Fill(dtEmployees);

				dbConnection.Close();
			}

			if (dtEmployees.Rows.Count != 0)
			{
				frmTimesheet newForm = new frmTimesheet(dtEmployees.Rows[0].ItemArray[2].ToString());
				newForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("The User ID or Password you have entered is incorrect.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}
	}
}
