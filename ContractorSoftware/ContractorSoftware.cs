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

        private SqlConnection conn;
        private SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public ContractorSoftware()
        {
            InitializeComponent();
            string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "ContractorDataBase.mdf");
            string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " +
                                filePath + @"; Integrated Security = True";
            csb.ConnectionString = connection;
        }

		private void Form1_Load(object sender, EventArgs e)
		{
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
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
		{
            PrintForm printForm = new PrintForm(JobShortDescriptionTextBox.Text, ClientNameTextBox.Text, ClientAddressTextBox.Text,
                                                ClientLandLineTextBox.Text, ClientMobilePhoneTextBox.Text, ClientBusinessNameTextBox.Text,
                                                ClientEmailTextBox.Text, AmountTextBox.Text);
            printForm.Show();
        }


    }
}
