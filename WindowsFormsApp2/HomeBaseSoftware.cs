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
		// variables for sql connections
        private SqlConnection conn;
        private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public HomeBaseForm()
        {
            InitializeComponent();
			// setting connection string
            string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "DataBase.mdf");
            string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
                                filePath + @"; Integrated Security = True";
            csb.ConnectionString = connection;

        }

		private void Form1_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataBaseDataSet.Jobs' table. You can move, or remove it, as needed.
			this.jobsTableAdapter.Fill(this.dataBaseDataSet.Jobs);
			// TODO: This line of code loads data into the 'dataBaseDataSet.Contractors' table. You can move, or remove it, as needed.
			this.contractorsTableAdapter.Fill(this.dataBaseDataSet.Contractors);
			// TODO: This line of code loads data into the 'dataBaseDataSet.Clients' table. You can move, or remove it, as needed.
			this.clientsTableAdapter.Fill(this.dataBaseDataSet.Clients);

			// setting initial GroupBox visibility
			AddClientGroupBox.Visible = false;
			AddContractorGroupBox.Visible = false;
			AddJobGroupBox.Visible = false;

			// setting initial parents and locations for child groupboxes of ClientGroupBox
			AddContractorGroupBox.Parent = AddClientGroupBox.Parent;
			AddContractorGroupBox.Location = AddClientGroupBox.Location;
			AddJobGroupBox.Parent = AddClientGroupBox.Parent;
			AddJobGroupBox.Location = AddClientGroupBox.Location;

			// setting JobPriorityComboBox default to 0
			JobPriorityComboBox.SelectedIndex = 0;

        }

		// makes the selected groupbox visible and the others invisible as well as setting the DataGridView datasource to the selected option
		private void AddClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
			// checking if this radio button is checked
            if (AddClientRadioButton.Checked == true)
            {
				// making selected GroupBox visible and bringing it to front whilst making unselected GroupBoxes invisible
                AddClientGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
                AddJobGroupBox.Visible = false;
                AddContractorGroupBox.Visible = false;

				// changing datagridview datasource to the selected option
				DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Clients");

            }
        }

		// makes the selected groupbox visible and the others invisible as well as setting the DataGridView datasource to the selected option
		private void AddContractorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
			// checking if this radio button is checked
			if (AddContractorRadioButton.Checked == true)
            {
				// making selected GroupBox visible and bringing it to front whilst making unselected GroupBoxes invisible
				AddContractorGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
				AddJobGroupBox.Visible = false;
                AddClientGroupBox.Visible = false;

				// changing datagridview datasource to the selected option
                DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Contractors");

            }

        }

		// makes the selected groupbox visible and the others invisible as well as setting the DataGridView datasource to the selected option
		private void AddJobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
			// checking if this radio button is checked
			if (AddJobRadioButton.Checked == true)
            {
				// making selected GroupBox visible and bringing it to front whilst making unselected GroupBoxes invisible
				AddJobGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
				AddClientGroupBox.Visible = false;
                AddContractorGroupBox.Visible = false;

				// changing datagridview datasource to the selected option
				DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Jobs");

            }

        }

		// checks which option is currently selected and adds data from the fields to the database.
		private void AddButton_Click(object sender, EventArgs e)
        {
			// checking if this radio button is checked
			if (AddClientRadioButton.Checked == true)
			{
				// checking for empty fields
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
								// inserting field values into the Clients table in the database using the dataAdapter
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
                                    int a = cmd.ExecuteNonQuery();
                                    if (a>0)
                                    {
                                        GetData(dataAdapter.SelectCommand.CommandText);
                                        dataAdapter.Update((DataTable)bindingSource1.DataSource);
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
			// checking if this radio button is checked
			else if (AddContractorRadioButton.Checked == true)
			{
				// checking for empty fields
				if (ContractorNameTextBox.Text.Trim() != "" && ContractorAddressTextBox.Text.Trim() != "" && ContractorLandLineTextBox.Text.Trim() != "" &&
					ContractorMobilePhoneTextBox.Text.Trim() != "" && ContractorEmployeeIdTextBox.Text.Trim() != "" && ContractorEmailTextBox.Text.Trim() != "")
				{
                    using (conn = new SqlConnection(csb.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            if (conn.State == ConnectionState.Open) // if connection.Open was successful
                            {
								// inserting field values into the Contractors table in the database using the dataAdapter
								using (SqlCommand cmd = new SqlCommand("INSERT Contractors " +
                                    "(name, address, landLine, mobilePhone, employeeId, email) " +
                                    "VALUES ('" + ContractorNameTextBox.Text + "', '" +
                                    ContractorAddressTextBox.Text + "', '" +
                                    ContractorLandLineTextBox.Text + "', '" +
                                    ContractorMobilePhoneTextBox.Text + "', '" +
                                    ContractorEmployeeIdTextBox.Text + "', '" +
                                    ContractorEmailTextBox.Text + "')"))
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = conn;
                                    int a = cmd.ExecuteNonQuery();
                                    if (a > 0)
                                    {
                                        GetData(dataAdapter.SelectCommand.CommandText);
                                        dataAdapter.Update((DataTable)bindingSource1.DataSource);
                                        MessageBox.Show("Record Successfully Added!");
                                    }
                                    else
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
					MessageBox.Show("Cannot add contractors with empty fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			// checking if this radio button is checked
			else if (AddJobRadioButton.Checked == true)
			{
				// checking for empty fields, except for the shortdescription and other areas such as amountCharged which are set by contractors later
				if (JobLocationTextBox.Text.Trim() != "" && DateTimePicker.Value != null)
				{
                    using (conn = new SqlConnection(csb.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            if (conn.State == ConnectionState.Open) // if connection.Open was successful
                            {
								// inserting field values into the Jobs table in the database using the dataAdapter
								using (SqlCommand cmd = new SqlCommand("INSERT Jobs " +
                                    "(shortDescription, location, dateAndTime, priority, clientId, ContractorId, jobCompleted, amountCharged) " +
                                    "VALUES ('" + JobShortDescriptionTextBox.Text + "', '" +
                                    JobLocationTextBox.Text + "', '" +
                                    DateTimePicker.Value + "', '" +
                                    JobPriorityComboBox.Text + "', '" +
                                    ClientIDTextBox.Text + "', '" +
                                    "2" + "', '" +
                                    "" + "', '" +
                                    0 + "')"))
                                {
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = conn;
                                    int a = cmd.ExecuteNonQuery();
                                    if (a > 0)
                                    {
                                        GetData(dataAdapter.SelectCommand.CommandText);
                                        dataAdapter.Update((DataTable)bindingSource1.DataSource);
                                        MessageBox.Show("Record Successfully Added!");
                                    }
                                    else
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
			// creates an exportForm which handles the exporting function
			Export exportForm = new Export();
			exportForm.Show();
		}

		private void AssignJobButton_Click(object sender, EventArgs e)
		{
			// creates a AssignJobForm which handles adding selected contractorIds to the selected jobs
			AssignJobForm newAssignmentForm = new AssignJobForm();
			newAssignmentForm.ShowDialog();
		}

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = csb.ConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                
            }
            catch (SqlException)
            {
                MessageBox.Show("sqlException");
            }
        }

		// imports records edited in the contractor software package and merges them with the existing database
        private void ImportButton_Click(object sender, EventArgs e)
        {
			// still have to complete
        }

		// below are tooltips used to increase software usability
		private void AssignJobButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AssignJobButton, "Assign Contractors to Jobs");
		}

		private void ImportButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ImportButton, "Import and merge records from Contractor Software");
		}

		private void ExportButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ExportButton, "Export Selected Job Records for a specified Contractor");
		}

		private void AddButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddButton, "Adds data from current form fields to the DataBase and View");
		}

		private void ClientIDTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ClientIDTextBox, "ID number of the Client requesting the job");
		}

		private void JobPriorityComboBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(JobPriorityComboBox, "Job priority rated 1-5. 1 is lowest, 5 the highest");
		}

		private void ContractorLandLineTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorLandLineTextBox, "The Landline phone number of the contractor");
		}

		private void ContractorEmployeeIdTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorEmployeeIdTextBox, "The organisational employee ID set by IQ Incorperated");
		}

		private void ClientLandLineTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ClientLandLineTextBox, "The Landline phone number of the client");
		}

		private void ClientBusinessNameTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ClientBusinessNameTextBox, "The name of the client business");
		}

		private void AddClientRadioButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddClientRadioButton, "Add a client to the DataBase");
		}

		private void AddContractorRadioButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddContractorRadioButton, "Add a contractor to the DataBase");
		}

		private void AddJobRadioButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AddJobRadioButton, "Add a job to the DataBase");
		}

		private void DataGridView_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(DataGridView, "A DataGridView showing DataBase records");
		}
	}
}
