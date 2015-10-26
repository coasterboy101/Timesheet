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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dataGrdProjects = new System.Windows.Forms.DataGridView();
			this.cboTableSelection = new System.Windows.Forms.ComboBox();
			this.gcProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClientDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProject_ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcTaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcTaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClient_Project_ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClient_ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdProjects)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(274, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 25);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete Project";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(143, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(125, 25);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit Project";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(125, 25);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Project";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGrdProjects
			// 
			this.dataGrdProjects.AllowUserToAddRows = false;
			this.dataGrdProjects.AllowUserToDeleteRows = false;
			this.dataGrdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGrdProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcProjectId,
            this.gcProjectName,
            this.gcProjectDescription,
            this.gcClientId,
            this.gcClientName,
            this.gcClientDescription,
            this.gcProject_ProjectId,
            this.gcTaskId,
            this.gcTaskName,
            this.gcTaskDescription,
            this.gcClient_Project_ProjectId,
            this.gcClient_ClientId});
			this.dataGrdProjects.Location = new System.Drawing.Point(12, 42);
			this.dataGrdProjects.Name = "dataGrdProjects";
			this.dataGrdProjects.ReadOnly = true;
			this.dataGrdProjects.Size = new System.Drawing.Size(560, 308);
			this.dataGrdProjects.TabIndex = 4;
			// 
			// cboTableSelection
			// 
			this.cboTableSelection.FormattingEnabled = true;
			this.cboTableSelection.Items.AddRange(new object[] {
            "Projects",
            "Clients",
            "Tasks"});
			this.cboTableSelection.Location = new System.Drawing.Point(422, 15);
			this.cboTableSelection.Name = "cboTableSelection";
			this.cboTableSelection.Size = new System.Drawing.Size(150, 21);
			this.cboTableSelection.TabIndex = 8;
			this.cboTableSelection.SelectionChangeCommitted += new System.EventHandler(this.cboTableSelection_SelectionChangeCommitted);
			// 
			// gcProjectId
			// 
			this.gcProjectId.DataPropertyName = "ProjectId";
			this.gcProjectId.HeaderText = "Project ID";
			this.gcProjectId.Name = "gcProjectId";
			this.gcProjectId.ReadOnly = true;
			// 
			// gcProjectName
			// 
			this.gcProjectName.DataPropertyName = "ProjectName";
			this.gcProjectName.HeaderText = "Project Name";
			this.gcProjectName.Name = "gcProjectName";
			this.gcProjectName.ReadOnly = true;
			// 
			// gcProjectDescription
			// 
			this.gcProjectDescription.DataPropertyName = "ProjectDescription";
			this.gcProjectDescription.HeaderText = "Project Description";
			this.gcProjectDescription.Name = "gcProjectDescription";
			this.gcProjectDescription.ReadOnly = true;
			// 
			// gcClientId
			// 
			this.gcClientId.DataPropertyName = "ClientId";
			this.gcClientId.HeaderText = "Client ID";
			this.gcClientId.Name = "gcClientId";
			this.gcClientId.ReadOnly = true;
			this.gcClientId.Visible = false;
			// 
			// gcClientName
			// 
			this.gcClientName.DataPropertyName = "ClientName";
			this.gcClientName.HeaderText = "Client Name";
			this.gcClientName.Name = "gcClientName";
			this.gcClientName.ReadOnly = true;
			this.gcClientName.Visible = false;
			// 
			// gcClientDescription
			// 
			this.gcClientDescription.DataPropertyName = "ClientDescription";
			this.gcClientDescription.HeaderText = "Client Description";
			this.gcClientDescription.Name = "gcClientDescription";
			this.gcClientDescription.ReadOnly = true;
			this.gcClientDescription.Visible = false;
			// 
			// gcProject_ProjectId
			// 
			this.gcProject_ProjectId.DataPropertyName = "Project_ProjectId";
			this.gcProject_ProjectId.HeaderText = "Project ID";
			this.gcProject_ProjectId.Name = "gcProject_ProjectId";
			this.gcProject_ProjectId.ReadOnly = true;
			this.gcProject_ProjectId.Visible = false;
			// 
			// gcTaskId
			// 
			this.gcTaskId.DataPropertyName = "TaskId";
			this.gcTaskId.HeaderText = "Task ID";
			this.gcTaskId.Name = "gcTaskId";
			this.gcTaskId.ReadOnly = true;
			this.gcTaskId.Visible = false;
			// 
			// gcTaskName
			// 
			this.gcTaskName.DataPropertyName = "TaskName";
			this.gcTaskName.HeaderText = "Task Name";
			this.gcTaskName.Name = "gcTaskName";
			this.gcTaskName.ReadOnly = true;
			this.gcTaskName.Visible = false;
			// 
			// gcTaskDescription
			// 
			this.gcTaskDescription.DataPropertyName = "TaskDescription";
			this.gcTaskDescription.HeaderText = "Task Description";
			this.gcTaskDescription.Name = "gcTaskDescription";
			this.gcTaskDescription.ReadOnly = true;
			this.gcTaskDescription.Visible = false;
			// 
			// gcClient_Project_ProjectId
			// 
			this.gcClient_Project_ProjectId.DataPropertyName = "Client_Project_ProjectId";
			this.gcClient_Project_ProjectId.HeaderText = "Project ID";
			this.gcClient_Project_ProjectId.Name = "gcClient_Project_ProjectId";
			this.gcClient_Project_ProjectId.ReadOnly = true;
			this.gcClient_Project_ProjectId.Visible = false;
			// 
			// gcClient_ClientId
			// 
			this.gcClient_ClientId.DataPropertyName = "Client_ClientId";
			this.gcClient_ClientId.HeaderText = "Client ID";
			this.gcClient_ClientId.Name = "gcClient_ClientId";
			this.gcClient_ClientId.ReadOnly = true;
			this.gcClient_ClientId.Visible = false;
			// 
			// frmProjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 362);
			this.Controls.Add(this.cboTableSelection);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGrdProjects);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProjects";
			this.ShowInTaskbar = false;
			this.Text = "Projects";
			((System.ComponentModel.ISupportInitialize)(this.dataGrdProjects)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dataGrdProjects;
		private System.Windows.Forms.ComboBox cboTableSelection;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProjectDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClientId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClientName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClientDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProject_ProjectId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTaskId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTaskName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTaskDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClient_Project_ProjectId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClient_ClientId;
	}
}