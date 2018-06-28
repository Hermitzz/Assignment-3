namespace WindowsFormsApp2
{
    partial class HomeBaseForm
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
			this.ClientNameLabel = new System.Windows.Forms.Label();
			this.ClientAddressLabel = new System.Windows.Forms.Label();
			this.ClientLandLineLabel = new System.Windows.Forms.Label();
			this.ClientMobilePhoneLabel = new System.Windows.Forms.Label();
			this.ClientBusinessNameLabel = new System.Windows.Forms.Label();
			this.ClientEmailLabel = new System.Windows.Forms.Label();
			this.ClientAddressTextBox = new System.Windows.Forms.TextBox();
			this.ClientLandLineTextBox = new System.Windows.Forms.TextBox();
			this.ClientMobilePhoneTextBox = new System.Windows.Forms.TextBox();
			this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
			this.ClientNameTextBox = new System.Windows.Forms.TextBox();
			this.ClientBusinessNameTextBox = new System.Windows.Forms.TextBox();
			this.AddClientRadioButton = new System.Windows.Forms.RadioButton();
			this.AddContractorRadioButton = new System.Windows.Forms.RadioButton();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.ImportButton = new System.Windows.Forms.Button();
			this.ExportButton = new System.Windows.Forms.Button();
			this.AssignJobButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AddClientGroupBox = new System.Windows.Forms.GroupBox();
			this.AddContractorGroupBox = new System.Windows.Forms.GroupBox();
			this.ContractorNameLabel = new System.Windows.Forms.Label();
			this.ContractorAddressLabel = new System.Windows.Forms.Label();
			this.AddJobGroupBox = new System.Windows.Forms.GroupBox();
			this.JobPriorityComboBox = new System.Windows.Forms.ComboBox();
			this.JobShortDescriptionLabel = new System.Windows.Forms.Label();
			this.JobLocationLabel = new System.Windows.Forms.Label();
			this.JobDateAndTimeLabel = new System.Windows.Forms.Label();
			this.JobPriorityLabel = new System.Windows.Forms.Label();
			this.JobLocationTextBox = new System.Windows.Forms.TextBox();
			this.DateTimeTextBox = new System.Windows.Forms.TextBox();
			this.JobShortDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.ContractorLandLineLabel = new System.Windows.Forms.Label();
			this.ContractorMobilePhoneLabel = new System.Windows.Forms.Label();
			this.ContractorEmployeeIdNameLabel = new System.Windows.Forms.Label();
			this.ContractorEmailLabel = new System.Windows.Forms.Label();
			this.ContractorAddressTextBox = new System.Windows.Forms.TextBox();
			this.ContractorLandLineTextBox = new System.Windows.Forms.TextBox();
			this.ContractorMobilePhoneTextBox = new System.Windows.Forms.TextBox();
			this.ContractorEmailTextBox = new System.Windows.Forms.TextBox();
			this.ContractorEmployeeIdTextBox = new System.Windows.Forms.TextBox();
			this.ContractorNameTextBox = new System.Windows.Forms.TextBox();
			this.AddJobRadioButton = new System.Windows.Forms.RadioButton();
			this.dataBaseDataSet = new WindowsFormsApp2.DataBaseDataSet();
			this.dataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientsTableAdapter = new WindowsFormsApp2.DataBaseDataSetTableAdapters.ClientsTableAdapter();
			this.contractorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contractorsTableAdapter = new WindowsFormsApp2.DataBaseDataSetTableAdapters.ContractorsTableAdapter();
			this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.jobsTableAdapter = new WindowsFormsApp2.DataBaseDataSetTableAdapters.JobsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.AddClientGroupBox.SuspendLayout();
			this.AddContractorGroupBox.SuspendLayout();
			this.AddJobGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ClientNameLabel
			// 
			this.ClientNameLabel.AutoSize = true;
			this.ClientNameLabel.Enabled = false;
			this.ClientNameLabel.Location = new System.Drawing.Point(10, 27);
			this.ClientNameLabel.Name = "ClientNameLabel";
			this.ClientNameLabel.Size = new System.Drawing.Size(35, 13);
			this.ClientNameLabel.TabIndex = 1;
			this.ClientNameLabel.Text = "Name";
			// 
			// ClientAddressLabel
			// 
			this.ClientAddressLabel.AutoSize = true;
			this.ClientAddressLabel.Enabled = false;
			this.ClientAddressLabel.Location = new System.Drawing.Point(10, 69);
			this.ClientAddressLabel.Name = "ClientAddressLabel";
			this.ClientAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.ClientAddressLabel.TabIndex = 2;
			this.ClientAddressLabel.Text = "Address";
			// 
			// ClientLandLineLabel
			// 
			this.ClientLandLineLabel.AutoSize = true;
			this.ClientLandLineLabel.Enabled = false;
			this.ClientLandLineLabel.Location = new System.Drawing.Point(10, 109);
			this.ClientLandLineLabel.Name = "ClientLandLineLabel";
			this.ClientLandLineLabel.Size = new System.Drawing.Size(54, 13);
			this.ClientLandLineLabel.TabIndex = 3;
			this.ClientLandLineLabel.Text = "Land Line";
			// 
			// ClientMobilePhoneLabel
			// 
			this.ClientMobilePhoneLabel.AutoSize = true;
			this.ClientMobilePhoneLabel.Enabled = false;
			this.ClientMobilePhoneLabel.Location = new System.Drawing.Point(10, 158);
			this.ClientMobilePhoneLabel.Name = "ClientMobilePhoneLabel";
			this.ClientMobilePhoneLabel.Size = new System.Drawing.Size(72, 13);
			this.ClientMobilePhoneLabel.TabIndex = 4;
			this.ClientMobilePhoneLabel.Text = "Mobile Phone";
			// 
			// ClientBusinessNameLabel
			// 
			this.ClientBusinessNameLabel.AutoSize = true;
			this.ClientBusinessNameLabel.Enabled = false;
			this.ClientBusinessNameLabel.Location = new System.Drawing.Point(10, 210);
			this.ClientBusinessNameLabel.Name = "ClientBusinessNameLabel";
			this.ClientBusinessNameLabel.Size = new System.Drawing.Size(80, 13);
			this.ClientBusinessNameLabel.TabIndex = 5;
			this.ClientBusinessNameLabel.Text = "Business Name";
			// 
			// ClientEmailLabel
			// 
			this.ClientEmailLabel.AutoSize = true;
			this.ClientEmailLabel.Enabled = false;
			this.ClientEmailLabel.Location = new System.Drawing.Point(10, 255);
			this.ClientEmailLabel.Name = "ClientEmailLabel";
			this.ClientEmailLabel.Size = new System.Drawing.Size(32, 13);
			this.ClientEmailLabel.TabIndex = 6;
			this.ClientEmailLabel.Text = "Email";
			// 
			// ClientAddressTextBox
			// 
			this.ClientAddressTextBox.Location = new System.Drawing.Point(154, 69);
			this.ClientAddressTextBox.Name = "ClientAddressTextBox";
			this.ClientAddressTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientAddressTextBox.TabIndex = 8;
			// 
			// ClientLandLineTextBox
			// 
			this.ClientLandLineTextBox.Location = new System.Drawing.Point(154, 109);
			this.ClientLandLineTextBox.Name = "ClientLandLineTextBox";
			this.ClientLandLineTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientLandLineTextBox.TabIndex = 9;
			// 
			// ClientMobilePhoneTextBox
			// 
			this.ClientMobilePhoneTextBox.Location = new System.Drawing.Point(154, 158);
			this.ClientMobilePhoneTextBox.Name = "ClientMobilePhoneTextBox";
			this.ClientMobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientMobilePhoneTextBox.TabIndex = 10;
			// 
			// ClientEmailTextBox
			// 
			this.ClientEmailTextBox.Location = new System.Drawing.Point(154, 252);
			this.ClientEmailTextBox.Name = "ClientEmailTextBox";
			this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientEmailTextBox.TabIndex = 12;
			// 
			// ClientNameTextBox
			// 
			this.ClientNameTextBox.Location = new System.Drawing.Point(154, 27);
			this.ClientNameTextBox.Name = "ClientNameTextBox";
			this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientNameTextBox.TabIndex = 23;
			// 
			// ClientBusinessNameTextBox
			// 
			this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(154, 207);
			this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
			this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.ClientBusinessNameTextBox.TabIndex = 24;
			// 
			// AddClientRadioButton
			// 
			this.AddClientRadioButton.AutoSize = true;
			this.AddClientRadioButton.Location = new System.Drawing.Point(16, 12);
			this.AddClientRadioButton.Name = "AddClientRadioButton";
			this.AddClientRadioButton.Size = new System.Drawing.Size(73, 17);
			this.AddClientRadioButton.TabIndex = 25;
			this.AddClientRadioButton.TabStop = true;
			this.AddClientRadioButton.Text = "Add Client";
			this.AddClientRadioButton.UseVisualStyleBackColor = true;
			this.AddClientRadioButton.CheckedChanged += new System.EventHandler(this.AddClientRadioButton_CheckedChanged);
			// 
			// AddContractorRadioButton
			// 
			this.AddContractorRadioButton.AutoSize = true;
			this.AddContractorRadioButton.Location = new System.Drawing.Point(95, 12);
			this.AddContractorRadioButton.Name = "AddContractorRadioButton";
			this.AddContractorRadioButton.Size = new System.Drawing.Size(96, 17);
			this.AddContractorRadioButton.TabIndex = 26;
			this.AddContractorRadioButton.TabStop = true;
			this.AddContractorRadioButton.Text = "Add Contractor";
			this.AddContractorRadioButton.UseVisualStyleBackColor = true;
			this.AddContractorRadioButton.CheckedChanged += new System.EventHandler(this.AddContractorRadioButton_CheckedChanged);
			// 
			// DataGridView
			// 
			this.DataGridView.AllowUserToAddRows = false;
			this.DataGridView.AllowUserToDeleteRows = false;
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Location = new System.Drawing.Point(23, 325);
			this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.Size = new System.Drawing.Size(368, 205);
			this.DataGridView.TabIndex = 27;
			// 
			// ImportButton
			// 
			this.ImportButton.Location = new System.Drawing.Point(296, 237);
			this.ImportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ImportButton.Name = "ImportButton";
			this.ImportButton.Size = new System.Drawing.Size(112, 35);
			this.ImportButton.TabIndex = 28;
			this.ImportButton.Text = "Import";
			this.ImportButton.UseVisualStyleBackColor = true;
			// 
			// ExportButton
			// 
			this.ExportButton.Location = new System.Drawing.Point(296, 282);
			this.ExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(112, 35);
			this.ExportButton.TabIndex = 29;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			// 
			// AssignJobButton
			// 
			this.AssignJobButton.Location = new System.Drawing.Point(296, 193);
			this.AssignJobButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AssignJobButton.Name = "AssignJobButton";
			this.AssignJobButton.Size = new System.Drawing.Size(112, 35);
			this.AssignJobButton.TabIndex = 31;
			this.AssignJobButton.Text = "Assign Job";
			this.AssignJobButton.UseVisualStyleBackColor = true;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(30, 540);
			this.AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 35);
			this.AddButton.TabIndex = 32;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(150, 540);
			this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(112, 35);
			this.EditButton.TabIndex = 33;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(270, 540);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(112, 35);
			this.DeleteButton.TabIndex = 34;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// AddClientGroupBox
			// 
			this.AddClientGroupBox.Controls.Add(this.ClientNameLabel);
			this.AddClientGroupBox.Controls.Add(this.ClientAddressLabel);
			this.AddClientGroupBox.Controls.Add(this.AddContractorGroupBox);
			this.AddClientGroupBox.Controls.Add(this.ClientLandLineLabel);
			this.AddClientGroupBox.Controls.Add(this.ClientMobilePhoneLabel);
			this.AddClientGroupBox.Controls.Add(this.ClientBusinessNameLabel);
			this.AddClientGroupBox.Controls.Add(this.ClientEmailLabel);
			this.AddClientGroupBox.Controls.Add(this.ClientAddressTextBox);
			this.AddClientGroupBox.Controls.Add(this.ClientLandLineTextBox);
			this.AddClientGroupBox.Controls.Add(this.ClientMobilePhoneTextBox);
			this.AddClientGroupBox.Controls.Add(this.ClientEmailTextBox);
			this.AddClientGroupBox.Controls.Add(this.ClientBusinessNameTextBox);
			this.AddClientGroupBox.Controls.Add(this.ClientNameTextBox);
			this.AddClientGroupBox.Location = new System.Drawing.Point(12, 35);
			this.AddClientGroupBox.Name = "AddClientGroupBox";
			this.AddClientGroupBox.Size = new System.Drawing.Size(272, 282);
			this.AddClientGroupBox.TabIndex = 40;
			this.AddClientGroupBox.TabStop = false;
			this.AddClientGroupBox.Text = "Add Client";
			// 
			// AddContractorGroupBox
			// 
			this.AddContractorGroupBox.Controls.Add(this.ContractorNameLabel);
			this.AddContractorGroupBox.Controls.Add(this.ContractorAddressLabel);
			this.AddContractorGroupBox.Controls.Add(this.AddJobGroupBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorLandLineLabel);
			this.AddContractorGroupBox.Controls.Add(this.ContractorMobilePhoneLabel);
			this.AddContractorGroupBox.Controls.Add(this.ContractorEmployeeIdNameLabel);
			this.AddContractorGroupBox.Controls.Add(this.ContractorEmailLabel);
			this.AddContractorGroupBox.Controls.Add(this.ContractorAddressTextBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorLandLineTextBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorMobilePhoneTextBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorEmailTextBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorEmployeeIdTextBox);
			this.AddContractorGroupBox.Controls.Add(this.ContractorNameTextBox);
			this.AddContractorGroupBox.Location = new System.Drawing.Point(0, 0);
			this.AddContractorGroupBox.Name = "AddContractorGroupBox";
			this.AddContractorGroupBox.Size = new System.Drawing.Size(272, 282);
			this.AddContractorGroupBox.TabIndex = 41;
			this.AddContractorGroupBox.TabStop = false;
			this.AddContractorGroupBox.Text = "Add Contractor";
			// 
			// ContractorNameLabel
			// 
			this.ContractorNameLabel.AutoSize = true;
			this.ContractorNameLabel.Enabled = false;
			this.ContractorNameLabel.Location = new System.Drawing.Point(10, 27);
			this.ContractorNameLabel.Name = "ContractorNameLabel";
			this.ContractorNameLabel.Size = new System.Drawing.Size(35, 13);
			this.ContractorNameLabel.TabIndex = 1;
			this.ContractorNameLabel.Text = "Name";
			// 
			// ContractorAddressLabel
			// 
			this.ContractorAddressLabel.AutoSize = true;
			this.ContractorAddressLabel.Enabled = false;
			this.ContractorAddressLabel.Location = new System.Drawing.Point(10, 69);
			this.ContractorAddressLabel.Name = "ContractorAddressLabel";
			this.ContractorAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.ContractorAddressLabel.TabIndex = 2;
			this.ContractorAddressLabel.Text = "Address";
			// 
			// AddJobGroupBox
			// 
			this.AddJobGroupBox.Controls.Add(this.JobPriorityComboBox);
			this.AddJobGroupBox.Controls.Add(this.JobShortDescriptionLabel);
			this.AddJobGroupBox.Controls.Add(this.JobLocationLabel);
			this.AddJobGroupBox.Controls.Add(this.JobDateAndTimeLabel);
			this.AddJobGroupBox.Controls.Add(this.JobPriorityLabel);
			this.AddJobGroupBox.Controls.Add(this.JobLocationTextBox);
			this.AddJobGroupBox.Controls.Add(this.DateTimeTextBox);
			this.AddJobGroupBox.Controls.Add(this.JobShortDescriptionTextBox);
			this.AddJobGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AddJobGroupBox.Location = new System.Drawing.Point(0, 0);
			this.AddJobGroupBox.Name = "AddJobGroupBox";
			this.AddJobGroupBox.Size = new System.Drawing.Size(272, 282);
			this.AddJobGroupBox.TabIndex = 42;
			this.AddJobGroupBox.TabStop = false;
			this.AddJobGroupBox.Text = "Add Job";
			// 
			// JobPriorityComboBox
			// 
			this.JobPriorityComboBox.FormattingEnabled = true;
			this.JobPriorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.JobPriorityComboBox.Location = new System.Drawing.Point(154, 251);
			this.JobPriorityComboBox.Name = "JobPriorityComboBox";
			this.JobPriorityComboBox.Size = new System.Drawing.Size(100, 21);
			this.JobPriorityComboBox.TabIndex = 25;
			// 
			// JobShortDescriptionLabel
			// 
			this.JobShortDescriptionLabel.AutoSize = true;
			this.JobShortDescriptionLabel.Enabled = false;
			this.JobShortDescriptionLabel.Location = new System.Drawing.Point(10, 27);
			this.JobShortDescriptionLabel.Name = "JobShortDescriptionLabel";
			this.JobShortDescriptionLabel.Size = new System.Drawing.Size(88, 13);
			this.JobShortDescriptionLabel.TabIndex = 1;
			this.JobShortDescriptionLabel.Text = "Short Description";
			// 
			// JobLocationLabel
			// 
			this.JobLocationLabel.AutoSize = true;
			this.JobLocationLabel.Enabled = false;
			this.JobLocationLabel.Location = new System.Drawing.Point(10, 157);
			this.JobLocationLabel.Name = "JobLocationLabel";
			this.JobLocationLabel.Size = new System.Drawing.Size(48, 13);
			this.JobLocationLabel.TabIndex = 4;
			this.JobLocationLabel.Text = "Location";
			// 
			// JobDateAndTimeLabel
			// 
			this.JobDateAndTimeLabel.AutoSize = true;
			this.JobDateAndTimeLabel.Enabled = false;
			this.JobDateAndTimeLabel.Location = new System.Drawing.Point(10, 210);
			this.JobDateAndTimeLabel.Name = "JobDateAndTimeLabel";
			this.JobDateAndTimeLabel.Size = new System.Drawing.Size(78, 13);
			this.JobDateAndTimeLabel.TabIndex = 5;
			this.JobDateAndTimeLabel.Text = "Date And Time";
			// 
			// JobPriorityLabel
			// 
			this.JobPriorityLabel.AutoSize = true;
			this.JobPriorityLabel.Enabled = false;
			this.JobPriorityLabel.Location = new System.Drawing.Point(10, 255);
			this.JobPriorityLabel.Name = "JobPriorityLabel";
			this.JobPriorityLabel.Size = new System.Drawing.Size(38, 13);
			this.JobPriorityLabel.TabIndex = 6;
			this.JobPriorityLabel.Text = "Priority";
			// 
			// JobLocationTextBox
			// 
			this.JobLocationTextBox.Location = new System.Drawing.Point(154, 158);
			this.JobLocationTextBox.Name = "JobLocationTextBox";
			this.JobLocationTextBox.Size = new System.Drawing.Size(100, 20);
			this.JobLocationTextBox.TabIndex = 10;
			// 
			// DateTimeTextBox
			// 
			this.DateTimeTextBox.Location = new System.Drawing.Point(154, 207);
			this.DateTimeTextBox.Name = "DateTimeTextBox";
			this.DateTimeTextBox.Size = new System.Drawing.Size(100, 20);
			this.DateTimeTextBox.TabIndex = 24;
			// 
			// JobShortDescriptionTextBox
			// 
			this.JobShortDescriptionTextBox.Location = new System.Drawing.Point(6, 45);
			this.JobShortDescriptionTextBox.Multiline = true;
			this.JobShortDescriptionTextBox.Name = "JobShortDescriptionTextBox";
			this.JobShortDescriptionTextBox.Size = new System.Drawing.Size(248, 106);
			this.JobShortDescriptionTextBox.TabIndex = 23;
			// 
			// ContractorLandLineLabel
			// 
			this.ContractorLandLineLabel.AutoSize = true;
			this.ContractorLandLineLabel.Enabled = false;
			this.ContractorLandLineLabel.Location = new System.Drawing.Point(10, 109);
			this.ContractorLandLineLabel.Name = "ContractorLandLineLabel";
			this.ContractorLandLineLabel.Size = new System.Drawing.Size(54, 13);
			this.ContractorLandLineLabel.TabIndex = 3;
			this.ContractorLandLineLabel.Text = "Land Line";
			// 
			// ContractorMobilePhoneLabel
			// 
			this.ContractorMobilePhoneLabel.AutoSize = true;
			this.ContractorMobilePhoneLabel.Enabled = false;
			this.ContractorMobilePhoneLabel.Location = new System.Drawing.Point(10, 158);
			this.ContractorMobilePhoneLabel.Name = "ContractorMobilePhoneLabel";
			this.ContractorMobilePhoneLabel.Size = new System.Drawing.Size(72, 13);
			this.ContractorMobilePhoneLabel.TabIndex = 4;
			this.ContractorMobilePhoneLabel.Text = "Mobile Phone";
			// 
			// ContractorEmployeeIdNameLabel
			// 
			this.ContractorEmployeeIdNameLabel.AutoSize = true;
			this.ContractorEmployeeIdNameLabel.Enabled = false;
			this.ContractorEmployeeIdNameLabel.Location = new System.Drawing.Point(10, 210);
			this.ContractorEmployeeIdNameLabel.Name = "ContractorEmployeeIdNameLabel";
			this.ContractorEmployeeIdNameLabel.Size = new System.Drawing.Size(67, 13);
			this.ContractorEmployeeIdNameLabel.TabIndex = 5;
			this.ContractorEmployeeIdNameLabel.Text = "Employee ID";
			// 
			// ContractorEmailLabel
			// 
			this.ContractorEmailLabel.AutoSize = true;
			this.ContractorEmailLabel.Enabled = false;
			this.ContractorEmailLabel.Location = new System.Drawing.Point(10, 255);
			this.ContractorEmailLabel.Name = "ContractorEmailLabel";
			this.ContractorEmailLabel.Size = new System.Drawing.Size(32, 13);
			this.ContractorEmailLabel.TabIndex = 6;
			this.ContractorEmailLabel.Text = "Email";
			// 
			// ContractorAddressTextBox
			// 
			this.ContractorAddressTextBox.Location = new System.Drawing.Point(154, 69);
			this.ContractorAddressTextBox.Name = "ContractorAddressTextBox";
			this.ContractorAddressTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorAddressTextBox.TabIndex = 8;
			// 
			// ContractorLandLineTextBox
			// 
			this.ContractorLandLineTextBox.Location = new System.Drawing.Point(154, 109);
			this.ContractorLandLineTextBox.Name = "ContractorLandLineTextBox";
			this.ContractorLandLineTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorLandLineTextBox.TabIndex = 9;
			// 
			// ContractorMobilePhoneTextBox
			// 
			this.ContractorMobilePhoneTextBox.Location = new System.Drawing.Point(154, 158);
			this.ContractorMobilePhoneTextBox.Name = "ContractorMobilePhoneTextBox";
			this.ContractorMobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorMobilePhoneTextBox.TabIndex = 10;
			// 
			// ContractorEmailTextBox
			// 
			this.ContractorEmailTextBox.Location = new System.Drawing.Point(154, 252);
			this.ContractorEmailTextBox.Name = "ContractorEmailTextBox";
			this.ContractorEmailTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorEmailTextBox.TabIndex = 12;
			// 
			// ContractorEmployeeIdTextBox
			// 
			this.ContractorEmployeeIdTextBox.Location = new System.Drawing.Point(154, 207);
			this.ContractorEmployeeIdTextBox.Name = "ContractorEmployeeIdTextBox";
			this.ContractorEmployeeIdTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorEmployeeIdTextBox.TabIndex = 24;
			// 
			// ContractorNameTextBox
			// 
			this.ContractorNameTextBox.Location = new System.Drawing.Point(154, 27);
			this.ContractorNameTextBox.Name = "ContractorNameTextBox";
			this.ContractorNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorNameTextBox.TabIndex = 23;
			// 
			// AddJobRadioButton
			// 
			this.AddJobRadioButton.AutoSize = true;
			this.AddJobRadioButton.Location = new System.Drawing.Point(197, 12);
			this.AddJobRadioButton.Name = "AddJobRadioButton";
			this.AddJobRadioButton.Size = new System.Drawing.Size(64, 17);
			this.AddJobRadioButton.TabIndex = 43;
			this.AddJobRadioButton.TabStop = true;
			this.AddJobRadioButton.Text = "Add Job";
			this.AddJobRadioButton.UseVisualStyleBackColor = true;
			this.AddJobRadioButton.CheckedChanged += new System.EventHandler(this.AddJobRadioButton_CheckedChanged);
			// 
			// dataBaseDataSet
			// 
			this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
			this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataBaseDataSetBindingSource
			// 
			this.dataBaseDataSetBindingSource.DataSource = this.dataBaseDataSet;
			this.dataBaseDataSetBindingSource.Position = 0;
			// 
			// clientsBindingSource
			// 
			this.clientsBindingSource.DataMember = "Clients";
			this.clientsBindingSource.DataSource = this.dataBaseDataSetBindingSource;
			// 
			// clientsTableAdapter
			// 
			this.clientsTableAdapter.ClearBeforeFill = true;
			// 
			// contractorsBindingSource
			// 
			this.contractorsBindingSource.DataMember = "Contractors";
			this.contractorsBindingSource.DataSource = this.dataBaseDataSetBindingSource;
			// 
			// contractorsTableAdapter
			// 
			this.contractorsTableAdapter.ClearBeforeFill = true;
			// 
			// jobsBindingSource
			// 
			this.jobsBindingSource.DataMember = "Jobs";
			this.jobsBindingSource.DataSource = this.dataBaseDataSetBindingSource;
			// 
			// jobsTableAdapter
			// 
			this.jobsTableAdapter.ClearBeforeFill = true;
			// 
			// HomeBaseForm
			// 
			this.ClientSize = new System.Drawing.Size(419, 580);
			this.Controls.Add(this.AddJobRadioButton);
			this.Controls.Add(this.AddClientGroupBox);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.AssignJobButton);
			this.Controls.Add(this.ExportButton);
			this.Controls.Add(this.ImportButton);
			this.Controls.Add(this.AddContractorRadioButton);
			this.Controls.Add(this.AddClientRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "HomeBaseForm";
			this.Text = "Home Base";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.AddClientGroupBox.ResumeLayout(false);
			this.AddClientGroupBox.PerformLayout();
			this.AddContractorGroupBox.ResumeLayout(false);
			this.AddContractorGroupBox.PerformLayout();
			this.AddJobGroupBox.ResumeLayout(false);
			this.AddJobGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientAddressLabel;
        private System.Windows.Forms.Label ClientLandLineLabel;
        private System.Windows.Forms.Label ClientMobilePhoneLabel;
        private System.Windows.Forms.Label ClientBusinessNameLabel;
        private System.Windows.Forms.Label ClientEmailLabel;
        private System.Windows.Forms.TextBox ClientAddressTextBox;
        private System.Windows.Forms.TextBox ClientLandLineTextBox;
        private System.Windows.Forms.TextBox ClientMobilePhoneTextBox;
        private System.Windows.Forms.TextBox ClientEmailTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.TextBox ClientBusinessNameTextBox;
        private System.Windows.Forms.RadioButton AddClientRadioButton;
        private System.Windows.Forms.RadioButton AddContractorRadioButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button AssignJobButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox AddClientGroupBox;
        private System.Windows.Forms.GroupBox AddContractorGroupBox;
        private System.Windows.Forms.Label ContractorNameLabel;
        private System.Windows.Forms.Label ContractorAddressLabel;
        private System.Windows.Forms.Label ContractorLandLineLabel;
        private System.Windows.Forms.Label ContractorMobilePhoneLabel;
        private System.Windows.Forms.Label ContractorEmployeeIdNameLabel;
        private System.Windows.Forms.Label ContractorEmailLabel;
        private System.Windows.Forms.TextBox ContractorAddressTextBox;
        private System.Windows.Forms.TextBox ContractorLandLineTextBox;
        private System.Windows.Forms.TextBox ContractorMobilePhoneTextBox;
        private System.Windows.Forms.TextBox ContractorEmailTextBox;
        private System.Windows.Forms.TextBox ContractorEmployeeIdTextBox;
        private System.Windows.Forms.TextBox ContractorNameTextBox;
        private System.Windows.Forms.GroupBox AddJobGroupBox;
        private System.Windows.Forms.Label JobShortDescriptionLabel;
        private System.Windows.Forms.Label JobLocationLabel;
        private System.Windows.Forms.Label JobDateAndTimeLabel;
        private System.Windows.Forms.Label JobPriorityLabel;
        private System.Windows.Forms.TextBox JobLocationTextBox;
        private System.Windows.Forms.TextBox DateTimeTextBox;
        private System.Windows.Forms.TextBox JobShortDescriptionTextBox;
        private System.Windows.Forms.RadioButton AddJobRadioButton;
        private System.Windows.Forms.ComboBox JobPriorityComboBox;
		private System.Windows.Forms.BindingSource dataBaseDataSetBindingSource;
		private DataBaseDataSet dataBaseDataSet;
		private System.Windows.Forms.BindingSource clientsBindingSource;
		private DataBaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
		private System.Windows.Forms.BindingSource contractorsBindingSource;
		private DataBaseDataSetTableAdapters.ContractorsTableAdapter contractorsTableAdapter;
		private System.Windows.Forms.BindingSource jobsBindingSource;
		private DataBaseDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
	}
}

