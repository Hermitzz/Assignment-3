using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection conn;
        SqlConnectionStringBuilder csb;

        public HomeBaseForm()
        {
            InitializeComponent();
            csb = new SqlConnectionStringBuilder();
            csb.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; 
                                    AttachDbFilename = D:\My Documents\GitHub\Assignment-3\WindowsFormsApp2\DataBase.mdf; 
                                    Integrated Security = True";                          
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
                    using (conn = new SqlConnection(csb.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            if (conn.State == ConnectionState.Open) // if connection.Open was successful
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT Clients " +
                                    "(name, address, landLine, mobilePhone, businessName, email) " +
                                    "VALUES ('" + ClientNameTextBox.Text + "', '" +
                                    ClientAddressTextBox.Text + "', '" +
                                    ClientLandLineTextBox.Text + "', '" +
                                    ClientMobilePhoneTextBox.Text + "', '" +
                                    ClientBusinessNameTextBox.Text + "', '" +
                                    ClientEmailTextBox.Text + "')"))
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = conn;
                                    cmd.ExecuteNonQuery();
                                    if (cmd.ExecuteNonQuery()>0)
                                    {
                                        MessageBox.Show("Record Successfully Added!");
                                    } else
                                    {
                                        MessageBox.Show("Adding Record Failed!");
                                    }
                                    conn.Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Connection failed.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
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
				//	this.jobsTableAdapter.Insert(NewJobRow.shortDescription, NewJobRow.location, NewJobRow.dateAndTime, NewJobRow.priority);
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

        private void AssignJobButton_Click(object sender, EventArgs e)
        {

        }
    }
}
