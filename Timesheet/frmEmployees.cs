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
	public partial class frmEmployees : Form
	{
		private DatabaseFunctions dbFunctions;
		private DataTable dtEmployees;

		public frmEmployees()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			dtEmployees = new DataTable("Employees");
		}

		private void frmEmployees_Load(object sender, EventArgs e)
		{
			dtEmployees = dbFunctions.FillStoredProc("Load_Employees", new List<MySqlParameter>());

			dataGrdEmployees.DataSource = dtEmployees;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Open frmEmployeeDetails with all fields blank.
			frmEmployeeDetails newEmployee = new frmEmployeeDetails();
			newEmployee.FormClosed += EmployeeDetails_FormClosed;
			newEmployee.Show();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			DataRow selectedRow;

			if (dataGrdEmployees.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				selectedRow = ((DataRowView)dataGrdEmployees.SelectedRows[0].DataBoundItem).Row;

				// Open frmEmployeeDetails with the values of the selected row filled in.
				frmEmployeeDetails editEmployee = new frmEmployeeDetails(selectedRow);
				editEmployee.FormClosed += EmployeeDetails_FormClosed;
				editEmployee.Show();
			}
			else 
			{
				MessageBox.Show("Please select an employee to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
      if (dataGrdEmployees.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				int employeeId = Convert.ToInt32(((DataRowView)dataGrdEmployees.SelectedRows[0].DataBoundItem).Row["EmpId"].ToString());

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_EmpId", employeeId));

				// Remove the selected row and delete all of the timesheet entries created by the corresponding employee.
				dbFunctions.ExecuteStoredProc("Delete_Employee", dbParams);

				// Refresh the data grid.
				dtEmployees = dbFunctions.FillStoredProc("Load_Employees", new List<MySqlParameter>());
				dataGrdEmployees.DataSource = dtEmployees;
			}
			else
			{
				MessageBox.Show("Please select an employee to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void EmployeeDetails_FormClosed(object sender, FormClosedEventArgs e)
		{
			dtEmployees = dbFunctions.FillStoredProc("Load_Employees", new List<MySqlParameter>());
			dataGrdEmployees.DataSource = dtEmployees;
		}
	}
}
