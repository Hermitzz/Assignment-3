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
using WindowsFormsApp2.DataBaseDataSetTableAdapters;

namespace WindowsFormsApp2
{
	public partial class AssignJobForm : Form
	{
		// variables for sqlconnections
		private SqlConnection conn;
		private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
		private BindingSource bindingSource1 = new BindingSource();
		private SqlDataAdapter dataAdapter = new SqlDataAdapter();

		// CurrentlySelectedRow keeps track of which row is highlighted in the JobDataGridView
		DataGridViewRow CurrentlySelectedRow;

		public AssignJobForm()
		{
			// setting connection string
			string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "DataBase.mdf");
			string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
								filePath + @"; Integrated Security = True";
			csb.ConnectionString = connection;
			InitializeComponent();
		}

		private void AssignJobForm_Load(object sender, EventArgs e)
		{
			using (conn = new SqlConnection(csb.ConnectionString))
			{
				try
				{
					conn.Open();
					if (conn.State == ConnectionState.Open) // if connection.Open was successful
					{
						// getting all from Contractors table
						using (SqlCommand cmd = new SqlCommand("SELECT * FROM Contractors"))
						{
							// establishing connection and making reader to read returned data from query
							cmd.Connection = conn;
							SqlDataReader reader = cmd.ExecuteReader();

							// iterating to read and add Contractor IDs found by reader to the combobox items collection.
							// reader.VisibleFieldCount / reader.FieldCount should equal the amount of rows because i couldn't find a rows counting function.
							for (int Index = 0; Index < reader.VisibleFieldCount / reader.FieldCount; Index++)
							{
								reader.Read();
								int conId = reader.GetInt32(0);
								ContractorComboBox.Items.Add(conId);
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

			// setting the datasource for the JobDataGridView and then getting data from the datasource to populate the view
			JobDataGridView.DataSource = bindingSource1;
			GetData("SELECT * from Jobs");
		}

		private void AssignButton_Click(object sender, EventArgs e)
		{
			// checking to see if a row in the JobDataGridView is selected
			if (CurrentlySelectedRow == null)
			{
				MessageBox.Show("Please Select a job to assign a contractor to", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				using (conn = new SqlConnection(csb.ConnectionString))
				{
					try
					{
						conn.Open();
						if (conn.State == ConnectionState.Open) // if connection.Open was successful
						{
                            
                            // updating Job records to assign a ContractorId to the job in the CurrentlySelectedRow
                            using (SqlCommand cmd = new SqlCommand("UPDATE Jobs SET ContractorId = " + ContractorComboBox.SelectedItem.ToString() + " WHERE jobId = " + CurrentlySelectedRow.Cells[0].Value.ToString()))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;
                                int a = cmd.ExecuteNonQuery();
                                if (a > 0)
                                {
                                    // using dataAdapter to update the bindingsource
                                    GetData(dataAdapter.SelectCommand.CommandText);
                                    dataAdapter.Update((DataTable)bindingSource1.DataSource);
                                    MessageBox.Show("Record Successfully Updated!");
                                }
                                else
                                {
                                    MessageBox.Show("Updating Record Failed!");
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
				MessageBox.Show("SqlException");
			}
		}

		private void JobDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != JobDataGridView.TopLeftHeaderCell.RowIndex)
			{

				CurrentlySelectedRow = JobDataGridView.Rows[e.RowIndex];
			}
		}

		private void ContractorComboBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorComboBox, "Choose from available contractors using ContractorId");
		}

		private void JobDataGridView_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorComboBox, "Select a job by clicking a cell in the row");
		}

		private void AssignButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorComboBox, "Assign the contractor specified to the selected job");
		}
	}
}
