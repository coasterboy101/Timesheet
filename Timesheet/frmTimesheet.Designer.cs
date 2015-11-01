﻿namespace Timesheet
{
	partial class frmTimesheet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheet));
			this.dataGrdTimesheet = new System.Windows.Forms.DataGridView();
			this.gcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNewEntry = new System.Windows.Forms.Button();
			this.btnReports = new System.Windows.Forms.Button();
			this.btnEmployees = new System.Windows.Forms.Button();
			this.btnProjects = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdTimesheet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrdTimesheet
			// 
			this.dataGrdTimesheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrdTimesheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrdTimesheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcDate,
            this.gcHours,
            this.gcProject,
            this.gcClient,
            this.gcTask});
			this.dataGrdTimesheet.Location = new System.Drawing.Point(12, 43);
			this.dataGrdTimesheet.Name = "dataGrdTimesheet";
			this.dataGrdTimesheet.Size = new System.Drawing.Size(760, 407);
			this.dataGrdTimesheet.TabIndex = 0;
			// 
			// gcDate
			// 
			this.gcDate.DataPropertyName = "Date";
			this.gcDate.HeaderText = "Date";
			this.gcDate.Name = "gcDate";
			// 
			// gcHours
			// 
			this.gcHours.DataPropertyName = "Hours";
			this.gcHours.HeaderText = "Hours";
			this.gcHours.Name = "gcHours";
			// 
			// gcProject
			// 
			this.gcProject.DataPropertyName = "ProjectName";
			this.gcProject.HeaderText = "Project";
			this.gcProject.Name = "gcProject";
			// 
			// gcClient
			// 
			this.gcClient.DataPropertyName = "ClientName";
			this.gcClient.HeaderText = "Client";
			this.gcClient.Name = "gcClient";
			// 
			// gcTask
			// 
			this.gcTask.DataPropertyName = "TaskName";
			this.gcTask.HeaderText = "Task";
			this.gcTask.Name = "gcTask";
			// 
			// btnNewEntry
			// 
			this.btnNewEntry.Location = new System.Drawing.Point(12, 12);
			this.btnNewEntry.Name = "btnNewEntry";
			this.btnNewEntry.Size = new System.Drawing.Size(125, 25);
			this.btnNewEntry.TabIndex = 1;
			this.btnNewEntry.Text = "New Entry";
			this.btnNewEntry.UseVisualStyleBackColor = true;
			this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
			// 
			// btnReports
			// 
			this.btnReports.Location = new System.Drawing.Point(385, 12);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(125, 25);
			this.btnReports.TabIndex = 2;
			this.btnReports.Text = "Reports";
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnReports.Visible = false;
			this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
			// 
			// btnEmployees
			// 
			this.btnEmployees.Location = new System.Drawing.Point(516, 12);
			this.btnEmployees.Name = "btnEmployees";
			this.btnEmployees.Size = new System.Drawing.Size(125, 25);
			this.btnEmployees.TabIndex = 3;
			this.btnEmployees.Text = "Manage Employees";
			this.btnEmployees.UseVisualStyleBackColor = true;
			this.btnEmployees.Visible = false;
			this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
			// 
			// btnProjects
			// 
			this.btnProjects.Location = new System.Drawing.Point(647, 12);
			this.btnProjects.Name = "btnProjects";
			this.btnProjects.Size = new System.Drawing.Size(125, 25);
			this.btnProjects.TabIndex = 4;
			this.btnProjects.Text = "Manage Projects";
			this.btnProjects.UseVisualStyleBackColor = true;
			this.btnProjects.Visible = false;
			this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
			// 
			// frmTimesheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 462);
			this.Controls.Add(this.btnProjects);
			this.Controls.Add(this.btnEmployees);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.btnNewEntry);
			this.Controls.Add(this.dataGrdTimesheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmTimesheet";
			this.Text = "Timesheet";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimesheet_FormClosed);
			this.Load += new System.EventHandler(this.frmTimesheet_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrdTimesheet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrdTimesheet;
		private System.Windows.Forms.Button btnNewEntry;
		private System.Windows.Forms.Button btnReports;
		private System.Windows.Forms.Button btnEmployees;
		private System.Windows.Forms.Button btnProjects;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcHours;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcProject;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcClient;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTask;
	}
}