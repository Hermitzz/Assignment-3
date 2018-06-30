﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Export : Form
	{
		SqlConnection conn;
		SqlConnectionStringBuilder csb;

		public Export()
		{
			csb = new SqlConnectionStringBuilder();
			csb.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; 
                                    AttachDbFilename = C:\Users\liams\Downloads\Assignment3 Copy\WindowsFormsApp2\WindowsFormsApp2\DataBase.mdf; 
                                    Integrated Security = True";
			InitializeComponent();
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			// need table adapters to work so i can make a custom select query that takes date and id values from form.
			
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
								string conId = reader.GetString(1);
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
	}
}
