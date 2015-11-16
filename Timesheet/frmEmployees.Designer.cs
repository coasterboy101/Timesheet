namespace Timesheet
{
	partial class frmEmployees
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
			this.dataGrdEmployees = new System.Windows.Forms.DataGridView();
			this.gcEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcSSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcStreetAddres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcState = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcEmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gcStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.gcTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrdEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrdEmployees
			// 
			this.dataGrdEmployees.AllowUserToAddRows = false;
			this.dataGrdEmployees.AllowUserToDeleteRows = false;
			this.dataGrdEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGrdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcEmpId,
            this.gcFirstName,
            this.gcLastName,
            this.gcSSN,
            this.gcEmail,
            this.gcStreetAddres,
            this.gcCity,
            this.gcState,
            this.gcZip,
            this.gcPassword,
            this.gcEmployeeType,
            this.gcDepartment,
            this.gcStatus,
            this.gcTitle});
			this.dataGrdEmployees.Location = new System.Drawing.Point(12, 43);
			this.dataGrdEmployees.Name = "dataGrdEmployees";
			this.dataGrdEmployees.ReadOnly = true;
			this.dataGrdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrdEmployees.Size = new System.Drawing.Size(760, 407);
			this.dataGrdEmployees.TabIndex = 0;
			// 
			// gcEmpId
			// 
			this.gcEmpId.DataPropertyName = "EmpId";
			this.gcEmpId.HeaderText = "Employee ID";
			this.gcEmpId.MinimumWidth = 75;
			this.gcEmpId.Name = "gcEmpId";
			this.gcEmpId.ReadOnly = true;
			this.gcEmpId.Width = 75;
			// 
			// gcFirstName
			// 
			this.gcFirstName.DataPropertyName = "FirstName";
			this.gcFirstName.HeaderText = "First Name";
			this.gcFirstName.MinimumWidth = 100;
			this.gcFirstName.Name = "gcFirstName";
			this.gcFirstName.ReadOnly = true;
			// 
			// gcLastName
			// 
			this.gcLastName.DataPropertyName = "LastName";
			this.gcLastName.HeaderText = "Last Name";
			this.gcLastName.MinimumWidth = 100;
			this.gcLastName.Name = "gcLastName";
			this.gcLastName.ReadOnly = true;
			// 
			// gcSSN
			// 
			this.gcSSN.DataPropertyName = "SSN";
			this.gcSSN.HeaderText = "SSN";
			this.gcSSN.MinimumWidth = 100;
			this.gcSSN.Name = "gcSSN";
			this.gcSSN.ReadOnly = true;
			// 
			// gcEmail
			// 
			this.gcEmail.DataPropertyName = "Email";
			this.gcEmail.HeaderText = "Email Address";
			this.gcEmail.MinimumWidth = 100;
			this.gcEmail.Name = "gcEmail";
			this.gcEmail.ReadOnly = true;
			// 
			// gcStreetAddres
			// 
			this.gcStreetAddres.DataPropertyName = "StreetAddress";
			this.gcStreetAddres.HeaderText = "Street Address";
			this.gcStreetAddres.MinimumWidth = 125;
			this.gcStreetAddres.Name = "gcStreetAddres";
			this.gcStreetAddres.ReadOnly = true;
			this.gcStreetAddres.Width = 125;
			// 
			// gcCity
			// 
			this.gcCity.DataPropertyName = "City";
			this.gcCity.HeaderText = "City";
			this.gcCity.MinimumWidth = 75;
			this.gcCity.Name = "gcCity";
			this.gcCity.ReadOnly = true;
			this.gcCity.Width = 75;
			// 
			// gcState
			// 
			this.gcState.DataPropertyName = "State";
			this.gcState.HeaderText = "State";
			this.gcState.MinimumWidth = 75;
			this.gcState.Name = "gcState";
			this.gcState.ReadOnly = true;
			this.gcState.Width = 75;
			// 
			// gcZip
			// 
			this.gcZip.DataPropertyName = "Zip";
			this.gcZip.HeaderText = "Zip Code";
			this.gcZip.MinimumWidth = 100;
			this.gcZip.Name = "gcZip";
			this.gcZip.ReadOnly = true;
			// 
			// gcPassword
			// 
			this.gcPassword.DataPropertyName = "Password";
			this.gcPassword.HeaderText = "Password";
			this.gcPassword.MinimumWidth = 100;
			this.gcPassword.Name = "gcPassword";
			this.gcPassword.ReadOnly = true;
			// 
			// gcEmployeeType
			// 
			this.gcEmployeeType.DataPropertyName = "EmployeeType";
			this.gcEmployeeType.HeaderText = "Employee Type";
			this.gcEmployeeType.MinimumWidth = 125;
			this.gcEmployeeType.Name = "gcEmployeeType";
			this.gcEmployeeType.ReadOnly = true;
			this.gcEmployeeType.Width = 125;
			// 
			// gcDepartment
			// 
			this.gcDepartment.DataPropertyName = "Department";
			this.gcDepartment.HeaderText = "Department";
			this.gcDepartment.MinimumWidth = 100;
			this.gcDepartment.Name = "gcDepartment";
			this.gcDepartment.ReadOnly = true;
			// 
			// gcStatus
			// 
			this.gcStatus.DataPropertyName = "Status";
			this.gcStatus.HeaderText = "Status";
			this.gcStatus.MinimumWidth = 75;
			this.gcStatus.Name = "gcStatus";
			this.gcStatus.ReadOnly = true;
			this.gcStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.gcStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.gcStatus.Width = 75;
			// 
			// gcTitle
			// 
			this.gcTitle.DataPropertyName = "Title";
			this.gcTitle.HeaderText = "Title";
			this.gcTitle.MinimumWidth = 100;
			this.gcTitle.Name = "gcTitle";
			this.gcTitle.ReadOnly = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(125, 25);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add Employee";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(143, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(125, 25);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Edit Employee";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(274, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 25);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete Employee";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// frmEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 462);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGrdEmployees);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEmployees";
			this.ShowInTaskbar = false;
			this.Text = "Employees";
			this.Load += new System.EventHandler(this.frmEmployees_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrdEmployees)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcEmpId;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcSSN;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcStreetAddres;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcState;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcZip;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcPassword;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcEmployeeType;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcDepartment;
		private System.Windows.Forms.DataGridViewCheckBoxColumn gcStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn gcTitle;
		private System.Windows.Forms.DataGridView dataGrdEmployees;
	}
}