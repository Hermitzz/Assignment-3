using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorSoftware
{
    public partial class Form1 : Form
    {

		public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

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
