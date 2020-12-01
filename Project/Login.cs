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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var myForm = new Form_Main();
			myForm.Show();
			this.Hide();//hide form
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtUser.Text =="a" && txtPass.Text=="a")
			{
				var myForm = new Form_Main();
				myForm.Show();
				this.Hide();//hide form
			}
			else
			{
				MessageBox.Show("Username or Password is wrong","ERROR");

			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtUser.Text = "";
			txtPass.Text = "";
		}
	}
}
