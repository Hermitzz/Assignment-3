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
			this.AssignJobInfoLabel = new System.Windows.Forms.Label();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
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
			// DataGridView
			// 
			this.DataGridView.AllowUserToAddRows = false;
			this.DataGridView.AllowUserToDeleteRows = false;
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Location = new System.Drawing.Point(16, 34);
			this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.ReadOnly = true;
			this.DataGridView.Size = new System.Drawing.Size(396, 205);
			this.DataGridView.TabIndex = 28;
			// 
			// AssignJobForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 245);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.AssignJobInfoLabel);
			this.Name = "AssignJobForm";
			this.Text = "Assign Job";
			this.Load += new System.EventHandler(this.AssignJobForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AssignJobInfoLabel;
		private System.Windows.Forms.DataGridView DataGridView;
	}
}