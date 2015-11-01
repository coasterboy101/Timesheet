namespace Timesheet
{
	partial class frmClientDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientDetails));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.cboProject = new System.Windows.Forms.ComboBox();
			this.lblProject = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(297, 177);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(216, 177);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(12, 61);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(75, 20);
			this.lblDescription.TabIndex = 9;
			this.lblDescription.Text = "Description:";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(93, 61);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(279, 110);
			this.txtDescription.TabIndex = 8;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(12, 35);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(75, 20);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "Client Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(93, 35);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(279, 20);
			this.txtName.TabIndex = 6;
			// 
			// cboProject
			// 
			this.cboProject.FormattingEnabled = true;
			this.cboProject.Location = new System.Drawing.Point(93, 8);
			this.cboProject.Name = "cboProject";
			this.cboProject.Size = new System.Drawing.Size(279, 21);
			this.cboProject.TabIndex = 12;
			// 
			// lblProject
			// 
			this.lblProject.Location = new System.Drawing.Point(12, 9);
			this.lblProject.Name = "lblProject";
			this.lblProject.Size = new System.Drawing.Size(75, 20);
			this.lblProject.TabIndex = 13;
			this.lblProject.Text = "Project Name:";
			this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmClientDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 212);
			this.Controls.Add(this.lblProject);
			this.Controls.Add(this.cboProject);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClientDetails";
			this.Text = "Client Details";
			this.Load += new System.EventHandler(this.frmClientDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.ComboBox cboProject;
		private System.Windows.Forms.Label lblProject;
	}
}