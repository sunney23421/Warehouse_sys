using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project
{
	public partial class FormReturn : Form
	{
		public FormReturn()
		{
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			/*UPDATE table_name
			SET column1 = value1, column2 = value2...., columnN = valueN
			WHERE [condition];*/

			//string cmd = "UPDATE product set ";

			// id k so lazxy right now
			
		}

		
	}
}
