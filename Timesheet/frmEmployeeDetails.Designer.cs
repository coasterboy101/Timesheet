﻿namespace Timesheet
{
	partial class frmEmployeeDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDetails));
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtSSN = new System.Windows.Forms.MaskedTextBox();
			this.txtZip = new System.Windows.Forms.MaskedTextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.cboEmployeeType = new System.Windows.Forms.ComboBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.cboState = new System.Windows.Forms.ComboBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.chkEmployed = new System.Windows.Forms.CheckBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblSSN = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblZip = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblEmployeeType = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFirstName
			// 
			this.lblFirstName.Location = new System.Drawing.Point(12, 12);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(65, 20);
			this.lblFirstName.TabIndex = 0;
			this.lblFirstName.Text = "First Name:";
			this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLastName
			// 
			this.lblLastName.Location = new System.Drawing.Point(239, 12);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(65, 20);
			this.lblLastName.TabIndex = 0;
			this.lblLastName.Text = "Last Name:";
			this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(83, 12);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(150, 20);
			this.txtFirstName.TabIndex = 1;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(310, 12);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(150, 20);
			this.txtLastName.TabIndex = 2;
			// 
			// txtSSN
			// 
			this.txtSSN.Location = new System.Drawing.Point(83, 38);
			this.txtSSN.Mask = "000-00-0000";
			this.txtSSN.Name = "txtSSN";
			this.txtSSN.Size = new System.Drawing.Size(100, 20);
			this.txtSSN.TabIndex = 3;
			this.txtSSN.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtZip
			// 
			this.txtZip.Location = new System.Drawing.Point(369, 89);
			this.txtZip.Mask = "00000";
			this.txtZip.Name = "txtZip";
			this.txtZip.Size = new System.Drawing.Size(91, 20);
			this.txtZip.TabIndex = 8;
			this.txtZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(83, 142);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(150, 20);
			this.txtPassword.TabIndex = 12;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(235, 117);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(100, 20);
			this.txtTitle.TabIndex = 10;
			// 
			// cboEmployeeType
			// 
			this.cboEmployeeType.FormattingEnabled = true;
			this.cboEmployeeType.Items.AddRange(new object[] {
            "Standard",
            "HR",
            "Manager",
            "Admin"});
			this.cboEmployeeType.Location = new System.Drawing.Point(335, 141);
			this.cboEmployeeType.Name = "cboEmployeeType";
			this.cboEmployeeType.Size = new System.Drawing.Size(125, 21);
			this.cboEmployeeType.TabIndex = 13;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(83, 91);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 6;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(83, 64);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(377, 20);
			this.txtAddress.TabIndex = 5;
			// 
			// cboState
			// 
			this.cboState.FormattingEnabled = true;
			this.cboState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
			this.cboState.Location = new System.Drawing.Point(242, 90);
			this.cboState.Name = "cboState";
			this.cboState.Size = new System.Drawing.Size(50, 21);
			this.cboState.TabIndex = 7;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(83, 117);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(100, 20);
			this.txtDepartment.TabIndex = 9;
			// 
			// chkEmployed
			// 
			this.chkEmployed.Location = new System.Drawing.Point(372, 117);
			this.chkEmployed.Name = "chkEmployed";
			this.chkEmployed.Size = new System.Drawing.Size(80, 20);
			this.chkEmployed.TabIndex = 11;
			this.chkEmployed.Text = "Employed?";
			this.chkEmployed.UseVisualStyleBackColor = true;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(235, 38);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(225, 20);
			this.txtEmail.TabIndex = 4;
			// 
			// lblSSN
			// 
			this.lblSSN.Location = new System.Drawing.Point(12, 38);
			this.lblSSN.Name = "lblSSN";
			this.lblSSN.Size = new System.Drawing.Size(65, 20);
			this.lblSSN.TabIndex = 0;
			this.lblSSN.Text = "SSN:";
			this.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblEmail
			// 
			this.lblEmail.Location = new System.Drawing.Point(189, 38);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(40, 20);
			this.lblEmail.TabIndex = 0;
			this.lblEmail.Text = "Email:";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblAddress
			// 
			this.lblAddress.Location = new System.Drawing.Point(12, 64);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(65, 20);
			this.lblAddress.TabIndex = 0;
			this.lblAddress.Text = "Address:";
			this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCity
			// 
			this.lblCity.Location = new System.Drawing.Point(12, 91);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(65, 20);
			this.lblCity.TabIndex = 0;
			this.lblCity.Text = "City:";
			this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblState
			// 
			this.lblState.Location = new System.Drawing.Point(189, 90);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(40, 20);
			this.lblState.TabIndex = 0;
			this.lblState.Text = "State:";
			this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblZip
			// 
			this.lblZip.Location = new System.Drawing.Point(298, 89);
			this.lblZip.Name = "lblZip";
			this.lblZip.Size = new System.Drawing.Size(65, 20);
			this.lblZip.TabIndex = 0;
			this.lblZip.Text = "ZIP Code:";
			this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDepartment
			// 
			this.lblDepartment.Location = new System.Drawing.Point(12, 117);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(65, 20);
			this.lblDepartment.TabIndex = 0;
			this.lblDepartment.Text = "Department:";
			this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTitle
			// 
			this.lblTitle.Location = new System.Drawing.Point(189, 117);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(40, 20);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Title:";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblEmployeeType
			// 
			this.lblEmployeeType.Location = new System.Drawing.Point(239, 142);
			this.lblEmployeeType.Name = "lblEmployeeType";
			this.lblEmployeeType.Size = new System.Drawing.Size(90, 20);
			this.lblEmployeeType.TabIndex = 0;
			this.lblEmployeeType.Text = "Employee Type:";
			this.lblEmployeeType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(12, 141);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(65, 20);
			this.lblPassword.TabIndex = 0;
			this.lblPassword.Text = "Password:";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(235, 177);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(316, 177);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(397, 177);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 16;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmEmployeeDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 212);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblEmployeeType);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblDepartment);
			this.Controls.Add(this.lblZip);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblSSN);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.chkEmployed);
			this.Controls.Add(this.txtDepartment);
			this.Controls.Add(this.cboState);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.cboEmployeeType);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtZip);
			this.Controls.Add(this.txtSSN);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEmployeeDetails";
			this.ShowInTaskbar = false;
			this.Text = "Employee Details";
			this.Load += new System.EventHandler(this.frmEmployeeDetails_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.MaskedTextBox txtSSN;
		private System.Windows.Forms.MaskedTextBox txtZip;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.ComboBox cboEmployeeType;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.ComboBox cboState;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.CheckBox chkEmployed;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblSSN;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblZip;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblEmployeeType;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnReset;
	}
}