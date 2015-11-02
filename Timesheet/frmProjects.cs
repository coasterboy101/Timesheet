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
			// Open frmProjectDetails with all fields blank.
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

				// Open frmClientDetails with the values of the selected row filled in.
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

				// Remove the selected row.
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

		private void btnAddClient_Click(object sender, EventArgs e)
		{
			// Open frmClientDetails with all fields blank.
			frmClientDetails newClient = new frmClientDetails();
			newClient.FormClosed += ClientDetails_FormClosed;
			newClient.Show();
		}

		private void btnEditClient_Click(object sender, EventArgs e)
		{
			DataRow selectedRow;

			if (dataGrdClients.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				selectedRow = ((DataRowView)dataGrdClients.SelectedRows[0].DataBoundItem).Row;

				// Open frmClientDetails with the values of the selected row filled in.
				frmClientDetails editClient = new frmClientDetails(selectedRow);
				editClient.FormClosed += ClientDetails_FormClosed;
				editClient.Show();
			}
			else
			{
				MessageBox.Show("Please select a client to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDeleteClient_Click(object sender, EventArgs e)
		{
			if (dataGrdClients.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				int clientId = Convert.ToInt32(((DataRowView)dataGrdClients.SelectedRows[0].DataBoundItem).Row["ClientId"].ToString());

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ClientId", clientId));

				// Remove the selected row.
				dbFunctions.ExecuteStoredProc("Delete_Client", dbParams);

				// Refresh the data grid.
				dtClients = dbFunctions.FillStoredProc("Load_Clients", new List<MySqlParameter>());
				dataGrdClients.DataSource = dtClients;
			}
			else
			{
				MessageBox.Show("Please select a client to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ClientDetails_FormClosed(object sender, FormClosedEventArgs e)
		{
			dtClients = dbFunctions.FillStoredProc("Load_Clients", new List<MySqlParameter>());
			dataGrdClients.DataSource = dtClients;
		}

		private void btnAddTask_Click(object sender, EventArgs e)
		{
			// Open frmTaskDetails with all fields blank.
			frmTaskDetails newTask = new frmTaskDetails();
			newTask.FormClosed += TaskDetails_FormClosed;
			newTask.Show();
		}

		private void btnEditTask_Click(object sender, EventArgs e)
		{
			DataRow selectedRow;

			if (dataGrdTasks.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				selectedRow = ((DataRowView)dataGrdTasks.SelectedRows[0].DataBoundItem).Row;

				// Open frmClientDetails with the values of the selected row filled in.
				frmTaskDetails editTask = new frmTaskDetails(selectedRow);
				editTask.FormClosed += TaskDetails_FormClosed;
				editTask.Show();
			}
			else
			{
				MessageBox.Show("Please select a task to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnDeleteTask_Click(object sender, EventArgs e)
		{
			if (dataGrdClients.SelectedRows.Count != 0)
			{
				// Get the currently selected row.
				int taskId = Convert.ToInt32(((DataRowView)dataGrdTasks.SelectedRows[0].DataBoundItem).Row["TaskId"].ToString());

				List<MySqlParameter> dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_TaskId", taskId));

				// Remove the selected row.
				dbFunctions.ExecuteStoredProc("Delete_Task", dbParams);

				// Refresh the data grid.
				dtTasks = dbFunctions.FillStoredProc("Load_Tasks", new List<MySqlParameter>());
				dataGrdTasks.DataSource = dtTasks;
			}
			else
			{
				MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void TaskDetails_FormClosed(object sender, FormClosedEventArgs e)
		{
			dtTasks = dbFunctions.FillStoredProc("Load_Tasks", new List<MySqlParameter>());
			dataGrdTasks.DataSource = dtTasks;
		}
	}
}
