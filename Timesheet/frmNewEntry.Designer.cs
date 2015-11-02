namespace Timesheet
{
	partial class frmNewEntry
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewEntry));
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblProject = new System.Windows.Forms.Label();
			this.lblClient = new System.Windows.Forms.Label();
			this.lblTask = new System.Windows.Forms.Label();
			this.cboProject = new System.Windows.Forms.ComboBox();
			this.cboClient = new System.Windows.Forms.ComboBox();
			this.cboTask = new System.Windows.Forms.ComboBox();
			this.clndrDate = new System.Windows.Forms.MonthCalendar();
			this.cboMinutes = new System.Windows.Forms.ComboBox();
			this.cboHours = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(397, 202);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 0;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(316, 202);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(235, 202);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save Entry";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblProject
			// 
			this.lblProject.Location = new System.Drawing.Point(12, 12);
			this.lblProject.Name = "lblProject";
			this.lblProject.Size = new System.Drawing.Size(50, 21);
			this.lblProject.TabIndex = 3;
			this.lblProject.Text = "Project:";
			this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblClient
			// 
			this.lblClient.Location = new System.Drawing.Point(12, 39);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(50, 21);
			this.lblClient.TabIndex = 4;
			this.lblClient.Text = "Client:";
			this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTask
			// 
			this.lblTask.Location = new System.Drawing.Point(12, 66);
			this.lblTask.Name = "lblTask";
			this.lblTask.Size = new System.Drawing.Size(50, 21);
			this.lblTask.TabIndex = 5;
			this.lblTask.Text = "Task:";
			this.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboProject
			// 
			this.cboProject.FormattingEnabled = true;
			this.cboProject.Location = new System.Drawing.Point(68, 12);
			this.cboProject.Name = "cboProject";
			this.cboProject.Size = new System.Drawing.Size(150, 21);
			this.cboProject.TabIndex = 6;
			this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
			// 
			// cboClient
			// 
			this.cboClient.FormattingEnabled = true;
			this.cboClient.Location = new System.Drawing.Point(68, 39);
			this.cboClient.Name = "cboClient";
			this.cboClient.Size = new System.Drawing.Size(150, 21);
			this.cboClient.TabIndex = 7;
			this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
			// 
			// cboTask
			// 
			this.cboTask.FormattingEnabled = true;
			this.cboTask.Location = new System.Drawing.Point(68, 66);
			this.cboTask.Name = "cboTask";
			this.cboTask.Size = new System.Drawing.Size(150, 21);
			this.cboTask.TabIndex = 8;
			// 
			// clndrDate
			// 
			this.clndrDate.Location = new System.Drawing.Point(230, 12);
			this.clndrDate.Name = "clndrDate";
			this.clndrDate.TabIndex = 9;
			// 
			// cboMinutes
			// 
			this.cboMinutes.FormattingEnabled = true;
			this.cboMinutes.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
			this.cboMinutes.Location = new System.Drawing.Point(173, 93);
			this.cboMinutes.Name = "cboMinutes";
			this.cboMinutes.Size = new System.Drawing.Size(45, 21);
			this.cboMinutes.TabIndex = 10;
			// 
			// cboHours
			// 
			this.cboHours.FormattingEnabled = true;
			this.cboHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
			this.cboHours.Location = new System.Drawing.Point(68, 93);
			this.cboHours.Name = "cboHours";
			this.cboHours.Size = new System.Drawing.Size(45, 21);
			this.cboHours.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 21);
			this.label1.TabIndex = 12;
			this.label1.Text = "Hours:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(117, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 21);
			this.label2.TabIndex = 13;
			this.label2.Text = "Minutes:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmNewEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 237);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboHours);
			this.Controls.Add(this.cboMinutes);
			this.Controls.Add(this.clndrDate);
			this.Controls.Add(this.cboTask);
			this.Controls.Add(this.cboClient);
			this.Controls.Add(this.cboProject);
			this.Controls.Add(this.lblTask);
			this.Controls.Add(this.lblClient);
			this.Controls.Add(this.lblProject);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReset);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmNewEntry";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Timesheet Entry";
			this.Load += new System.EventHandler(this.frmNewEntry_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblProject;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.Label lblTask;
		private System.Windows.Forms.ComboBox cboProject;
		private System.Windows.Forms.ComboBox cboClient;
		private System.Windows.Forms.ComboBox cboTask;
		private System.Windows.Forms.MonthCalendar clndrDate;
		private System.Windows.Forms.ComboBox cboMinutes;
		private System.Windows.Forms.ComboBox cboHours;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}