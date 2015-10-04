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
	public partial class frmClientDetails : Form
	{
		public frmClientDetails()
		{
			InitializeComponent();
		}

		private void frmClientDetails_Load(object sender, EventArgs e)
		{
			// Check for any data being passed from frmProjects, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Depending on whether or not the client exists, either update a row or
			// create a new one, then close the form.
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
		}
	}
}
