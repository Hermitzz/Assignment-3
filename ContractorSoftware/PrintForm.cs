using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractorSoftware
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        public PrintForm(String JobShortDescriptionText, String ClientNameText,
                         String ClientAddressText, String ClientLandLineText,
                         String ClientMobilePhoneText, String ClientBusinessNameText,
                         String ClientEmailText, String AmountText)
        {
            InitializeComponent();

            JobShortDescriptionTextBox.Text = JobShortDescriptionText;
            ClientNameTextBox.Text = ClientNameText;
            ClientAddressTextBox.Text = ClientAddressText;
            ClientLandLineTextBox.Text = ClientLandLineText;
            ClientMobilePhoneTextBox.Text = ClientMobilePhoneText;
            ClientBusinessNameTextBox.Text = ClientBusinessNameText;
            ClientEmailTextBox.Text = ClientEmailText;
            AmountTextBox.Text = AmountText;

        }

        int invoiceNumber = 0;


        Bitmap memoryImage;

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            InvoiceNoText.Text = invoiceNumber.ToString();
            invoiceNumber++;
            Graphics myGraphics = this.CreateGraphics();
            Size size = this.Size;
            memoryImage = new Bitmap(size.Width, size.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, size);
            printPreviewDialog1.ShowDialog();
        }
        
    }
}
