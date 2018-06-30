﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
				if (ClientNameTextBox.Text.Trim() != "" && ClientAddressTextBox.Text.Trim() != "" && ClientLandLineTextBox.Text.Trim() != "" &&
					ClientMobilePhoneTextBox.Text.Trim() != "" && ClientBusinessNameTextBox.Text.Trim() != "" && ClientEmailTextBox.Text.Trim() != "")
				{
					DataBaseDataSet.ClientsRow NewClientsRow = dataBaseDataSet.Clients.NewClientsRow();
					NewClientsRow.name = ClientNameTextBox.Text.ToString();
					NewClientsRow.address = ClientAddressTextBox.Text.ToString();
					NewClientsRow.landLine = ClientLandLineTextBox.Text.ToString();
					NewClientsRow.mobilePhone = ClientMobilePhoneTextBox.Text.ToString();
					NewClientsRow.businessName = ClientBusinessNameTextBox.Text.ToString();
					NewClientsRow.email = ClientEmailTextBox.Text.ToString();
                    this.dataBaseDataSet.Clients.Rows.Add(NewClientsRow);
                 //   this.clientsTableAdapter.Insert(NewClientsRow.name, NewClientsRow.address, NewClientsRow.landLine, NewClientsRow.mobilePhone,
                  //      NewClientsRow.businessName, NewClientsRow.email);
                 //   dataBaseDataSet.AcceptChanges();

                    try
                    {
                        this.Validate();
                        this.clientsBindingSource.EndEdit();
                        this.clientsTableAdapter.Update(this.dataBaseDataSet.Clients);
                        MessageBox.Show("Update successful");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Update failed");
                    }

				}
				else
				{
					MessageBox.Show("Cannot add clients with empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else if (AddContractorRadioButton.Checked == true)
			{
				if (ContractorNameTextBox.Text.Trim() != "" && ContractorAddressTextBox.Text.Trim() != "" && ContractorLandLineTextBox.Text.Trim() != "" &&
					ContractorMobilePhoneTextBox.Text.Trim() != "" && ContractorEmployeeIdTextBox.Text.Trim() != "" && ContractorEmailTextBox.Text.Trim() != "")
				{
					DataBaseDataSet.ContractorsRow NewContractorRow = dataBaseDataSet.Contractors.NewContractorsRow();
					NewContractorRow.name = ContractorNameTextBox.Text.ToString();
					NewContractorRow.address = ContractorAddressTextBox.Text.ToString();
					NewContractorRow.landLine = ContractorLandLineTextBox.Text.ToString();
					NewContractorRow.mobilePhone = ContractorMobilePhoneTextBox.Text.ToString();
					NewContractorRow.employeeId = ContractorEmployeeIdTextBox.Text.ToString();
					NewContractorRow.email = ContractorEmailTextBox.Text.ToString();
					this.dataBaseDataSet.Contractors.Rows.Add(NewContractorRow);
					this.contractorsTableAdapter.Insert(NewContractorRow.name, NewContractorRow.address, NewContractorRow.landLine, NewContractorRow.mobilePhone,
						NewContractorRow.employeeId, NewContractorRow.email);
					this.contractorsTableAdapter.Update(this.dataBaseDataSet.Contractors);
					dataBaseDataSet.AcceptChanges();

				}
				else
				{
					MessageBox.Show("Cannot add contractors with empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else if (AddJobRadioButton.Checked == true)
			{
				if (JobLocationTextBox.Text.Trim() != "" && JobDateTimeTextBox.Text.Trim() != "")
				{
					DataBaseDataSet.JobsRow NewJobRow = dataBaseDataSet.Jobs.NewJobsRow();
					NewJobRow.shortDescription = JobShortDescriptionTextBox.Text.ToString();
					NewJobRow.location = JobLocationTextBox.Text.ToString();
					NewJobRow.dateAndTime = JobDateTimeTextBox.Text.ToString();
					NewJobRow.priority = Int32.Parse(JobPriorityComboBox.Text.ToString());
					this.dataBaseDataSet.Jobs.Rows.Add(NewJobRow);
					this.jobsTableAdapter.Insert(NewJobRow.shortDescription, NewJobRow.location, NewJobRow.dateAndTime, NewJobRow.priority);
					dataBaseDataSet.AcceptChanges();
					this.jobsTableAdapter.Update(this.dataBaseDataSet.Jobs);
				}
				else
				{
					MessageBox.Show("Cannot add jobs without location, date and time", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("No add option selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
        }

		private void ExportButton_Click(object sender, EventArgs e)
		{
			Export();
		}

		// just took the barebones of our last export function and applied it to this program. Still havent made it so it selects the job data for the contractors given date period. It just exports
		// whatever data is in the datagridview right now. Well its supposed to but there is a problem with the path.
		private void Export()
		{

			if (DataGridView.Rows.Count != 0)
			{

				//put data grid view into csv
				var StringBuilder = new StringBuilder();


				foreach (DataGridViewRow row in DataGridView.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						StringBuilder.Append(cell.Value.ToString() + ",");
					}
					StringBuilder.AppendLine();
				}

				//current directory
				string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

				TextWriter textWrite = new StreamWriter(exeFolder + "\\Jobs\\" + ContractorEmployeeIdTextBox.Text + " " + JobDateTimeTextBox.Text);


				textWrite.Write(StringBuilder.ToString());
				textWrite.Close();

				MessageBox.Show("Your data has been exported to " + exeFolder + "\\Jobs\\" + ContractorEmployeeIdTextBox.Text + " " + JobDateTimeTextBox.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No data to export", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
