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
	public partial class frmTimesheet : Form
	{
		public frmTimesheet()
		{
			InitializeComponent();
		}

		private void frmTimesheet_Load(object sender, EventArgs e)
		{
			// Check the user's privledge level, if they are HR or an admin, 
			// show btnReports, btnEmployees, and btnProjects.
		}

		private void btnNewEntry_Click(object sender, EventArgs e)
		{
			// Open frmNewEntry
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			// Open frmReports
		}

		private void btnEmployees_Click(object sender, EventArgs e)
		{
			// Open frmEmployees
		}

		private void btnProjects_Click(object sender, EventArgs e)
		{
			// Open frmProjects
		}
	}
}
