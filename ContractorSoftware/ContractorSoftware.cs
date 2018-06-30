using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorSoftware
{
	public partial class ContractorSoftware : Form
	{
		// variables for sql connection
		private SqlConnection conn;
		private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
		private BindingSource bindingSource1 = new BindingSource();
		private SqlDataAdapter dataAdapter = new SqlDataAdapter();

		// keeps track of the currently selected row in the DataGridView using cell click
		DataGridViewRow CurrentlySelectedRow;

		public ContractorSoftware()
		{
			InitializeComponent();
			// setting connection string
			string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "ContractorDataBase.mdf");
			string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
								filePath + @"; Integrated Security = True";
			csb.ConnectionString = connection;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// setting the datasource for the DataGridView to the jobs table in the database
			DataGridView.DataSource = bindingSource1;
			GetData("SELECT * from Jobs");

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

		// opens a new form holding the required invoice information which uses graphics to print a copy of said new form
		private void PrintButton_Click(object sender, EventArgs e)
		{
			PrintForm printForm = new PrintForm(JobShortDescriptionTextBox.Text, ClientNameTextBox.Text, ClientAddressTextBox.Text,
												ClientLandLineTextBox.Text, ClientMobilePhoneTextBox.Text, ClientBusinessNameTextBox.Text,
												ClientEmailTextBox.Text, AmountTextBox.Text);
			printForm.Show();
		}

		// sets the CurrentlySelectedRow and fills the form fields with the data from the selected row.
		private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != DataGridView.TopLeftHeaderCell.RowIndex)
			{

				CurrentlySelectedRow = DataGridView.Rows[e.RowIndex];

				JobShortDescriptionTextBox.Text = CurrentlySelectedRow.Cells[1].Value.ToString();
				JobLocationTextBox.Text = CurrentlySelectedRow.Cells[2].Value.ToString();
				JobDateTimePicker.Value = (DateTime)CurrentlySelectedRow.Cells[3].Value;
				JobPriorityTextBox.Text = CurrentlySelectedRow.Cells[4].Value.ToString();

				String currentClientId = CurrentlySelectedRow.Cells[5].Value.ToString();
				//TODO 
				//use for loop to find the current client and show the client details
				

				String currentContractorId = CurrentlySelectedRow.Cells[6].Value.ToString();
				//TODO
				//user for loop to find the current contractor and show the contractor name in the print form

				if (CurrentlySelectedRow.Cells[7].Value.ToString() == "0")
				{
					CompletionCheckBox.Checked = false;
				}
				else
				{
					CompletionCheckBox.Checked = true;
				}
			}
		}

		private void ImportButton_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				//if user selects a folder
				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					//get all files inside the folder
					string[] files = Directory.GetFiles(fbd.SelectedPath);

					//iterate through all files
					foreach (String file in files)
					{
						//if it's a csv file
						if (file.Contains(".csv"))
						{
							if (file.Contains("client"))
							{
								//read the file data
								var textRead = new StreamReader(new FileStream(file, FileMode.Open));

								//add to ScoutingDataGrid line by line
								while (!textRead.EndOfStream)
								{
									var sb = new StringBuilder();
									var line = textRead.ReadLine();

									sb.Append(line);

									string[] myArray = sb.ToString().Split(',');
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
													"VALUES ('" +
													myArray[1] + "', '" +
													myArray[2] + "', '" +
													myArray[3] + "', '" +
													myArray[4] + "', '" +
													myArray[5] + "', '" +
													myArray[6] + "')"))
												{
													cmd.CommandType = CommandType.Text;
													cmd.Connection = conn;
													int a = cmd.ExecuteNonQuery();
													if (a > 0)
													{
														GetData(dataAdapter.SelectCommand.CommandText);
														dataAdapter.Update((DataTable)bindingSource1.DataSource);

														ClientNameTextBox.Text = "";
														ClientAddressTextBox.Text = "";
														ClientLandLineTextBox.Text = "";
														ClientMobilePhoneTextBox.Text = "";
														ClientBusinessNameTextBox.Text = "";
														ClientEmailTextBox.Text = "";


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
								textRead.Close();
							}
							else if (file.Contains("contractor"))
							{
								//read the file data
								var textRead = new StreamReader(new FileStream(file, FileMode.Open));

								//add to ScoutingDataGrid line by line
								while (!textRead.EndOfStream)
								{
									var sb = new StringBuilder();
									var line = textRead.ReadLine();

									sb.Append(line);

									string[] myArray = sb.ToString().Split(',');
									using (conn = new SqlConnection(csb.ConnectionString))
									{
										try
										{
											conn.Open();
											if (conn.State == ConnectionState.Open) // if connection.Open was successful
											{
												// inserting field values into the Clients table in the database using the dataAdapter
												using (SqlCommand cmd = new SqlCommand("INSERT Contractors " +
												"(name, address, landLine, mobilePhone, employeeId, email) " +
												"VALUES ('" +
												myArray[1] + "', '" +
												myArray[2] + "', '" +
												myArray[3] + "', '" +
												myArray[4] + "', '" +
												myArray[5] + "', '" +
												myArray[6] + "')"))
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
								textRead.Close();
							}
							else if (file.Contains("job"))
							{
								//read the file data
								var textRead = new StreamReader(new FileStream(file, FileMode.Open));

								//add to ScoutingDataGrid line by line
								while (!textRead.EndOfStream)
								{
									var sb = new StringBuilder();
									var line = textRead.ReadLine();

									sb.Append(line);

									string[] myArray = sb.ToString().Split(',');
									using (conn = new SqlConnection(csb.ConnectionString))
									{
										try
										{
											conn.Open();
											if (conn.State == ConnectionState.Open) // if connection.Open was successful
											{
												// inserting field values into the Clients table in the database using the dataAdapter
												using (SqlCommand cmd = new SqlCommand("INSERT Jobs " +
												"(shortDescription, location, dateAndTime, priority, clientId, ContractorId, jobCompleted, amountCharged) " +
												"VALUES ('" +
												myArray[1] + "', '" +
												myArray[2] + "', '" +
												myArray[3] + "', '" +
												myArray[4] + "', '" +
												myArray[5] + "', '" +
												myArray[6] + "', '" +
												myArray[7] + "', '" +
												myArray[8] + "')"))
												{
													cmd.CommandType = CommandType.Text;
													cmd.Connection = conn;
													int a = cmd.ExecuteNonQuery();
													if (a > 0)
													{
														GetData(dataAdapter.SelectCommand.CommandText);
														dataAdapter.Update((DataTable)bindingSource1.DataSource);

														JobShortDescriptionTextBox.Text = "";
														JobLocationTextBox.Text = "";
														JobDateTimePicker.Value = DateTime.Today;


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
								textRead.Close();
							}
						}
					}
				}
			}
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			// to be implemented
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			// inserting field values into the Jobs table in the database using the dataAdapter
			using (SqlCommand cmd = new SqlCommand("UPDATE Jobs " +
				"SET shortDescription = " + JobShortDescriptionTextBox.Text + "amountCharged = " + AmountTextBox.Text + "jobCompleted = " + CompletionCheckBox.Checked +
				"WHERE jobId = " + CurrentlySelectedRow.Cells[0].Value))
			{
				cmd.CommandType = CommandType.Text;
				cmd.Connection = conn;
				int a = cmd.ExecuteNonQuery();
				if (a > 0)
				{
					GetData(dataAdapter.SelectCommand.CommandText);
					dataAdapter.Update((DataTable)bindingSource1.DataSource);

					JobShortDescriptionTextBox.Text = "";
					JobLocationTextBox.Text = "";
					JobDateTimePicker.Value = DateTime.Today;


					MessageBox.Show("Record Successfully Added!");
				}
				else
				{
					MessageBox.Show("Adding Record Failed!");
				}
				conn.Close();
			}

		}

		// below are tooltips to increase software usability
		private void ImportButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ImportButton, "Import records from HomeBase");
		}

		private void ExportButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ExportButton, "Export records to be merged with main DataBase later");
		}

		private void JobShortDescriptionTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(JobShortDescriptionTextBox, "Add a short description of the job");
		}

		private void AmountTextBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(AmountTextBox, "Enter the amount charged for the job");
		}

		private void CompletionCheckBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(CompletionCheckBox, "Check when job is completed");
		}

		private void UpdateButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(UpdateButton, "Update the Data from form fields");
		}

		private void PrintButton_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(PrintButton, "Open printing form to print invoice");
		}
	}
}
