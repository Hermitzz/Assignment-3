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
	public partial class Export : Form
	{
		public Export()
		{
			InitializeComponent();
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			// need table adapters to work so i can make a custom select query that takes date and id values from form.
		}
	}
}
