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
		private PrintDocument printDocument1 = new PrintDocument();
		Bitmap memoryImage;

		public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void PrintButton_Click(object sender, EventArgs e)
		{
			CaptureScreen();
			printDocument1.Print();
		}


		private void CaptureScreen()
		{
			Graphics myGraphics = this.CreateGraphics();
			Size JobGroupBoxSize = JobDetailsGroupBox.Size;
			memoryImage = new Bitmap(JobGroupBoxSize.Width, JobGroupBoxSize.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			memoryGraphics.CopyFromScreen(JobDetailsGroupBox.Location.X, JobDetailsGroupBox.Location.Y, JobDetailsGroupBox.Location.X + JobDetailsGroupBox.Size.Width, JobDetailsGroupBox.Size.Height, JobGroupBoxSize);
		}

		private void printDocument1_PrintPage(System.Object sender,
			   System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}
	}
}
