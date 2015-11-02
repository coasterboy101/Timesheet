using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Timesheet
{
	public partial class frmClientDetails : Form
	{
		private DataTable dtProjects;
		
		private DataRow drClient;

		private DatabaseFunctions dbFunctions;

		public frmClientDetails()
		{
			InitializeComponent();

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);
		}

		public frmClientDetails(DataRow drClient)
		{
			InitializeComponent();

			this.drClient = drClient;

			dbFunctions = new DatabaseFunctions(Properties.Settings.Default.timesheetConnectionString);
		}

		private void frmClientDetails_Load(object sender, EventArgs e)
		{
			// Load the list of Projects from the database, then add them to cboProjects.
			dtProjects = dbFunctions.FillStoredProc("Load_Projects", new List<MySqlParameter>());

			if (dtProjects.Rows.Count > 0)
			{
				foreach (DataRow dr in dtProjects.Rows)
				{
					cboProject.Items.Add(String.Format("{0} {1}", dr["ProjectId"].ToString(), dr["ProjectName"].ToString()));
				}
			}
			
			// Check for any data being passed from frmProjects, if there is some,
			// fill in the fields with it. Otherwise, leave everything blank.
			if (drClient != null)
			{
				txtName.Text = drClient["ClientName"].ToString();
				txtDescription.Text = drClient["ClientDescription"].ToString();
				cboProject.SelectedItem = String.Format("{0} {1}", drClient["ProjectId"].ToString(), drClient["ProjectName"].ToString());
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (cboProject.SelectedItem != null)
			{
				string projectId = cboProject.SelectedItem.ToString().Split(' ').First();

				// Depending on whether or not the client exists, either update a row or
				// create a new one, then close the form.
				if (drClient != null)
				{
					List<MySqlParameter> dbParams = new List<MySqlParameter>();
					dbParams.Add(new MySqlParameter("p_ClientId", drClient["ClientId"].ToString()));
					dbParams.Add(new MySqlParameter("p_ClientName", txtName.Text));
					dbParams.Add(new MySqlParameter("p_ClientDescription", txtDescription.Text));
					dbParams.Add(new MySqlParameter("p_ProjectId", projectId));

					dbFunctions.ExecuteStoredProc("Update_Client", dbParams);
	      }
				else
				{
					List<MySqlParameter> dbParams = new List<MySqlParameter>();
					dbParams.Add(new MySqlParameter("p_ClientName", txtName.Text));
					dbParams.Add(new MySqlParameter("p_ClientDescription", txtDescription.Text));
					dbParams.Add(new MySqlParameter("p_ProjectId", projectId));

					dbFunctions.ExecuteStoredProc("Add_Client", dbParams);
				}

				Close();
			}
			else
			{
				MessageBox.Show("Please select a project to list the client under.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close the form, and do nothing with the data.
			Close();
		}
	}
}
