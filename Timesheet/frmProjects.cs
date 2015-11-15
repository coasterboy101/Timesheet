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
				string messageText;
				DialogResult result;

				List<MySqlParameter> dbParams = new List<MySqlParameter>();

				// Get the currently selected Project's ID.
				int projectId = Convert.ToInt32(((DataRowView)dataGrdProjects.SelectedRows[0].DataBoundItem).Row["ProjectId"].ToString());

				// Get any referenced rows.
				DataTable dtProjectTimesheets = GetProjectTimesheets(projectId);
				DataTable dtProjectClients = GetProjectClients(projectId);
				DataTable dtProjectTasks = GetProjectTasks(projectId);

				// Project has Client, Task, and Timesheet references.
				if (dtProjectTimesheets.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this project will delete {0} clients, {1} tasks, and {2} timesheet records. " 
						+ "Are you sure you want to continue?", dtProjectClients.Rows.Count, dtProjectTasks.Rows.Count, 
						dtProjectTimesheets.Rows.Count);

          result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Client, Task, and Timesheet references.
					if (result == DialogResult.OK)
					{
						DeleteTimesheets(dtProjectTimesheets);
						DeleteTasks(dtProjectTasks);
						DeleteClients(dtProjectClients);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				// Project has Client and Task references.
				else if (dtProjectClients.Rows.Count > 0 && dtProjectTasks.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this project will delete {0} clients and {1} tasks. " 
						+ "Are you sure you want to continue?", dtProjectClients.Rows.Count, dtProjectTasks.Rows.Count);

          result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Client and Task references.
					if (result == DialogResult.OK)
					{
						DeleteTasks(dtProjectTasks);
						DeleteClients(dtProjectClients);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				// Project has Client references
				else if (dtProjectClients.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this project will delete {0} clients. "
						+ "Are you sure you want to continue?", dtProjectClients.Rows.Count);

					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Client references.
					if (result == DialogResult.OK)
					{
						DeleteClients(dtProjectClients);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				// Project has no references.
				else
				{
					messageText = String.Format("Deleting a project cannot be undone. Are you sure you want to continue?",
						dtProjectClients.Rows.Count);

					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete the project.
					if (result == DialogResult.OK)
					{
						// Delete the selected Project.
						dbParams = new List<MySqlParameter>();
						dbParams.Add(new MySqlParameter("p_ProjectId", projectId));
						dbFunctions.ExecuteStoredProc("Delete_Project", dbParams);

						// Refresh the data grid.
						dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());
						dataGrdProjects.DataSource = dtProjects;
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
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
				string messageText;
				DialogResult result;

				List<MySqlParameter> dbParams = new List<MySqlParameter>();

				// Get the currently selected Client's ID.
				int clientId = Convert.ToInt32(((DataRowView)dataGrdClients.SelectedRows[0].DataBoundItem).Row["ClientId"].ToString());

				// Get any referenced rows.
				DataTable dtClientTimesheets = GetClientTimesheets(clientId);
				DataTable dtClientTasks = GetClientTasks(clientId);

				// Client has Task and Timesheet references.
				if (dtClientTimesheets.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this client will delete {0} tasks and {1} timesheet records. "
						+ "Are you sure you want to continue?", dtClientTasks.Rows.Count, dtClientTimesheets.Rows.Count);

					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Task and Timesheet references.
					if (result == DialogResult.OK)
					{
						DeleteTimesheets(dtClientTimesheets);
						DeleteTasks(dtClientTasks);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				// Client has Task references
				else if (dtClientTasks.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this client will delete {0} tasks. "
						+ "Are you sure you want to continue?", dtClientTasks.Rows.Count);
          
					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Task references.
					if (result == DialogResult.OK)
					{
						DeleteTasks(dtClientTasks);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				// Client has no references.
				else
				{
					messageText = String.Format("Deleting a client cannot be undone. Are you sure you want to continue?", 
						dtClientTasks.Rows.Count);

					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Task references.
					if (result == DialogResult.OK)
					{
						// Delete the selected entry.
						dbParams = new List<MySqlParameter>();
						dbParams.Add(new MySqlParameter("p_ClientId", clientId));
						dbFunctions.ExecuteStoredProc("Delete_Client", dbParams);

						// Refresh the data grid.
						dtClients = dbFunctions.FillStoredProc("Load_Clients", new List<MySqlParameter>());
						dataGrdClients.DataSource = dtClients;
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
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
			if (dataGrdTasks.SelectedRows.Count != 0)
			{
				string messageText;
				DialogResult result;	

				List<MySqlParameter> dbParams = new List<MySqlParameter>();

				// Get the currently selected Task's ID.
				int taskId = Convert.ToInt32(((DataRowView)dataGrdTasks.SelectedRows[0].DataBoundItem).Row["TaskId"].ToString());

				// Get any referenced rows.
				DataTable dtTimesheet = GetTaskTimesheets(taskId);

				// Task has Timesheet entries.
				if (dtTimesheet.Rows.Count > 0)
				{
					messageText = String.Format("Deleting this task will delete {0} timesheet entries. "
						+ "Are you sure you want to continue?", dtTimesheet.Rows.Count);

          result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Timesheet references.
					if (result == DialogResult.OK)
					{
						DeleteTimesheets(dtTimesheet);
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
				else
				{
					messageText = String.Format("Deleting a task cannot be undone. Are you sure you want to continue?", 
						dtTimesheet.Rows.Count);

					result = MessageBox.Show(messageText, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

					// User wants to continue, go ahead and delete Timesheet references.
					if (result == DialogResult.OK)
					{
						// Delete the selected Task.
						dbParams = new List<MySqlParameter>();
						dbParams.Add(new MySqlParameter("p_TaskId", taskId));
						dbFunctions.ExecuteStoredProc("Delete_Task", dbParams);

						// Refresh the data grid.
						dtTasks = dbFunctions.FillStoredProc("Load_Tasks", new List<MySqlParameter>());
						dataGrdTasks.DataSource = dtTasks;
					}
					// User does not want to continue, cancel the operation.
					else
					{
						return;
					}
				}
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

		/// <summary>
		/// Returns a datatable containing all timesheet entries that reference the given task.
		/// </summary>
		/// <param name="taskId">The task ID to check for.</param>
		private DataTable GetTaskTimesheets(int taskId)
		{
			DataTable dtTimesheet = new DataTable("Timesheet");

			string dbSql = "SELECT * FROM Timesheet WHERE Task_TaskId = @taskId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@taskId", taskId));

			dtTimesheet = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtTimesheet;
		}

		/// <summary>
		/// Returns a datatable containing all timesheet entries that reference the given client.
		/// </summary>
		/// <param name="clientId">The client ID to check for.</param>
		private DataTable GetClientTimesheets(int clientId)
		{
			DataTable dtTimesheet = new DataTable("Timesheet");

			string dbSql = "SELECT * FROM Timesheet WHERE Client_ClientId = @clientId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@clientId", clientId));

			dtTimesheet = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtTimesheet;
		}

		/// <summary>
		/// Returns a datatable containing all task entries that reference the given client.
		/// </summary>
		/// <param name="clientId">The client ID to check for.</param>
		private DataTable GetClientTasks(int clientId)
		{
			DataTable dtTasks = new DataTable("Tasks");

			string dbSql = "SELECT * FROM Task WHERE Client_ClientId = @clientId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@clientId", clientId));

			dtTasks = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtTasks;
		}

		/// <summary>
		/// Returns a datatable containing all timesheet entries that reference the given project.
		/// </summary>
		/// <param name="projectId">The project ID to check for.</param>
		private DataTable GetProjectTimesheets(int projectId)
		{
			DataTable dtTimesheet = new DataTable("Timesheet");

			string dbSql = "SELECT * FROM Timesheet WHERE Project_ProjectId = @projectId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@projectId", projectId));

			dtTimesheet = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtTimesheet;
		}

		/// <summary>
		/// Returns a datatable containing all client entries that reference the given project.
		/// </summary>
		/// <param name="projectId">The project ID to check for.</param>
		private DataTable GetProjectClients(int projectId)
		{
			DataTable dtClients = new DataTable("Clients");

			string dbSql = "SELECT * FROM Client WHERE Project_ProjectId = @projectId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@projectId", projectId));

			dtClients = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtClients;
		}

		/// <summary>
		/// Returns a datatable containing all task entries that reference the given project.
		/// </summary>
		/// <param name="projectId">The project ID to check for.</param>
		private DataTable GetProjectTasks(int projectId)
		{
			DataTable dtTasks = new DataTable("Tasks");

			string dbSql = "SELECT * FROM Task WHERE Client_Project_ProjectId = @projectId";

			List<MySqlParameter> dbParams = new List<MySqlParameter>();
			dbParams.Add(new MySqlParameter("@projectId", projectId));

			dtTasks = dbFunctions.FillInlineSql(dbSql, dbParams);

			return dtTasks;
		}

		/// <summary>
		/// Deletes a batch of timesheet entries.
		/// </summary>
		/// <param name="timesheetEntries">A datatable containing the timesheet entries to delete.</param>
		private void DeleteTimesheets(DataTable timesheetEntries)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();

			foreach (DataRow dr in timesheetEntries.Rows)
			{
				dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_TimesheetId", Convert.ToInt32(dr["TimesheetId"].ToString())));

				dbFunctions.ExecuteStoredProc("Delete_Timesheet", dbParams);
			}
		}

		/// <summary>
		/// Deletes a batch of task entries.
		/// </summary>
		/// <param name="taskEntries">A datatable containing the task entries to delete.</param>
		private void DeleteTasks(DataTable taskEntries)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();

			foreach (DataRow dr in taskEntries.Rows)
			{
				dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_TaskId", Convert.ToInt32(dr["TaskId"].ToString())));

				dbFunctions.ExecuteStoredProc("Delete_Task", dbParams);
			}
		}

		/// <summary>
		/// Deletes a batch of clients.
		/// </summary>
		/// <param name="clientEntries">A datatable containing the clients to delete.</param>
		private void DeleteClients(DataTable clientEntries)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();

			foreach (DataRow dr in clientEntries.Rows)
			{
				dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_ClientId", Convert.ToInt32(dr["ClientId"].ToString())));

				dbFunctions.ExecuteStoredProc("Delete_Client", dbParams);
			}
		}

		/// <summary>
		/// Deletes all of the employees currently assigned to a particular project.
		/// </summary>
		/// <param name="projectId">The ID of the project to remove all employees from.</param>
		private void DeleteProjectEmployees(int projectId)
		{
			List<MySqlParameter> dbParams = new List<MySqlParameter>();

			// Get all of the Employee_Has_Project entries for the given Project ID.
			DataTable dtProjectEmployees = new DataTable("Employee_Has_Projects");

			string dbSql = "SELECT * FROM Employee_Has_Project WHERE Project_ProjectId = @projectId";

			dbParams.Add(new MySqlParameter("@projectId", projectId));

			dtProjectEmployees = dbFunctions.FillInlineSql(dbSql, dbParams);

			foreach (DataRow dr in dtProjectEmployees.Rows)
			{
				dbParams = new List<MySqlParameter>();
				dbParams.Add(new MySqlParameter("p_EmpId", Convert.ToInt32(dr["Employee_EmpId"].ToString())));
				dbParams.Add(new MySqlParameter("p_ProjectId", projectId));

				dbFunctions.ExecuteStoredProc("Delete_Project_Employee", dbParams);
			}
		}
	}
}
