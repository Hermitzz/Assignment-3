namespace WindowsFormsApp2
{
	partial class AssignJobForm
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
			this.components = new System.ComponentModel.Container();
			this.AssignJobInfoLabel = new System.Windows.Forms.Label();
			this.JobDataGridView = new System.Windows.Forms.DataGridView();
			this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataBaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataBaseDataSet1 = new WindowsFormsApp2.DataBaseDataSet();
			this.ContractorLabel = new System.Windows.Forms.Label();
			this.ContractorComboBox = new System.Windows.Forms.ComboBox();
			this.contractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.AssignButton = new System.Windows.Forms.Button();
			this.contractorsTableAdapter1 = new WindowsFormsApp2.DataBaseDataSetTableAdapters.ContractorsTableAdapter();
			this.jobsTableAdapter1 = new WindowsFormsApp2.DataBaseDataSetTableAdapters.JobsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// AssignJobInfoLabel
			// 
			this.AssignJobInfoLabel.AutoSize = true;
			this.AssignJobInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssignJobInfoLabel.Location = new System.Drawing.Point(12, 9);
			this.AssignJobInfoLabel.Name = "AssignJobInfoLabel";
			this.AssignJobInfoLabel.Size = new System.Drawing.Size(523, 20);
			this.AssignJobInfoLabel.TabIndex = 0;
			this.AssignJobInfoLabel.Text = "Choose a job and enter the employeeID of the contractor to be assigned.";
			// 
			// JobDataGridView
			// 
			this.JobDataGridView.AllowUserToAddRows = false;
			this.JobDataGridView.AllowUserToDeleteRows = false;
			this.JobDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.JobDataGridView.Location = new System.Drawing.Point(13, 101);
			this.JobDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.JobDataGridView.Name = "JobDataGridView";
			this.JobDataGridView.ReadOnly = true;
			this.JobDataGridView.Size = new System.Drawing.Size(692, 205);
			this.JobDataGridView.TabIndex = 28;
			this.JobDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobDataGridView_CellClick);
			// 
			// jobsBindingSource
			// 
			this.jobsBindingSource.DataMember = "Jobs";
			this.jobsBindingSource.DataSource = this.dataBaseDataSet1BindingSource;
			// 
			// dataBaseDataSet1BindingSource
			// 
			this.dataBaseDataSet1BindingSource.DataSource = this.dataBaseDataSet1;
			this.dataBaseDataSet1BindingSource.Position = 0;
			// 
			// dataBaseDataSet1
			// 
			this.dataBaseDataSet1.DataSetName = "DataBaseDataSet";
			this.dataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ContractorLabel
			// 
			this.ContractorLabel.AutoSize = true;
			this.ContractorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContractorLabel.Location = new System.Drawing.Point(12, 44);
			this.ContractorLabel.Name = "ContractorLabel";
			this.ContractorLabel.Size = new System.Drawing.Size(92, 20);
			this.ContractorLabel.TabIndex = 29;
			this.ContractorLabel.Text = "Contractor: ";
			// 
			// ContractorComboBox
			// 
			this.ContractorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contractorsBindingSource, "ContractorId", true));
			this.ContractorComboBox.FormattingEnabled = true;
			this.ContractorComboBox.Location = new System.Drawing.Point(110, 44);
			this.ContractorComboBox.Name = "ContractorComboBox";
			this.ContractorComboBox.Size = new System.Drawing.Size(121, 21);
			this.ContractorComboBox.TabIndex = 30;
			// 
			// contractorsBindingSource
			// 
			this.contractorsBindingSource.DataMember = "Contractors";
			this.contractorsBindingSource.DataSource = this.dataBaseDataSet1BindingSource;
			// 
			// AssignButton
			// 
			this.AssignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssignButton.Location = new System.Drawing.Point(16, 332);
			this.AssignButton.Name = "AssignButton";
			this.AssignButton.Size = new System.Drawing.Size(137, 56);
			this.AssignButton.TabIndex = 31;
			this.AssignButton.Text = "Assign";
			this.AssignButton.UseVisualStyleBackColor = true;
			this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
			// 
			// contractorsTableAdapter1
			// 
			this.contractorsTableAdapter1.ClearBeforeFill = true;
			// 
			// jobsTableAdapter1
			// 
			this.jobsTableAdapter1.ClearBeforeFill = true;
			// 
			// AssignJobForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 408);
			this.Controls.Add(this.AssignButton);
			this.Controls.Add(this.ContractorComboBox);
			this.Controls.Add(this.ContractorLabel);
			this.Controls.Add(this.JobDataGridView);
			this.Controls.Add(this.AssignJobInfoLabel);
			this.Name = "AssignJobForm";
			this.Text = "Assign Job";
			this.Load += new System.EventHandler(this.AssignJobForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.JobDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AssignJobInfoLabel;
		private System.Windows.Forms.DataGridView JobDataGridView;
		private System.Windows.Forms.Label ContractorLabel;
		private System.Windows.Forms.ComboBox ContractorComboBox;
		private System.Windows.Forms.Button AssignButton;
		private System.Windows.Forms.BindingSource dataBaseDataSet1BindingSource;
		private DataBaseDataSet dataBaseDataSet1;
		private System.Windows.Forms.BindingSource contractorsBindingSource;
		private DataBaseDataSetTableAdapters.ContractorsTableAdapter contractorsTableAdapter1;
		private System.Windows.Forms.BindingSource jobsBindingSource;
		private DataBaseDataSetTableAdapters.JobsTableAdapter jobsTableAdapter1;
	}
}