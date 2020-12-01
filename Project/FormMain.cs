
using QR_Code_Scanner;
using ReadQRcode;
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
	public partial class Form_Main : Form
	{
		DataManager m1 = new DataManager("localhost", "Product", "root", "");
		public Form_Main()
		{
			InitializeComponent();
		}

		private void btn_in_stock_Click(object sender, EventArgs e)
		{/*/
			var myForm = new Form_Stock_add();
			myForm.Show();
			this.Hide();
			*///
			var myForm1 = new Form11();
			myForm1.Show();
		}

		private void btn_Sell_stock_Click(object sender, EventArgs e)
		{/*/
			var myForm = new Form_Stock_Sell();
			myForm.Show();
			this.Hide();
			*/
			var myForm = new Form11();
			myForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var myForm = new FormReport(); 
			myForm.Show();
			this.Hide();
			/*
			DataManager m1 = new DataManager("localhost", "Product", "root", "");
			string cmd = "select * from product_info";
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;
			/*/
		}

		public void btnFakeadd_Click(object sender, EventArgs e)
		{
			string cmd	=	"insert into Product_info( Product_id,Product_name,Price_origin,Price_Sell,Qty) " +
							"values('','Apds2ple',552,2222,122)";
			
			m1.ExecuteNonQuery(cmd);
			MessageBox.Show("the new row is saved");
		}//btn fake adddata

		private void btncallQr2_Click(object sender, EventArgs e)
		{
			var myFrom = new Form1();
			myFrom.Show();
		}

		private void btnQr1_Click(object sender, EventArgs e)
		{
			var myFrom = new Form11();
			myFrom.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var myFrom = new FormReturn();
			myFrom.Show();
		}

	}
}
