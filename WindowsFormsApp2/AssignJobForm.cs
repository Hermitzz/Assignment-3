using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DataBaseDataSetTableAdapters;

namespace WindowsFormsApp2
{
	public partial class AssignJobForm : Form
	{
		DataBaseDataSet dataBaseDataSet;
		ContractorsTableAdapter contractorsTableAdapter;
		JobsTableAdapter jobsTableAdapter;
		public AssignJobForm(DataBaseDataSet dataBaseDataSet, ContractorsTableAdapter contractorsTableAdapter, JobsTableAdapter jobsTableAdapter)
		{
			this.dataBaseDataSet = dataBaseDataSet;
			this.contractorsTableAdapter = contractorsTableAdapter;
			this.jobsTableAdapter = jobsTableAdapter;
			InitializeComponent();
		}

		private void AssignJobForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataBaseDataSet1.Jobs' table. You can move, or remove it, as needed.
			this.jobsTableAdapter1.Fill(this.dataBaseDataSet1.Jobs);
			// TODO: This line of code loads data into the 'dataBaseDataSet1.Contractors' table. You can move, or remove it, as needed.
			this.contractorsTableAdapter1.Fill(this.dataBaseDataSet1.Contractors);
			ComboBox.ObjectCollection NewItems = new ComboBox.ObjectCollection(ContractorComboBox);
			DataTable results = contractorsTableAdapter.SelectContractors();
			for (int Index = 0; Index < results.Rows.Count; Index++)
			{
				NewItems.Add(results.Rows[Index][0] + " " + results.Rows[Index][1]);
				
			}
			foreach (Object obj in NewItems)
			{
				ContractorComboBox.Items.Add(obj);
			}
		}

		private void selectContractorToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.contractorsTableAdapter1.SelectContractor(this.dataBaseDataSet1.Contractors);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void AssignButton_Click(object sender, EventArgs e)
		{

		}
	}
}
