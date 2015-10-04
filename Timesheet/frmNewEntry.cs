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
	public partial class frmNewEntry : Form
	{
		public frmNewEntry()
		{
			InitializeComponent();
		}

		private void frmNewEntry_Load(object sender, EventArgs e)
		{
			// Set clndrDate to the current date.
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Check the values the user entered, and if they are acceptable,
			// create a new entry in the database and close the form.
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form and do nothing with the data.
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Clear all of the combo boxes and reset the calendar to the current date.
		}
	}
}
