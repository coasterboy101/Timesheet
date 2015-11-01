namespace Timesheet
{
	partial class frmProjects
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjects));
			this.tabCtlProjects = new System.Windows.Forms.TabControl();
			this.tabProjects = new System.Windows.Forms.TabPage();
			this.tabClients = new System.Windows.Forms.TabPage();
			this.btnDeleteProject = new System.Windows.Forms.Button();
			this.btnEditProject = new System.Windows.Forms.Button();
			this.btnAddProject = new System.Windows.Forms.Button();
			this.tabTasks = new System.Windows.Forms.TabPage();
			this.dataGrdProjects = new System.Windows.Forms.DataGridView();
			this.gcProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGrdClients = new System.Windows.Forms.DataGridView();
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.btnAddClient = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.dataGrdTasks = new System.Windows.Forms.DataGridView();
			this.btnDeleteTask = new System.Windows.Forms.Button();
			this.btnAddTask = new System.Windows.Forms.Button();
			this.btnEditTask = new System.Windows.Forms.Button();
			this.gcTaskProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcTaskClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClientProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabCtlProjects.SuspendLayout();
			this.tabProjects.SuspendLayout();
			this.tabClients.SuspendLayout();
			this.tabTasks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdProjects)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdClients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdTasks)).BeginInit();
			this.SuspendLayout();
			// 
			// tabCtlProjects
			// 
			this.tabCtlProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtlProjects.Controls.Add(this.tabProjects);
			this.tabCtlProjects.Controls.Add(this.tabClients);
			this.tabCtlProjects.Controls.Add(this.tabTasks);
			this.tabCtlProjects.ItemSize = new System.Drawing.Size(100, 20);
			this.tabCtlProjects.Location = new System.Drawing.Point(12, 12);
			this.tabCtlProjects.Name = "tabCtlProjects";
			this.tabCtlProjects.SelectedIndex = 0;
			this.tabCtlProjects.Size = new System.Drawing.Size(660, 438);
			this.tabCtlProjects.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabCtlProjects.TabIndex = 0;
			// 
			// tabProjects
			// 
			this.tabProjects.Controls.Add(this.dataGrdProjects);
			this.tabProjects.Controls.Add(this.btnDeleteProject);
			this.tabProjects.Controls.Add(this.btnAddProject);
			this.tabProjects.Controls.Add(this.btnEditProject);
			this.tabProjects.Location = new System.Drawing.Point(4, 24);
			this.tabProjects.Name = "tabProjects";
			this.tabProjects.Padding = new System.Windows.Forms.Padding(3);
			this.tabProjects.Size = new System.Drawing.Size(652, 410);
			this.tabProjects.TabIndex = 0;
			this.tabProjects.Text = "Projects";
			this.tabProjects.UseVisualStyleBackColor = true;
			// 
			// tabClients
			// 
			this.tabClients.Controls.Add(this.dataGrdClients);
			this.tabClients.Controls.Add(this.btnDeleteClient);
			this.tabClients.Controls.Add(this.btnAddClient);
			this.tabClients.Controls.Add(this.btnEditClient);
			this.tabClients.Location = new System.Drawing.Point(4, 24);
			this.tabClients.Name = "tabClients";
			this.tabClients.Padding = new System.Windows.Forms.Padding(3);
			this.tabClients.Size = new System.Drawing.Size(652, 410);
			this.tabClients.TabIndex = 1;
			this.tabClients.Text = "Clients";
			this.tabClients.UseVisualStyleBackColor = true;
			// 
			// btnDeleteProject
			// 
			this.btnDeleteProject.Location = new System.Drawing.Point(268, 6);
			this.btnDeleteProject.Name = "btnDeleteProject";
			this.btnDeleteProject.Size = new System.Drawing.Size(125, 25);
			this.btnDeleteProject.TabIndex = 11;
			this.btnDeleteProject.Text = "Delete Project";
			this.btnDeleteProject.UseVisualStyleBackColor = true;
			this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
			// 
			// btnEditProject
			// 
			this.btnEditProject.Location = new System.Drawing.Point(137, 6);
			this.btnEditProject.Name = "btnEditProject";
			this.btnEditProject.Size = new System.Drawing.Size(125, 25);
			this.btnEditProject.TabIndex = 10;
			this.btnEditProject.Text = "Edit Project";
			this.btnEditProject.UseVisualStyleBackColor = true;
			this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click);
			// 
			// btnAddProject
			// 
			this.btnAddProject.Location = new System.Drawing.Point(6, 6);
			this.btnAddProject.Name = "btnAddProject";
			this.btnAddProject.Size = new System.Drawing.Size(125, 25);
			this.btnAddProject.TabIndex = 9;
			this.btnAddProject.Text = "Add Project";
			this.btnAddProject.UseVisualStyleBackColor = true;
			this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
			// 
			// tabTasks
			// 
			this.tabTasks.Controls.Add(this.dataGrdTasks);
			this.tabTasks.Controls.Add(this.btnDeleteTask);
			this.tabTasks.Controls.Add(this.btnAddTask);
			this.tabTasks.Controls.Add(this.btnEditTask);
			this.tabTasks.Location = new System.Drawing.Point(4, 24);
			this.tabTasks.Name = "tabTasks";
			this.tabTasks.Size = new System.Drawing.Size(652, 410);
			this.tabTasks.TabIndex = 2;
			this.tabTasks.Text = "Tasks";
			this.tabTasks.UseVisualStyleBackColor = true;
			// 
			// dataGrdProjects
			// 
			this.dataGrdProjects.AllowUserToAddRows = false;
			this.dataGrdProjects.AllowUserToDeleteRows = false;
			this.dataGrdProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGrdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcProjectId,
            this.gcProjectName,
            this.gcProjectDescription});
			this.dataGrdProjects.Location = new System.Drawing.Point(6, 37);
			this.dataGrdProjects.Name = "dataGrdProjects";
			this.dataGrdProjects.ReadOnly = true;
			this.dataGrdProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrdProjects.Size = new System.Drawing.Size(640, 367);
			this.dataGrdProjects.TabIndex = 12;
			// 
			// gcProjectId
			// 
			this.gcProjectId.DataPropertyName = "ProjectId";
			this.gcProjectId.HeaderText = "Project ID";
			this.gcProjectId.MinimumWidth = 75;
			this.gcProjectId.Name = "gcProjectId";
			this.gcProjectId.ReadOnly = true;
			this.gcProjectId.Width = 75;
			// 
			// gcProjectName
			// 
			this.gcProjectName.DataPropertyName = "ProjectName";
			this.gcProjectName.HeaderText = "Project Name";
			this.gcProjectName.MinimumWidth = 125;
			this.gcProjectName.Name = "gcProjectName";
			this.gcProjectName.ReadOnly = true;
			this.gcProjectName.Width = 125;
			// 
			// gcProjectDescription
			// 
			this.gcProjectDescription.DataPropertyName = "ProjectDescription";
			this.gcProjectDescription.HeaderText = "Project Description";
			this.gcProjectDescription.MinimumWidth = 300;
			this.gcProjectDescription.Name = "gcProjectDescription";
			this.gcProjectDescription.ReadOnly = true;
			this.gcProjectDescription.Width = 300;
			// 
			// dataGrdClients
			// 
			this.dataGrdClients.AllowUserToAddRows = false;
			this.dataGrdClients.AllowUserToDeleteRows = false;
			this.dataGrdClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGrdClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcClientProject,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGrdClients.Location = new System.Drawing.Point(6, 37);
			this.dataGrdClients.Name = "dataGrdClients";
			this.dataGrdClients.ReadOnly = true;
			this.dataGrdClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrdClients.Size = new System.Drawing.Size(640, 367);
			this.dataGrdClients.TabIndex = 16;
			// 
			// btnDeleteClient
			// 
			this.btnDeleteClient.Location = new System.Drawing.Point(268, 6);
			this.btnDeleteClient.Name = "btnDeleteClient";
			this.btnDeleteClient.Size = new System.Drawing.Size(125, 25);
			this.btnDeleteClient.TabIndex = 15;
			this.btnDeleteClient.Text = "Delete Client";
			this.btnDeleteClient.UseVisualStyleBackColor = true;
			// 
			// btnAddClient
			// 
			this.btnAddClient.Location = new System.Drawing.Point(6, 6);
			this.btnAddClient.Name = "btnAddClient";
			this.btnAddClient.Size = new System.Drawing.Size(125, 25);
			this.btnAddClient.TabIndex = 13;
			this.btnAddClient.Text = "Add Client";
			this.btnAddClient.UseVisualStyleBackColor = true;
			// 
			// btnEditClient
			// 
			this.btnEditClient.Location = new System.Drawing.Point(137, 6);
			this.btnEditClient.Name = "btnEditClient";
			this.btnEditClient.Size = new System.Drawing.Size(125, 25);
			this.btnEditClient.TabIndex = 14;
			this.btnEditClient.Text = "Edit Client";
			this.btnEditClient.UseVisualStyleBackColor = true;
			// 
			// dataGrdTasks
			// 
			this.dataGrdTasks.AllowUserToAddRows = false;
			this.dataGrdTasks.AllowUserToDeleteRows = false;
			this.dataGrdTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGrdTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcTaskProject,
            this.gcTaskClient,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dataGrdTasks.Location = new System.Drawing.Point(6, 37);
			this.dataGrdTasks.Name = "dataGrdTasks";
			this.dataGrdTasks.ReadOnly = true;
			this.dataGrdTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrdTasks.Size = new System.Drawing.Size(640, 367);
			this.dataGrdTasks.TabIndex = 16;
			// 
			// btnDeleteTask
			// 
			this.btnDeleteTask.Location = new System.Drawing.Point(268, 6);
			this.btnDeleteTask.Name = "btnDeleteTask";
			this.btnDeleteTask.Size = new System.Drawing.Size(125, 25);
			this.btnDeleteTask.TabIndex = 15;
			this.btnDeleteTask.Text = "Delete Task";
			this.btnDeleteTask.UseVisualStyleBackColor = true;
			// 
			// btnAddTask
			// 
			this.btnAddTask.Location = new System.Drawing.Point(6, 6);
			this.btnAddTask.Name = "btnAddTask";
			this.btnAddTask.Size = new System.Drawing.Size(125, 25);
			this.btnAddTask.TabIndex = 13;
			this.btnAddTask.Text = "Add Task";
			this.btnAddTask.UseVisualStyleBackColor = true;
			// 
			// btnEditTask
			// 
			this.btnEditTask.Location = new System.Drawing.Point(137, 6);
			this.btnEditTask.Name = "btnEditTask";
			this.btnEditTask.Size = new System.Drawing.Size(125, 25);
			this.btnEditTask.TabIndex = 14;
			this.btnEditTask.Text = "Edit Task";
			this.btnEditTask.UseVisualStyleBackColor = true;
			// 
			// gcTaskProject
			// 
			this.gcTaskProject.DataPropertyName = "ProjectName";
			this.gcTaskProject.HeaderText = "Project";
			this.gcTaskProject.Name = "gcTaskProject";
			this.gcTaskProject.ReadOnly = true;
			// 
			// gcTaskClient
			// 
			this.gcTaskClient.DataPropertyName = "ClientName";
			this.gcTaskClient.HeaderText = "Client";
			this.gcTaskClient.Name = "gcTaskClient";
			this.gcTaskClient.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "TaskId";
			this.dataGridViewTextBoxColumn4.HeaderText = "Task ID";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 75;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 75;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "TaskName";
			this.dataGridViewTextBoxColumn5.HeaderText = "Task Name";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 125;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 125;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "TaskDescription";
			this.dataGridViewTextBoxColumn6.HeaderText = "Task Description";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 300;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 300;
			// 
			// gcClientProject
			// 
			this.gcClientProject.DataPropertyName = "ProjectName";
			this.gcClientProject.HeaderText = "Project";
			this.gcClientProject.Name = "gcClientProject";
			this.gcClientProject.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientId";
			this.dataGridViewTextBoxColumn1.HeaderText = "Client ID";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 75;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 75;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Client Name";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 125;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ClientDescription";
			this.dataGridViewTextBoxColumn3.HeaderText = "Client Description";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 300;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 300;
			// 
			// frmProjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 462);
			this.Controls.Add(this.tabCtlProjects);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProjects";
			this.ShowInTaskbar = false;
			this.Text = "Projects";
			this.Load += new System.EventHandler(this.frmProjects_Load);
			this.tabCtlProjects.ResumeLayout(false);
			this.tabProjects.ResumeLayout(false);
			this.tabClients.ResumeLayout(false);
			this.tabTasks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrdProjects)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdClients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdTasks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabCtlProjects;
		private System.Windows.Forms.TabPage tabProjects;
		private System.Windows.Forms.Button btnDeleteProject;
		private System.Windows.Forms.Button btnAddProject;
		private System.Windows.Forms.Button btnEditProject;
		private System.Windows.Forms.TabPage tabClients;
		private System.Windows.Forms.DataGridView dataGrdProjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectDescription;
		private System.Windows.Forms.TabPage tabTasks;
		private System.Windows.Forms.DataGridView dataGrdClients;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClientProject;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button btnDeleteClient;
		private System.Windows.Forms.Button btnAddClient;
		private System.Windows.Forms.Button btnEditClient;
		private System.Windows.Forms.DataGridView dataGrdTasks;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTaskProject;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTaskClient;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Button btnDeleteTask;
		private System.Windows.Forms.Button btnAddTask;
		private System.Windows.Forms.Button btnEditTask;
	}
}