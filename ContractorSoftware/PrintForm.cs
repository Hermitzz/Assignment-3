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
		// an int for numbering the invoices printed
		private int invoiceNumber = 0;

		// a bitmap for capturing the form graphics and printing them
		Bitmap memoryImage;

		public PrintForm()
        {
            InitializeComponent();
        }

		// takes the form data from the ContractorSoftware and places it into fields on this form to be printed
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

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }

		// a function for drawing up graphics from the form using the memoryImage made in PrintButton_Click
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

		// prints the form
        private void PrintButton_Click(object sender, EventArgs e)
        {
			// sets the invoice number label then increments the variable to the next value
            InvoiceNoText.Text = invoiceNumber.ToString();
            invoiceNumber++;

			// creating graphics to print from
            Graphics myGraphics = this.CreateGraphics();
            Size size = this.Size;
            memoryImage = new Bitmap(size.Width, size.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, size);

			// showing print preview in a seperate dialog to confirm printing
            printPreviewDialog1.ShowDialog();
        }
        
    }
}
