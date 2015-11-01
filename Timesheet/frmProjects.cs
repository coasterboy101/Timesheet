using MySql.Data.MySqlClient;
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
		private DatabaseFunctions dbFunctions;
		private DataTable dtProjects;
		private DataTable dtClients;
		private DataTable dtTasks;

		public frmProjects()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);

			dtProjects = new DataTable("Projects");
			dtClients = new DataTable("Clients");
			dtTasks = new DataTable("Tasks");
		}

		private void frmProjects_Load(object sender, EventArgs e)
		{
			dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());
			dtClients = dbFunctions.FillStoredProc("Load_Clients", new List<MySqlParameter>());
			dtTasks = dbFunctions.FillStoredProc("Load_Tasks", new List<MySqlParameter>());

			dataGrdProjects.DataSource = dtProjects;
			dataGrdClients.DataSource = dtClients;
			dataGrdTasks.DataSource = dtTasks;
		}

		private void btnAddProject_Click(object sender, EventArgs e)
		{
			// Open frmEmployeeDetails with all fields blank.
			frmProjectDetails newProject = new frmProjectDetails();
			newProject.FormClosed += ProjectDetails_FormClosed;
			newProject.Show();
		}

		private void btnEditProject_Click(object sender, EventArgs e)
		{
			DataRow selectedRow;

			if (dataGrdProjects.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				selectedRow = ((DataRowView)dataGrdProjects.SelectedRows[0].DataBoundItem).Row;

				// Open frmEmployeeDetails with the values of the selected row filled in.
				frmProjectDetails editProject = new frmProjectDetails(selectedRow);
				editProject.FormClosed += ProjectDetails_FormClosed;
				editProject.Show();
			}
			else
			{
				MessageBox.Show("Please select a project to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDeleteProject_Click(object sender, EventArgs e)
		{
			if (dataGrdProjects.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				int projectId = Convert.ToInt32(((DataRowView)dataGrdProjects.SelectedRows[0].DataBoundItem).Row["ProjectId"].ToString());

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ProjectId", projectId));

				// Remove the selected row and delete all of the timesheet entries created by the corresponding employee.
				dbFunctions.ExecuteStoredProc("Delete_Project", dbParams);

				// Refresh the data grid.
				dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());
				dataGrdProjects.DataSource = dtProjects;
			}
			else
			{
				MessageBox.Show("Please select a project to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ProjectDetails_FormClosed(object sender, FormClosedEventArgs e)
		{
			dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());
			dataGrdProjects.DataSource = dtProjects;
		}
	}
}
