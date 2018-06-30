namespace WindowsFormsApp2
{
	partial class Export
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
			this.FromDatePicker = new System.Windows.Forms.DateTimePicker();
			this.ToDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ContractorIDLabel = new System.Windows.Forms.Label();
			this.ContractorIDTextBox = new System.Windows.Forms.TextBox();
			this.ExportButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FromDatePicker
			// 
			this.FromDatePicker.Location = new System.Drawing.Point(91, 57);
			this.FromDatePicker.Name = "FromDatePicker";
			this.FromDatePicker.Size = new System.Drawing.Size(200, 20);
			this.FromDatePicker.TabIndex = 0;
			// 
			// ToDatePicker
			// 
			this.ToDatePicker.Location = new System.Drawing.Point(355, 57);
			this.ToDatePicker.Name = "ToDatePicker";
			this.ToDatePicker.Size = new System.Drawing.Size(200, 20);
			this.ToDatePicker.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(306, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "To:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "From: ";
			// 
			// ContractorIDLabel
			// 
			this.ContractorIDLabel.AutoSize = true;
			this.ContractorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ContractorIDLabel.Location = new System.Drawing.Point(12, 9);
			this.ContractorIDLabel.Name = "ContractorIDLabel";
			this.ContractorIDLabel.Size = new System.Drawing.Size(144, 25);
			this.ContractorIDLabel.TabIndex = 4;
			this.ContractorIDLabel.Text = "Contractor ID:";
			// 
			// ContractorIDTextBox
			// 
			this.ContractorIDTextBox.Location = new System.Drawing.Point(162, 12);
			this.ContractorIDTextBox.Name = "ContractorIDTextBox";
			this.ContractorIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.ContractorIDTextBox.TabIndex = 5;
			// 
			// ExportButton
			// 
			this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExportButton.Location = new System.Drawing.Point(249, 82);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(100, 39);
			this.ExportButton.TabIndex = 6;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
			// 
			// Export
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 136);
			this.Controls.Add(this.ExportButton);
			this.Controls.Add(this.ContractorIDTextBox);
			this.Controls.Add(this.ContractorIDLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ToDatePicker);
			this.Controls.Add(this.FromDatePicker);
			this.Name = "Export";
			this.Text = "Export";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker FromDatePicker;
		private System.Windows.Forms.DateTimePicker ToDatePicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ContractorIDLabel;
		private System.Windows.Forms.TextBox ContractorIDTextBox;
		private System.Windows.Forms.Button ExportButton;
	}
}