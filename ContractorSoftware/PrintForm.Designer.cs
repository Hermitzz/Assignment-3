namespace ContractorSoftware
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
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
            this.JobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.JobShortDescriptionLabel = new System.Windows.Forms.Label();
            this.JobShortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.InvoiceNoLabel = new System.Windows.Forms.Label();
            this.InvoiceNoText = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ContractorNameLabel = new System.Windows.Forms.Label();
            this.ContractorNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientDetailsGroupBox.SuspendLayout();
            this.JobDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.ClientDetailsGroupBox.Location = new System.Drawing.Point(12, 25);
            this.ClientDetailsGroupBox.Name = "ClientDetailsGroupBox";
            this.ClientDetailsGroupBox.Size = new System.Drawing.Size(220, 208);
            this.ClientDetailsGroupBox.TabIndex = 55;
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
            this.ClientAddressTextBox.ReadOnly = true;
            this.ClientAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientAddressTextBox.TabIndex = 8;
            // 
            // ClientLandLineTextBox
            // 
            this.ClientLandLineTextBox.Location = new System.Drawing.Point(109, 87);
            this.ClientLandLineTextBox.Name = "ClientLandLineTextBox";
            this.ClientLandLineTextBox.ReadOnly = true;
            this.ClientLandLineTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientLandLineTextBox.TabIndex = 9;
            // 
            // ClientMobilePhoneTextBox
            // 
            this.ClientMobilePhoneTextBox.Location = new System.Drawing.Point(109, 117);
            this.ClientMobilePhoneTextBox.Name = "ClientMobilePhoneTextBox";
            this.ClientMobilePhoneTextBox.ReadOnly = true;
            this.ClientMobilePhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientMobilePhoneTextBox.TabIndex = 10;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(109, 173);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.ReadOnly = true;
            this.ClientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientEmailTextBox.TabIndex = 12;
            // 
            // ClientBusinessNameTextBox
            // 
            this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(109, 147);
            this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
            this.ClientBusinessNameTextBox.ReadOnly = true;
            this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientBusinessNameTextBox.TabIndex = 24;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(109, 27);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = true;
            this.ClientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientNameTextBox.TabIndex = 23;
            // 
            // JobDetailsGroupBox
            // 
            this.JobDetailsGroupBox.Controls.Add(this.ContractorNameTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.ContractorNameLabel);
            this.JobDetailsGroupBox.Controls.Add(this.AmountLabel);
            this.JobDetailsGroupBox.Controls.Add(this.AmountTextBox);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionLabel);
            this.JobDetailsGroupBox.Controls.Add(this.JobShortDescriptionTextBox);
            this.JobDetailsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JobDetailsGroupBox.Location = new System.Drawing.Point(10, 239);
            this.JobDetailsGroupBox.Name = "JobDetailsGroupBox";
            this.JobDetailsGroupBox.Size = new System.Drawing.Size(222, 200);
            this.JobDetailsGroupBox.TabIndex = 54;
            this.JobDetailsGroupBox.TabStop = false;
            this.JobDetailsGroupBox.Text = "Job Details";
            // 
            // JobShortDescriptionLabel
            // 
            this.JobShortDescriptionLabel.AutoSize = true;
            this.JobShortDescriptionLabel.Enabled = false;
            this.JobShortDescriptionLabel.Location = new System.Drawing.Point(10, 16);
            this.JobShortDescriptionLabel.Name = "JobShortDescriptionLabel";
            this.JobShortDescriptionLabel.Size = new System.Drawing.Size(88, 13);
            this.JobShortDescriptionLabel.TabIndex = 1;
            this.JobShortDescriptionLabel.Text = "Short Description";
            // 
            // JobShortDescriptionTextBox
            // 
            this.JobShortDescriptionTextBox.Location = new System.Drawing.Point(11, 32);
            this.JobShortDescriptionTextBox.Multiline = true;
            this.JobShortDescriptionTextBox.Name = "JobShortDescriptionTextBox";
            this.JobShortDescriptionTextBox.ReadOnly = true;
            this.JobShortDescriptionTextBox.Size = new System.Drawing.Size(200, 113);
            this.JobShortDescriptionTextBox.TabIndex = 23;
            // 
            // InvoiceNoLabel
            // 
            this.InvoiceNoLabel.AutoSize = true;
            this.InvoiceNoLabel.Location = new System.Drawing.Point(22, 9);
            this.InvoiceNoLabel.Name = "InvoiceNoLabel";
            this.InvoiceNoLabel.Size = new System.Drawing.Size(59, 13);
            this.InvoiceNoLabel.TabIndex = 56;
            this.InvoiceNoLabel.Text = "Invoice No";
            // 
            // InvoiceNoText
            // 
            this.InvoiceNoText.AutoSize = true;
            this.InvoiceNoText.Location = new System.Drawing.Point(87, 9);
            this.InvoiceNoText.Name = "InvoiceNoText";
            this.InvoiceNoText.Size = new System.Drawing.Size(0, 13);
            this.InvoiceNoText.TabIndex = 57;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintButton
            // 
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.Location = new System.Drawing.Point(205, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(27, 27);
            this.PrintButton.TabIndex = 58;
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Enabled = false;
            this.AmountLabel.Location = new System.Drawing.Point(12, 151);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(86, 13);
            this.AmountLabel.TabIndex = 34;
            this.AmountLabel.Text = "Amount Charged";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(111, 148);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 35;
            // 
            // ContractorNameLabel
            // 
            this.ContractorNameLabel.AutoSize = true;
            this.ContractorNameLabel.Enabled = false;
            this.ContractorNameLabel.Location = new System.Drawing.Point(12, 174);
            this.ContractorNameLabel.Name = "ContractorNameLabel";
            this.ContractorNameLabel.Size = new System.Drawing.Size(87, 13);
            this.ContractorNameLabel.TabIndex = 36;
            this.ContractorNameLabel.Text = "Contractor Name";
            // 
            // ContractorNameTextBox
            // 
            this.ContractorNameTextBox.Location = new System.Drawing.Point(111, 171);
            this.ContractorNameTextBox.Name = "ContractorNameTextBox";
            this.ContractorNameTextBox.ReadOnly = true;
            this.ContractorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ContractorNameTextBox.TabIndex = 37;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 471);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.InvoiceNoText);
            this.Controls.Add(this.InvoiceNoLabel);
            this.Controls.Add(this.ClientDetailsGroupBox);
            this.Controls.Add(this.JobDetailsGroupBox);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ClientDetailsGroupBox.ResumeLayout(false);
            this.ClientDetailsGroupBox.PerformLayout();
            this.JobDetailsGroupBox.ResumeLayout(false);
            this.JobDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientDetailsGroupBox;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.Label ClientAddressLabel;
        private System.Windows.Forms.Label ClientLandLineLabel;
        private System.Windows.Forms.Label ClientMobilePhoneLabel;
        private System.Windows.Forms.Label ClientBusinessNameLabel;
        private System.Windows.Forms.Label ClientEmailLabel;
        private System.Windows.Forms.GroupBox JobDetailsGroupBox;
        private System.Windows.Forms.Label JobShortDescriptionLabel;
        private System.Windows.Forms.Label InvoiceNoLabel;
        private System.Windows.Forms.Label InvoiceNoText;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button PrintButton;
        public System.Windows.Forms.TextBox ClientAddressTextBox;
        public System.Windows.Forms.TextBox ClientLandLineTextBox;
        public System.Windows.Forms.TextBox ClientMobilePhoneTextBox;
        public System.Windows.Forms.TextBox ClientEmailTextBox;
        public System.Windows.Forms.TextBox ClientBusinessNameTextBox;
        public System.Windows.Forms.TextBox ClientNameTextBox;
        public System.Windows.Forms.TextBox JobShortDescriptionTextBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox ContractorNameTextBox;
        private System.Windows.Forms.Label ContractorNameLabel;
    }
}