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
	public partial class frmEmployeeDetails : Form
	{
		private DatabaseFunctions dbFunctions;

		private DataRow drEmployee;

		private bool employeeExists;

		/// <summary>
		/// Initializes the form with all fields empty.
		/// </summary>
		public frmEmployeeDetails()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			drEmployee = null;
			employeeExists = false;
		}

		/// <summary>
		/// Initializes the form with the values from the provided datarow.
		/// </summary>
		/// <param name="drEmployee">A datarow containing valid employee information.</param>
		public frmEmployeeDetails(DataRow drEmployee)
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			this.drEmployee = drEmployee;
			employeeExists = true;
		}

		private void frmEmployeeDetails_Load(object sender, EventArgs e)
		{
			// Check for any data being passed from frmEmployees, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
			if (drEmployee != null)
			{
				txtFirstName.Text = drEmployee["FirstName"].ToString();
				txtLastName.Text = drEmployee["LastName"].ToString();
				txtSSN.Text = drEmployee["SSN"].ToString();
				txtEmail.Text = drEmployee["Email"].ToString();
				txtAddress.Text = drEmployee["StreetAddress"].ToString();
				txtCity.Text = drEmployee["City"].ToString();
				txtZip.Text = drEmployee["Zip"].ToString();
				txtPassword.Text = drEmployee["Password"].ToString();
				txtDepartment.Text = drEmployee["Department"].ToString();
				txtTitle.Text = drEmployee["Title"].ToString();

				cboState.SelectedItem = drEmployee["State"].ToString();
				cboEmployeeType.SelectedItem = drEmployee["EmployeeType"].ToString();
				chkEmployed.Checked = Convert.ToBoolean(Convert.ToInt32(drEmployee["Status"].ToString()));
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check for the required input, if it isn't there. exit immediately.
			if (!CheckInput())
				return;

			// Depending on whether or not the employee exists, either update a row or
			// create a new one, then close the form.
			if (employeeExists)
			{
				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_EmpId", Convert.ToInt32(drEmployee["EmpId"].ToString())));
				dbParams.Add(new MySqlParameter("p_FirstName", dbFunctions.RemoveNonLetters(txtFirstName.Text)));
				dbParams.Add(new MySqlParameter("p_LastName", dbFunctions.RemoveNonLetters(txtLastName.Text)));
				dbParams.Add(new MySqlParameter("p_SSN", txtSSN.Text));
				dbParams.Add(new MySqlParameter("p_Email", txtEmail.Text));
				dbParams.Add(new MySqlParameter("p_StreetAddress", txtAddress.Text));
				dbParams.Add(new MySqlParameter("p_City", txtCity.Text));
				dbParams.Add(new MySqlParameter("p_State", cboState.Text));
				dbParams.Add(new MySqlParameter("p_Zip", Convert.ToInt32(txtZip.Text)));
				dbParams.Add(new MySqlParameter("p_Password", txtPassword.Text));
				dbParams.Add(new MySqlParameter("p_EmployeeType", cboEmployeeType.Text));
				dbParams.Add(new MySqlParameter("p_Department", txtDepartment.Text));
				dbParams.Add(new MySqlParameter("p_Status", Convert.ToInt32(chkEmployed.Checked)));
				dbParams.Add(new MySqlParameter("p_Title", txtTitle.Text));

				dbFunctions.ExecuteStoredProc("Update_Employee", dbParams);
			}
			else
			{
				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_FirstName", dbFunctions.RemoveNonLetters(txtFirstName.Text)));
				dbParams.Add(new MySqlParameter("p_LastName", dbFunctions.RemoveNonLetters(txtLastName.Text)));
				dbParams.Add(new MySqlParameter("p_SSN", txtSSN.Text));
				dbParams.Add(new MySqlParameter("p_Email", txtEmail.Text));
				dbParams.Add(new MySqlParameter("p_StreetAddress", txtAddress.Text));
				dbParams.Add(new MySqlParameter("p_City", txtCity.Text));
				dbParams.Add(new MySqlParameter("p_State", cboState.Text));
				dbParams.Add(new MySqlParameter("p_Zip", Convert.ToInt32(txtZip.Text)));
				dbParams.Add(new MySqlParameter("p_Password", txtPassword.Text));
				dbParams.Add(new MySqlParameter("p_EmployeeType", cboEmployeeType.Text));
				dbParams.Add(new MySqlParameter("p_Department", txtDepartment.Text));
				dbParams.Add(new MySqlParameter("p_Status", Convert.ToInt32(chkEmployed.Checked)));
				dbParams.Add(new MySqlParameter("p_Title", txtTitle.Text));

				dbFunctions.ExecuteStoredProc("Add_Employee", dbParams);
			}
			
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
			Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Clear all of the fields.
			txtFirstName.ResetText();
			txtLastName.ResetText();
			txtSSN.ResetText();
			txtEmail.ResetText();
			txtAddress.ResetText();
			txtCity.ResetText();
			txtZip.ResetText();
			txtPassword.ResetText();
			txtDepartment.ResetText();
			txtTitle.ResetText();

			// Reset all of the combo and check boxes.
			chkEmployed.Checked = false;
			cboState.ResetText();
			cboEmployeeType.ResetText();
		}

		private bool CheckInput()
		{
			// Check for empty input.
			if (String.IsNullOrEmpty(txtFirstName.Text))
			{
				MessageBox.Show("Please enter the employee's first name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtFirstName.Focus();
				return false;
      }
			else if (String.IsNullOrEmpty(txtLastName.Text))
			{
				MessageBox.Show("Please enter the employee's last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtLastName.Focus();
				return false;
			}
			else if (String.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Please enter the employee's password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPassword.Focus();
				return false;
			}
			else if (String.IsNullOrEmpty(cboEmployeeType.Text))
			{
				MessageBox.Show("Please select an employee type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cboEmployeeType.Focus();
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
