namespace Timesheet
{
	partial class frmSelectEmployee
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
			this.cboEmployees = new System.Windows.Forms.ComboBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cboEmployees
			// 
			this.cboEmployees.FormattingEnabled = true;
			this.cboEmployees.Location = new System.Drawing.Point(12, 12);
			this.cboEmployees.Name = "cboEmployees";
			this.cboEmployees.Size = new System.Drawing.Size(260, 21);
			this.cboEmployees.TabIndex = 0;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(197, 39);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 1;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(116, 39);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmSelectEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 67);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.cboEmployees);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmSelectEmployee";
			this.ShowIcon = false;
			this.Text = "Select Employee";
			this.Load += new System.EventHandler(this.frmSelectEmployee_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cboEmployees;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnCancel;
	}
}