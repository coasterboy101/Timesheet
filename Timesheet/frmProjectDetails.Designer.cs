namespace Timesheet
{
	partial class frmProjectDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDetails));
			this.lstEmployees = new System.Windows.Forms.ListBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblEmployees = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstEmployees
			// 
			this.lstEmployees.FormattingEnabled = true;
			this.lstEmployees.IntegralHeight = false;
			this.lstEmployees.Location = new System.Drawing.Point(349, 38);
			this.lstEmployees.Name = "lstEmployees";
			this.lstEmployees.Size = new System.Drawing.Size(120, 100);
			this.lstEmployees.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(397, 177);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(316, 177);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.Location = new System.Drawing.Point(12, 38);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(75, 20);
			this.lblDescription.TabIndex = 9;
			this.lblDescription.Text = "Description:";
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(93, 38);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(250, 100);
			this.txtDescription.TabIndex = 8;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(12, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(75, 20);
			this.lblName.TabIndex = 7;
			this.lblName.Text = "Project Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(93, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(250, 20);
			this.txtName.TabIndex = 6;
			// 
			// lblEmployees
			// 
			this.lblEmployees.Location = new System.Drawing.Point(346, 12);
			this.lblEmployees.Name = "lblEmployees";
			this.lblEmployees.Size = new System.Drawing.Size(120, 20);
			this.lblEmployees.TabIndex = 12;
			this.lblEmployees.Text = "Assigned Employees:";
			this.lblEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 177);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(110, 23);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add Employee";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(128, 177);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(110, 23);
			this.btnRemove.TabIndex = 14;
			this.btnRemove.Text = "Remove Employee";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// frmProjectDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 212);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lblEmployees);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lstEmployees);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProjectDetails";
			this.Text = "Project Details";
			this.Load += new System.EventHandler(this.frmProjectDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstEmployees;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblEmployees;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
	}
}