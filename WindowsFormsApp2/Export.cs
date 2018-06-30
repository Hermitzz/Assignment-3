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

                            while(reader.Read())
                            {
                                ContractorComboBox.Items.Add(reader.GetValue(0));
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
                        MessageBox.Show("From: " + FromDatePicker.Value.ToShortDateString());
                        MessageBox.Show("To: " + ToDatePicker.Value.ToShortDateString());

                        // getting Jobs between dates in from and to datepickers as well as jobs with the selected contractor id in the ContractorComboBox
                        using (SqlCommand cmd = new SqlCommand(@"SELECT * FROM Jobs WHERE dateAndTime >= '" + FromDatePicker.Value.ToShortDateString() + @"' AND dateAndTime <= '" + ToDatePicker.Value.ToShortDateString() + @"' AND " +
                        	"ContractorId = " + ContractorComboBox.Text.ToString()))
                        {
							// establishing connection and making reader to read returned data from query
							cmd.Connection = conn;
							SqlDataReader reader = cmd.ExecuteReader();

							// taking the table returned by the executed reader and making a DataTable out of it, then passing DataTable to the ExportFunction()
							//DataTable results = reader.GetSchemaTable();
							//conn.Close();
							ExportFunction(reader);
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

		private void ExportFunction(SqlDataReader results)
		{
            // here is where you make the export function, the results passed in should be the jobs for the contractor from a certain date period.
            StringBuilder sb = new StringBuilder();
            StreamWriter sw = new StreamWriter(System.IO.Directory.GetCurrentDirectory() + "testfile.csv");

            //get columns
            var columnNames = Enumerable.Range(0, results.FieldCount)
                .Select(results.GetName)
                .ToList();

            //headers
            sb.Append(string.Join(",", columnNames));
            sb.AppendLine();
            while (results.Read())
            {
                
                var values = Enumerable.Range(0, results.FieldCount)
                .Select(results.GetValue)
                .ToList();

                sb.Append(string.Join(",", values));
                sb.AppendLine();
                
            }

            MessageBox.Show(sb.ToString());

            sw.Write(sb.ToString());
            sw.Close();
            conn.Close();
            MessageBox.Show("Export Success!.");
		}
	}
}
