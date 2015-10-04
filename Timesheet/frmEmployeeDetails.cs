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
	public partial class frmEmployeeDetails : Form
	{
		public frmEmployeeDetails()
		{
			InitializeComponent();
		}

		private void frmEmployeeDetails_Load(object sender, EventArgs e)
		{
			// Check for any data being passed from frmEmployees, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Depending on whether or not the employee exists, either update a row or
			// create a new one, then close the form.
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Clear all of the fields.
		}
	}
}
