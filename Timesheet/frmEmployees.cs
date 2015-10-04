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
	public partial class frmEmployees : Form
	{
		public frmEmployees()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// Open frmEmployeeDetails with all fields blank.
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// Open frmEmployeeDetails with the values of the selected row filled in.
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Remove the selected row and delete all of the timesheet entries created by them.
		}
	}
}
