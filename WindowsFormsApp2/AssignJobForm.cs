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
		private SqlConnection conn;
		private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
		private BindingSource bindingSource1 = new BindingSource();
		private SqlDataAdapter dataAdapter = new SqlDataAdapter();
		DataGridViewRow CurrentlySelectedRow;

		public AssignJobForm()
		{
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
						using (SqlCommand cmd = new SqlCommand("SELECT * FROM Contractors"))
						{
							cmd.Connection = conn;
							SqlDataReader reader = cmd.ExecuteReader();
							for (int Index = 0; Index < reader.VisibleFieldCount / reader.FieldCount; Index++)
							{
								reader.Read();
								string conId = reader.GetInt32(0).ToString();
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
			JobDataGridView.DataSource = bindingSource1;
			GetData("SELECT * from Jobs");
		}

		private void AssignButton_Click(object sender, EventArgs e)
		{
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
							using (SqlCommand cmd = new SqlCommand("UPDATE Jobs SET ContractorId = " + ContractorComboBox.SelectedValue + " WHERE jobId = " + CurrentlySelectedRow.Cells[0]))
							{
								cmd.CommandType = CommandType.Text;
								cmd.Connection = conn;
								int a = cmd.ExecuteNonQuery();
								if (a > 0)
								{
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
				MessageBox.Show("To run this example, replace the value of the " +
					"connectionString variable with a connection string that is " +
					"valid for your system.");
			}
		}

		private void JobDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != JobDataGridView.TopLeftHeaderCell.RowIndex)
			{

				CurrentlySelectedRow = JobDataGridView.Rows[e.RowIndex];
			}
		}
	}
}
