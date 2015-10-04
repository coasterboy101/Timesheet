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
		public frmProjectDetails()
		{
			InitializeComponent();
		}

		private void frmProjectDetails_Load(object sender, EventArgs e)
		{
			// Check for any data being passed from frmProjects, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
			// Populate lstEmployees with the names of all employees in the employees/projects
			// adapter table.
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Display a dialog with a combo box, allowing the user to select an employee to
			// add to the project.
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			// Remove the selected employee from the employees/projects adapter table
			// and update lstEmployees.
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Depending on whether or not the project exists, either update a row or
			// create a new one, then close the form.
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
		}
	}
}
