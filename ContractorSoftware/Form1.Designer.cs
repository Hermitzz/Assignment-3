namespace ContractorSoftware
{
    partial class Form1
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.PrintButton.Location = new System.Drawing.Point(418, 599);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(93, 45);
            this.PrintButton.TabIndex = 55;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(111, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(93, 45);
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
            this.ClientDetailsGroupBox.Location = new System.Drawing.Point(291, 279);
            this.ClientDetailsGroupBox.Name = "ClientDetailsGroupBox";
            this.ClientDetailsGroupBox.Size = new System.Drawing.Size(220, 208);
            this.ClientDetailsGroupBox.TabIndex = 53;
            this.ClientDetailsGroupBox.TabStop = false;
            this.ClientDetailsGroupBox.Text = "Client Details";
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Enabled = false;
            this.ClientNameLabel.Location = new System.Drawing.Point(10, 30);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ClientNameLabel.TabIndex = 1;
            this.ClientNameLabel.Text = "Name";
            // 
            // ClientAddressLabel
            // 
            this.ClientAddressLabel.AutoSize = true;
            this.ClientAddressLabel.Enabled = false;
            this.ClientAddressLabel.Location = new System.Drawing.Point(10, 60);
            this.ClientAddressLabel.Name = "ClientAddressLabel";
            this.ClientAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.ClientAddressLabel.TabIndex = 2;
            this.ClientAddressLabel.Text = "Address";
            // 
            // ClientLandLineLabel
            // 
            this.ClientLandLineLabel.AutoSize = true;
            this.ClientLandLineLabel.Enabled = false;
            this.ClientLandLineLabel.Location = new System.Drawing.Point(10, 90);
            this.ClientLandLineLabel.Name = "ClientLandLineLabel";
            this.ClientLandLineLabel.Size = new System.Drawing.Size(54, 13);
            this.ClientLandLineLabel.TabIndex = 3;
            this.ClientLandLineLabel.Text = "Land Line";
            // 
            // ClientMobilePhoneLabel
            // 
            this.ClientMobilePhoneLabel.AutoSize = true;
            this.ClientMobilePhoneLabel.Enabled = false;
            this.ClientMobilePhoneLabel.Location = new System.Drawing.Point(10, 120);
            this.ClientMobilePhoneLabel.Name = "ClientMobilePhoneLabel";
            this.ClientMobilePhoneLabel.Size = new System.Drawing.Size(72, 13);
            this.ClientMobilePhoneLabel.TabIndex = 4;
            this.ClientMobilePhoneLabel.Text = "Mobile Phone";
            // 
            // ClientBusinessNameLabel
            // 
            this.ClientBusinessNameLabel.AutoSize = true;
            this.ClientBusinessNameLabel.Enabled = false;
            this.ClientBusinessNameLabel.Location = new System.Drawing.Point(10, 150);
            this.ClientBusinessNameLabel.Name = "ClientBusinessNameLabel";
            this.ClientBusinessNameLabel.Size = new System.Drawing.Size(80, 13);
            this.ClientBusinessNameLabel.TabIndex = 5;
            this.ClientBusinessNameLabel.Text = "Business Name";
            // 
            // ClientEmailLabel
            // 
            this.ClientEmailLabel.AutoSize = true;
            this.ClientEmailLabel.Enabled = false;
            this.ClientEmailLabel.Location = new System.Drawing.Point(10, 180);
            this.ClientEmailLabel.Name = "ClientEmailLabel";
            this.ClientEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.ClientEmailLabel.TabIndex = 6;
            this.ClientEmailLabel.Text = "Email";
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.Location = new System.Drawing.Point(109, 57);
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientAddressTextBox.TabIndex = 8;
            // 
            // ClientLandLineTextBox
            // 
            this.ClientLandLineTextBox.Location = new System.Drawing.Point(109, 87);
            this.ClientLandLineTextBox.Name = "ClientLandLineTextBox";
            this.ClientLandLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientLandLineTextBox.TabIndex = 9;
            // 
            // ClientMobilePhoneTextBox
            // 
            this.ClientMobilePhoneTextBox.Location = new System.Drawing.Point(109, 117);
            this.ClientMobilePhoneTextBox.Name = "ClientMobilePhoneTextBox";
            this.ClientMobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientMobilePhoneTextBox.TabIndex = 10;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(109, 173);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientEmailTextBox.TabIndex = 12;
            // 
            // ClientBusinessNameTextBox
            // 
            this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(109, 147);
            this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
            this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientBusinessNameTextBox.TabIndex = 24;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(109, 27);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNameTextBox.TabIndex = 23;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 599);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(93, 45);
            this.UpdateButton.TabIndex = 52;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // JobDetailsGroupBox
            // 
            this.JobDetailsGroupBox.Controls.Add(this.AmountLabel);
            this.JobDetailsGroupBox.Controls.Add(this.AmountTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.comboBox1);
            this.JobDetailsGroupBox.Controls.Add(this.label2);
            this.JobDetailsGroupBox.Controls.Add(this.label3);
            this.JobDetailsGroupBox.Controls.Add(this.label4);
            this.JobDetailsGroupBox.Controls.Add(this.textBox3);
            this.JobDetailsGroupBox.Controls.Add(this.textBox4);
            this.JobDetailsGroupBox.Controls.Add(this.CompletionCheckBox);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionLabel);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionTextBox);
            this.JobDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JobDetailsGroupBox.Location = new System.Drawing.Point(12, 279);
            this.JobDetailsGroupBox.Name = "JobDetailsGroupBox";
            this.JobDetailsGroupBox.Size = new System.Drawing.Size(272, 303);
            this.JobDetailsGroupBox.TabIndex = 51;
            this.JobDetailsGroupBox.TabStop = false;
            this.JobDetailsGroupBox.Text = "Job Details";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Enabled = false;
            this.AmountLabel.Location = new System.Drawing.Point(15, 271);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(86, 13);
            this.AmountLabel.TabIndex = 32;
            this.AmountLabel.Text = "Amount Charged";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(159, 268);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(159, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(15, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(15, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date And Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(15, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Priority";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 206);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            // 
            // CompletionCheckBox
            // 
            this.CompletionCheckBox.AutoSize = true;
            this.CompletionCheckBox.Location = new System.Drawing.Point(18, 19);
            this.CompletionCheckBox.Name = "CompletionCheckBox";
            this.CompletionCheckBox.Size = new System.Drawing.Size(76, 17);
            this.CompletionCheckBox.TabIndex = 25;
            this.CompletionCheckBox.Text = "Completed";
            this.CompletionCheckBox.UseVisualStyleBackColor = true;
            // 
            // JobShortDescriptionLabel
            // 
            this.JobShortDescriptionLabel.AutoSize = true;
            this.JobShortDescriptionLabel.Enabled = false;
            this.JobShortDescriptionLabel.Location = new System.Drawing.Point(15, 39);
            this.JobShortDescriptionLabel.Name = "JobShortDescriptionLabel";
            this.JobShortDescriptionLabel.Size = new System.Drawing.Size(88, 13);
            this.JobShortDescriptionLabel.TabIndex = 1;
            this.JobShortDescriptionLabel.Text = "Short Description";
            // 
            // JobShortDescriptionTextBox
            // 
            this.JobShortDescriptionTextBox.Location = new System.Drawing.Point(11, 57);
            this.JobShortDescriptionTextBox.Multiline = true;
            this.JobShortDescriptionTextBox.Name = "JobShortDescriptionTextBox";
            this.JobShortDescriptionTextBox.Size = new System.Drawing.Size(248, 106);
            this.JobShortDescriptionTextBox.TabIndex = 23;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 63);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(499, 210);
            this.DataGridView.TabIndex = 50;
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(12, 12);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(93, 45);
            this.ImportButton.TabIndex = 49;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 654);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ClientDetailsGroupBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.JobDetailsGroupBox);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ImportButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox CompletionCheckBox;
        private System.Windows.Forms.Label JobShortDescriptionLabel;
        private System.Windows.Forms.TextBox JobShortDescriptionTextBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ImportButton;
    }
}

