namespace Timesheet
{
	partial class frmTaskDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskDetails));
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblProject = new System.Windows.Forms.Label();
			this.cboProject = new System.Windows.Forms.ComboBox();
			this.lblClient = new System.Windows.Forms.Label();
			this.cboClient = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(93, 62);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(279, 20);
			this.txtName.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(12, 62);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(75, 20);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Task Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(93, 88);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(279, 83);
			this.txtDescription.TabIndex = 2;
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(12, 88);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(75, 20);
			this.lblDescription.TabIndex = 3;
			this.lblDescription.Text = "Description:";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(216, 177);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(297, 177);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblProject
			// 
			this.lblProject.Location = new System.Drawing.Point(12, 9);
			this.lblProject.Name = "lblProject";
			this.lblProject.Size = new System.Drawing.Size(75, 20);
			this.lblProject.TabIndex = 15;
			this.lblProject.Text = "Project Name:";
			this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboProject
			// 
			this.cboProject.FormattingEnabled = true;
			this.cboProject.Location = new System.Drawing.Point(93, 8);
			this.cboProject.Name = "cboProject";
			this.cboProject.Size = new System.Drawing.Size(279, 21);
			this.cboProject.TabIndex = 14;
			this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
			// 
			// lblClient
			// 
			this.lblClient.Location = new System.Drawing.Point(12, 36);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new System.Drawing.Size(75, 20);
			this.lblClient.TabIndex = 17;
			this.lblClient.Text = "Client Name:";
			this.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cboClient
			// 
			this.cboClient.FormattingEnabled = true;
			this.cboClient.Location = new System.Drawing.Point(93, 35);
			this.cboClient.Name = "cboClient";
			this.cboClient.Size = new System.Drawing.Size(279, 21);
			this.cboClient.TabIndex = 16;
			// 
			// frmTaskDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 212);
			this.Controls.Add(this.lblClient);
			this.Controls.Add(this.cboClient);
			this.Controls.Add(this.lblProject);
			this.Controls.Add(this.cboProject);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmTaskDetails";
			this.Text = "Task Details";
			this.Load += new System.EventHandler(this.frmTaskDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblProject;
		private System.Windows.Forms.ComboBox cboProject;
		private System.Windows.Forms.Label lblClient;
		private System.Windows.Forms.ComboBox cboClient;
	}
}