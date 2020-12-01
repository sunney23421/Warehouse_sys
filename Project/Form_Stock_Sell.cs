using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class Form_Stock_Sell : Form
	{
		public Form_Stock_Sell()
		{
			InitializeComponent();
		}

		private void btn_Stock_Sell_back_Click(object sender, EventArgs e)
		{
			var myForm = new Form_Main();
			myForm.Show();
			this.Hide();
		}
	}
}
