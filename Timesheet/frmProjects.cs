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
	public partial class frmProjects : Form
	{
		public frmProjects()
		{
			InitializeComponent();
		}

		private void cboTableSelection_SelectionChangeCommitted(object sender, EventArgs e)
		{
			// Change the data displayed in dataGrdProjects to the selected table, and change
			// the text property of btnAdd, btnEdit, and btnDelete to match.
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Open either frmProjectDetails, frmClientDetails, or frmTaskDetails based on the selected table
			// and make all fields blank.
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// Open either frmProjectDetails, frmClientDetails, or frmTaskDetails based on the selected table
			// and fill in all fields with the data from the selected row.
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Delete the selected row.
		}
	}
}
