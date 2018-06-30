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
    }
}
