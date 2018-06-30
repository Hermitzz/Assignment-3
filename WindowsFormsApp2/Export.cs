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
	public partial class Export : Form
	{
		// variables for sqlconnections
		SqlConnection conn;
		private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

		public Export()
		{
			// setting connection string
			string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "DataBase.mdf");
			string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
								filePath + @"; Integrated Security = True";
			csb.ConnectionString = connection;
			InitializeComponent();
		}

		private void Export_Load(object sender, EventArgs e)
		{
			// initializing DateTimePickers
			FromDatePicker.Value = DateTime.Today;
			ToDatePicker.Value = DateTime.Today;

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
		}


		private void ExportButton_Click(object sender, EventArgs e)
		{
			using (conn = new SqlConnection(csb.ConnectionString))
			{
				try
				{
					conn.Open();
					if (conn.State == ConnectionState.Open) // if connection.Open was successful
					{
						// getting Jobs between dates in from and to datepickers as well as jobs with the selected contractor id in the ContractorComboBox
						using (SqlCommand cmd = new SqlCommand("SELECT * FROM Jobs WHERE CONVERT(int, dateAndTime) > " + FromDatePicker.Value.ToShortDateString() + " AND CONVERT(int, dateAndTime) < " + ToDatePicker.Value.ToShortDateString() + " AND " +
							"ContractorId = " + ContractorComboBox.Text.ToString()))
						{
							// establishing connection and making reader to read returned data from query
							cmd.Connection = conn;
							SqlDataReader reader = cmd.ExecuteReader();

							// taking the table returned by the executed reader and making a DataTable out of it, then passing DataTable to the ExportFunction()
							DataTable results = reader.GetSchemaTable();
							conn.Close();
							ExportFunction(results);
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

		private void ExportFunction(DataTable results)
		{
			// here is where you make the export function, the results passed in should be the jobs for the contractor from a certain date period.
			MessageBox.Show("Export Success!.");
		}

		// below are tooltips for software usability
		private void ContractorComboBox_MouseHover(object sender, EventArgs e)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(ContractorComboBox, "Choose from available contractors using ContractorId");
		}


	}
}
