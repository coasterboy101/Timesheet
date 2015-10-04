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
			((System.ComponentModel.ISupportInitialize)(this.dataGrdProjects)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(274, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 30);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete Project";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(143, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(125, 30);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit Project";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(125, 30);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add Project";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dataGrdProjects
			// 
			this.dataGrdProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrdProjects.Location = new System.Drawing.Point(12, 48);
			this.dataGrdProjects.Name = "dataGrdProjects";
			this.dataGrdProjects.Size = new System.Drawing.Size(560, 302);
			this.dataGrdProjects.TabIndex = 4;
			// 
			// cboTableSelection
			// 
			this.cboTableSelection.FormattingEnabled = true;
			this.cboTableSelection.Location = new System.Drawing.Point(422, 18);
			this.cboTableSelection.Name = "cboTableSelection";
			this.cboTableSelection.Size = new System.Drawing.Size(150, 21);
			this.cboTableSelection.TabIndex = 8;
			this.cboTableSelection.SelectionChangeCommitted += new System.EventHandler(this.cboTableSelection_SelectionChangeCommitted);
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
	}
}