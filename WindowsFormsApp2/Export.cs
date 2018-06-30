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
		SqlConnection conn;
		private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();

		public Export()
		{
			string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "DataBase.mdf");
			string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
								filePath + @"; Integrated Security = True";
			csb.ConnectionString = connection;
			InitializeComponent();
		}

		private void Export_Load(object sender, EventArgs e)
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
								string conId = reader.GetString(1) + " " + reader.GetInt32(0).ToString();
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
			// need table adapters to work so i can make a custom select query that takes date and id values from form.
			using (conn = new SqlConnection(csb.ConnectionString))
			{
				try
				{
					conn.Open();
					if (conn.State == ConnectionState.Open) // if connection.Open was successful
					{
						using (SqlCommand cmd = new SqlCommand("SELECT * FROM Contractors WHERE dateAndTime > " + FromDatePicker.Value + " AND dateAndTime < " + ToDatePicker.Value + " AND " +
							"ContractorId = " + ContractorComboBox.SelectedValue))
						{
							cmd.Connection = conn;
							SqlDataReader reader = cmd.ExecuteReader();
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
		}
	}
}
