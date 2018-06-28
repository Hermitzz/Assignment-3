using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class HomeBaseForm : Form
    {
        public HomeBaseForm()
        {
            InitializeComponent();
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
		}

		private void AddClientRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (AddClientRadioButton.Checked == true)
            {
                AddClientGroupBox.Visible = true;
				AddClientGroupBox.BringToFront();
                AddJobGroupBox.Visible = false;
                AddContractorGroupBox.Visible = false;

				DataGridView.DataSource = dataBaseDataSet.Clients;
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

				DataGridView.DataSource = dataBaseDataSet.Contractors;
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

				DataGridView.DataSource = dataBaseDataSet.Jobs;
			}
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
			int ControlCount = 0;
			foreach (GroupBox GroupBox in this.Controls.OfType<GroupBox>().ToArray())
			{
				foreach (Control Control in GroupBox.Controls)
				{
					if (Control.GetType() == new TextBox().GetType())
					{
						ControlCount ++;
					}
					else if (Control.GetType() == new ComboBox().GetType())
					{
						ControlCount ++;
					}
				}
			}

			DataBaseDataSet.ClientsRow NewClientsRow;
			NewClientsRow = dataBaseDataSet.Clients.NewClientsRow();
			clientsTableAdapter.Insert(ClientNameTextBox.Text.ToString(), ClientAddressTextBox.Text.ToString(), ClientLandLineTextBox.Text.ToString(), 
				ClientMobilePhoneTextBox.Text.ToString(), ClientBusinessNameTextBox.Text.ToString(), ClientEmailTextBox.Text.ToString());

			this.dataBaseDataSet.Clients.Rows.Add(NewClientsRow);
			this.clientsTableAdapter.Update(this.dataBaseDataSet.Clients);
        }
	}
}
