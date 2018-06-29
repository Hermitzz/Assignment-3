using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomeBaseForm : Form
    {
        public HomeBaseForm()
        {
            InitializeComponent();
        }

		private void Form1_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataBaseDataSet.Jobs' table. You can move, or remove it, as needed.
			this.jobsTableAdapter.Fill(this.dataBaseDataSet.Jobs);
			// TODO: This line of code loads data into the 'dataBaseDataSet.Contractors' table. You can move, or remove it, as needed.
			this.contractorsTableAdapter.Fill(this.dataBaseDataSet.Contractors);
			// TODO: This line of code loads data into the 'dataBaseDataSet.Clients' table. You can move, or remove it, as needed.
			this.clientsTableAdapter.Fill(this.dataBaseDataSet.Clients);
			AddClientGroupBox.Visible = false;
			AddContractorGroupBox.Visible = false;
			AddContractorGroupBox.Parent = AddClientGroupBox.Parent;
			AddContractorGroupBox.Location = AddClientGroupBox.Location;
			AddJobGroupBox.Visible = false;
			AddJobGroupBox.Parent = AddClientGroupBox.Parent;
			AddJobGroupBox.Location = AddClientGroupBox.Location;
			JobPriorityComboBox.SelectedIndex = 0;
		}

		// makes the selected groupbox visible and the others invisible
		private void AddClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (AddClientRadioButton.Checked == true)
            {
                AddClientGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
                AddJobGroupBox.Visible = false;
                AddContractorGroupBox.Visible = false;

				DataGridView.DataSource = dataBaseDataSet.Clients;
            }
        }

        private void AddContractorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddContractorRadioButton.Checked == true)
            {
                AddContractorGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
				AddJobGroupBox.Visible = false;
                AddClientGroupBox.Visible = false;

				DataGridView.DataSource = dataBaseDataSet.Contractors;
			}
        }

        private void AddJobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AddJobRadioButton.Checked == true)
            {
                AddJobGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
				AddClientGroupBox.Visible = false;
                AddContractorGroupBox.Visible = false;

				DataGridView.DataSource = dataBaseDataSet.Jobs;
			}
        }

		// checks which option is currently selected and adds data from the fields to the database.
		private void AddButton_Click(object sender, EventArgs e)
        {
			if (AddClientRadioButton.Checked == true)
			{
				DataBaseDataSet.ClientsRow NewClientsRow = dataBaseDataSet.Clients.NewClientsRow();
				NewClientsRow.name = ClientNameTextBox.Text.ToString();
				NewClientsRow.address = ClientAddressTextBox.Text.ToString();
				NewClientsRow.landLine = ClientLandLineTextBox.Text.ToString();
				NewClientsRow.mobilePhone = ClientMobilePhoneTextBox.Text.ToString();
				NewClientsRow.businessName = ClientBusinessNameTextBox.Text.ToString();
				NewClientsRow.email = ClientEmailTextBox.Text.ToString();
				this.dataBaseDataSet.Clients.Rows.Add(NewClientsRow);
				this.clientsTableAdapter.Update(this.dataBaseDataSet.Clients);
			}
			else if (AddContractorRadioButton.Checked == true)
			{
				DataBaseDataSet.ContractorsRow NewContractorRow = dataBaseDataSet.Contractors.NewContractorsRow();
				NewContractorRow.name = ContractorNameTextBox.Text.ToString();
				NewContractorRow.address = ContractorAddressTextBox.Text.ToString();
				NewContractorRow.landLine = ContractorLandLineTextBox.Text.ToString();
				NewContractorRow.mobilePhone = ContractorMobilePhoneTextBox.Text.ToString();
				NewContractorRow.employeeId = ContractorEmployeeIdTextBox.Text.ToString();
				NewContractorRow.email = ContractorEmailTextBox.Text.ToString();
				this.dataBaseDataSet.Contractors.Rows.Add(NewContractorRow);
				this.contractorsTableAdapter.Update(this.dataBaseDataSet.Contractors);
			}
			else if (AddJobRadioButton.Checked == true)
			{
				DataBaseDataSet.JobsRow NewJobRow = dataBaseDataSet.Jobs.NewJobsRow();
				NewJobRow.shortDescription = JobShortDescriptionTextBox.Text.ToString();
				NewJobRow.location = JobLocationTextBox.Text.ToString();
				NewJobRow.dateAndTime = JobDateTimeTextBox.Text.ToString();
				NewJobRow.priority = Int32.Parse(JobPriorityComboBox.Text.ToString());
				this.dataBaseDataSet.Jobs.Rows.Add(NewJobRow);
				this.jobsTableAdapter.Update(this.dataBaseDataSet.Jobs);
			}
			else
			{
				// write an exception message for users if no option is selected
			}
        }
	}
}
