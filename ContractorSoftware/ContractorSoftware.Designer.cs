namespace ContractorSoftware
{
    partial class ContractorSoftware
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
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ClientDetailsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.ClientBusinessNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.JobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.JobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.JobDateAndTimeLabel = new System.Windows.Forms.Label();
            this.JobPriorityTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JobLocationTextBox = new System.Windows.Forms.TextBox();
            this.CompletionCheckBox = new System.Windows.Forms.CheckBox();
            this.JobShortDescriptionLabel = new System.Windows.Forms.Label();
            this.JobShortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ClientDetailsGroupBox.SuspendLayout();
            this.JobDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(418, 553);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(93, 42);
            this.PrintButton.TabIndex = 55;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(111, 11);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(93, 42);
            this.ExportButton.TabIndex = 54;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // ClientDetailsGroupBox
            // 
            this.ClientDetailsGroupBox.Controls.Add(this.ClientNameLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientAddressLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientLandLineLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientMobilePhoneLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientBusinessNameLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientEmailLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientAddressTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientLandLineTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientMobilePhoneTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientEmailTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientBusinessNameTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientNameTextBox);
            this.ClientDetailsGroupBox.Location = new System.Drawing.Point(291, 258);
            this.ClientDetailsGroupBox.Name = "ClientDetailsGroupBox";
            this.ClientDetailsGroupBox.Size = new System.Drawing.Size(220, 192);
            this.ClientDetailsGroupBox.TabIndex = 53;
            this.ClientDetailsGroupBox.TabStop = false;
            this.ClientDetailsGroupBox.Text = "Client Details";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(10, 28);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(29, 12);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Name";
            // 
            // ClientAddressLabel
            // 
            this.ClientAddressLabel.AutoSize = true;
            this.ClientAddressLabel.Location = new System.Drawing.Point(10, 55);
            this.ClientAddressLabel.Name = "ClientAddressLabel";
            this.ClientAddressLabel.Size = new System.Drawing.Size(47, 12);
            this.ClientAddressLabel.TabIndex = 2;
            this.ClientAddressLabel.Text = "Address";
            // 
            // ClientLandLineLabel
            // 
            this.ClientLandLineLabel.AutoSize = true;
            this.ClientLandLineLabel.Location = new System.Drawing.Point(10, 83);
            this.ClientLandLineLabel.Name = "ClientLandLineLabel";
            this.ClientLandLineLabel.Size = new System.Drawing.Size(59, 12);
            this.ClientLandLineLabel.TabIndex = 3;
            this.ClientLandLineLabel.Text = "Land Line";
            // 
            // ClientMobilePhoneLabel
            // 
            this.ClientMobilePhoneLabel.AutoSize = true;
            this.ClientMobilePhoneLabel.Location = new System.Drawing.Point(10, 111);
            this.ClientMobilePhoneLabel.Name = "ClientMobilePhoneLabel";
            this.ClientMobilePhoneLabel.Size = new System.Drawing.Size(77, 12);
            this.ClientMobilePhoneLabel.TabIndex = 4;
            this.ClientMobilePhoneLabel.Text = "Mobile Phone";
            // 
            // ClientBusinessNameLabel
            // 
            this.ClientBusinessNameLabel.AutoSize = true;
            this.ClientBusinessNameLabel.Location = new System.Drawing.Point(10, 138);
            this.ClientBusinessNameLabel.Name = "ClientBusinessNameLabel";
            this.ClientBusinessNameLabel.Size = new System.Drawing.Size(83, 12);
            this.ClientBusinessNameLabel.TabIndex = 5;
            this.ClientBusinessNameLabel.Text = "Business Name";
            // 
            // ClientEmailLabel
            // 
            this.ClientEmailLabel.AutoSize = true;
            this.ClientEmailLabel.Location = new System.Drawing.Point(10, 166);
            this.ClientEmailLabel.Name = "ClientEmailLabel";
            this.ClientEmailLabel.Size = new System.Drawing.Size(35, 12);
            this.ClientEmailLabel.TabIndex = 6;
            this.ClientEmailLabel.Text = "Email";
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.Location = new System.Drawing.Point(109, 53);
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.ReadOnly = true;
            this.ClientAddressTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientAddressTextBox.TabIndex = 8;
            // 
            // ClientLandLineTextBox
            // 
            this.ClientLandLineTextBox.Location = new System.Drawing.Point(109, 80);
            this.ClientLandLineTextBox.Name = "ClientLandLineTextBox";
            this.ClientLandLineTextBox.ReadOnly = true;
            this.ClientLandLineTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientLandLineTextBox.TabIndex = 9;
            // 
            // ClientMobilePhoneTextBox
            // 
            this.ClientMobilePhoneTextBox.Location = new System.Drawing.Point(109, 108);
            this.ClientMobilePhoneTextBox.Name = "ClientMobilePhoneTextBox";
            this.ClientMobilePhoneTextBox.ReadOnly = true;
            this.ClientMobilePhoneTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientMobilePhoneTextBox.TabIndex = 10;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(109, 160);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.ReadOnly = true;
            this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientEmailTextBox.TabIndex = 12;
            // 
            // ClientBusinessNameTextBox
            // 
            this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(109, 136);
            this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
            this.ClientBusinessNameTextBox.ReadOnly = true;
            this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientBusinessNameTextBox.TabIndex = 24;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(109, 25);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = true;
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.ClientNameTextBox.TabIndex = 23;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 553);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(93, 42);
            this.UpdateButton.TabIndex = 52;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // JobDetailsGroupBox
            // 
            this.JobDetailsGroupBox.Controls.Add(this.JobDateTimePicker);
            this.JobDetailsGroupBox.Controls.Add(this.JobDateAndTimeLabel);
            this.JobDetailsGroupBox.Controls.Add(this.JobPriorityTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.AmountLabel);
            this.JobDetailsGroupBox.Controls.Add(this.AmountTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.label2);
            this.JobDetailsGroupBox.Controls.Add(this.label4);
            this.JobDetailsGroupBox.Controls.Add(this.JobLocationTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.CompletionCheckBox);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionLabel);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionTextBox);
            this.JobDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JobDetailsGroupBox.Location = new System.Drawing.Point(12, 258);
            this.JobDetailsGroupBox.Name = "JobDetailsGroupBox";
            this.JobDetailsGroupBox.Size = new System.Drawing.Size(272, 280);
            this.JobDetailsGroupBox.TabIndex = 51;
            this.JobDetailsGroupBox.TabStop = false;
            this.JobDetailsGroupBox.Text = "Job Details";
            // 
            // JobDateTimePicker
            // 
            this.JobDateTimePicker.Enabled = false;
            this.JobDateTimePicker.Location = new System.Drawing.Point(79, 190);
            this.JobDateTimePicker.Name = "JobDateTimePicker";
            this.JobDateTimePicker.Size = new System.Drawing.Size(182, 21);
            this.JobDateTimePicker.TabIndex = 36;
            // 
            // JobDateAndTimeLabel
            // 
            this.JobDateAndTimeLabel.AutoSize = true;
            this.JobDateAndTimeLabel.Location = new System.Drawing.Point(15, 196);
            this.JobDateAndTimeLabel.Name = "JobDateAndTimeLabel";
            this.JobDateAndTimeLabel.Size = new System.Drawing.Size(59, 12);
            this.JobDateAndTimeLabel.TabIndex = 35;
            this.JobDateAndTimeLabel.Text = "Date/Time";
            // 
            // JobPriorityTextBox
            // 
            this.JobPriorityTextBox.Location = new System.Drawing.Point(159, 219);
            this.JobPriorityTextBox.Name = "JobPriorityTextBox";
            this.JobPriorityTextBox.ReadOnly = true;
            this.JobPriorityTextBox.Size = new System.Drawing.Size(100, 21);
            this.JobPriorityTextBox.TabIndex = 34;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(15, 250);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(89, 12);
            this.AmountLabel.TabIndex = 32;
            this.AmountLabel.Text = "Amount Charged";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(159, 247);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.AmountTextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "Priority";
            // 
            // JobLocationTextBox
            // 
            this.JobLocationTextBox.Location = new System.Drawing.Point(159, 163);
            this.JobLocationTextBox.Name = "JobLocationTextBox";
            this.JobLocationTextBox.ReadOnly = true;
            this.JobLocationTextBox.Size = new System.Drawing.Size(100, 21);
            this.JobLocationTextBox.TabIndex = 29;
            // 
            // CompletionCheckBox
            // 
            this.CompletionCheckBox.AutoSize = true;
            this.CompletionCheckBox.Location = new System.Drawing.Point(18, 18);
            this.CompletionCheckBox.Name = "CompletionCheckBox";
            this.CompletionCheckBox.Size = new System.Drawing.Size(78, 16);
            this.CompletionCheckBox.TabIndex = 25;
            this.CompletionCheckBox.Text = "Completed";
            this.CompletionCheckBox.UseVisualStyleBackColor = true;
            // 
            // JobShortDescriptionLabel
            // 
            this.JobShortDescriptionLabel.AutoSize = true;
            this.JobShortDescriptionLabel.Location = new System.Drawing.Point(15, 36);
            this.JobShortDescriptionLabel.Name = "JobShortDescriptionLabel";
            this.JobShortDescriptionLabel.Size = new System.Drawing.Size(107, 12);
            this.JobShortDescriptionLabel.TabIndex = 1;
            this.JobShortDescriptionLabel.Text = "Short Description";
            // 
            // JobShortDescriptionTextBox
            // 
            this.JobShortDescriptionTextBox.Location = new System.Drawing.Point(11, 53);
            this.JobShortDescriptionTextBox.Multiline = true;
            this.JobShortDescriptionTextBox.Name = "JobShortDescriptionTextBox";
            this.JobShortDescriptionTextBox.Size = new System.Drawing.Size(248, 98);
            this.JobShortDescriptionTextBox.TabIndex = 23;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 58);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(499, 194);
            this.DataGridView.TabIndex = 50;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(12, 11);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(93, 42);
            this.ImportButton.TabIndex = 49;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // ContractorSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 604);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ClientDetailsGroupBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.JobDetailsGroupBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ImportButton);
            this.MaximizeBox = false;
            this.Name = "ContractorSoftware";
            this.Text = "Contractor Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientDetailsGroupBox.ResumeLayout(false);
            this.ClientDetailsGroupBox.PerformLayout();
            this.JobDetailsGroupBox.ResumeLayout(false);
            this.JobDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox ClientDetailsGroupBox;
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
        private System.Windows.Forms.TextBox ClientBusinessNameTextBox;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox JobDetailsGroupBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JobLocationTextBox;
        private System.Windows.Forms.CheckBox CompletionCheckBox;
        private System.Windows.Forms.Label JobShortDescriptionLabel;
        private System.Windows.Forms.TextBox JobShortDescriptionTextBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox JobPriorityTextBox;
		private System.Windows.Forms.DateTimePicker JobDateTimePicker;
		private System.Windows.Forms.Label JobDateAndTimeLabel;
	}
}

