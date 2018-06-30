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

        private SqlConnection conn;
        private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public HomeBaseForm()
        {
            InitializeComponent();
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


                DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Clients");

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


                DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Contractors");

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

                DataGridView.DataSource = bindingSource1;
                GetData("SELECT * from Jobs");

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
			else if (AddContractorRadioButton.Checked == true)
			{
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
			else if (AddJobRadioButton.Checked == true)
			{
				if (JobLocationTextBox.Text.Trim() != "" && JobDateTimeTextBox.Text.Trim() != "")
				{
                    using (conn = new SqlConnection(csb.ConnectionString))
                    {
                        try
                        {
                            conn.Open();
                            if (conn.State == ConnectionState.Open) // if connection.Open was successful
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT Jobs " +
                                    "(shortDescription, location, dateAndTime, priority, clientId, ContractorId, jobCompleted, amountCharged) " +
                                    "VALUES ('" + JobShortDescriptionTextBox.Text + "', '" +
                                    JobLocationTextBox.Text + "', '" +
                                    JobDateTimeTextBox.Text + "', '" +
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
			Export exportForm = new Export();
			exportForm.Show();
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
			AssignJobForm newAssignmentForm = new AssignJobForm(dataBaseDataSet, contractorsTableAdapter, jobsTableAdapter);
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
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }
}
