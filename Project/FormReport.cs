using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class FormReport : Form
	{
		DataManager m1	=	new DataManager("localhost", "Product", "root", "");

		string constring	=	"datasource=localhost;port=3306;database='product';username=root;password=";
		MySqlDataReader myReader;

		public FormReport()
		{
			InitializeComponent();
		}

		

		private void btnReport_Click(object sender, EventArgs e)
		{
			
			string cmd	=	"select * from product_info";
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;

			MySqlConnection conDateBase	= new MySqlConnection(constring);
			MySqlCommand cmdDateBase	= new MySqlCommand("SELECT * FROM `Product_info` WHERE 1;", conDateBase);
			conDateBase.Open();
			try
			{

				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"), 
						myReader.GetInt32("Price_Sell"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	

		}//Check Report

		private void btnB_Click(object sender, EventArgs e)
		{
			var myFrom = new Form_Main();
			myFrom.Show();
			this.Hide();
		}//btn back to main form

		private void button1_Click(object sender, EventArgs e)
		{	
			string cmd	=	"select Product_name,SUM(Qty) from product_info GROUP BY Product_name";//>>-
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;

			MySqlConnection conDateBase = new MySqlConnection(constring);
			MySqlCommand cmdDateBase	= new MySqlCommand("SELECT Product_name,SUM(Qty) from product_info GROUP BY Product_name;", conDateBase);
			conDateBase.Open();
			try
			{

				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"), 
						myReader.GetInt32("SUM(Qty)"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	
		}//Total Product

		private void button2_Click(object sender, EventArgs e)
		{
			string cmd	= "SELECT Product_name,SUM(Price_Sell-Price_origin) From product_info GROUP BY Product_name;";
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;

			MySqlConnection conDateBase = new MySqlConnection(constring);
			MySqlCommand cmdDateBase	= new MySqlCommand("SELECT Product_name,SUM(Price_Sell-Price_origin) From product_info GROUP BY Product_name;", conDateBase);
			conDateBase.Open();
			try
			{

				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"), 
						myReader.GetInt32("SUM(Price_Sell-Price_origin)"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	


		}//Total Expens

		private void button3_Click(object sender, EventArgs e)
		{	
			string cmd = "select Product_name,SUM(Price_Sell) from product_info GROUP BY Product_name";//>>-
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;

			MySqlConnection conDateBase = new MySqlConnection(constring);
			MySqlCommand cmdDateBase	= new MySqlCommand("select Product_name,SUM(Price_Sell) from product_info GROUP BY Product_name", conDateBase);
			conDateBase.Open();
			try
			{

				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"),
						myReader.GetInt32("SUM(Price_Sell)"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	

		}//Total Profit

		private void button4_Click(object sender, EventArgs e)
		{	
			string cmd = "select Product_name,SUM(Price_Sell),SUM(Price_Sell-Price_origin)" +
							" from product_info GROUP BY Product_name";
			DataTable table1 = m1.GetDataTable(cmd);
			dataGridView1.DataSource = table1;

			MySqlConnection conDateBase = new MySqlConnection(constring);
			MySqlCommand cmdDateBase = new MySqlCommand("select Product_name,SUM(Price_Sell),SUM(Price_Sell-Price_origin)" +
							" from product_info GROUP BY Product_name", conDateBase);
			conDateBase.Open();
			try
			{

				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"), myReader.GetInt32("SUM(Price_Sell)"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	

		}//Net Profit 

		private void chart1_Click(object sender, EventArgs e)
		{
		}

		private void btnGph_Click(object sender, EventArgs e)
		{
			MySqlConnection conDateBase = new MySqlConnection(constring);
			MySqlCommand cmdDateBase = new MySqlCommand("SELECT * FROM `Product_info` WHERE 1;", conDateBase);
			conDateBase.Open();
			try
			{
				
				myReader = cmdDateBase.ExecuteReader();
				while (myReader.Read())
				{
					this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("Product_name"), myReader.GetInt32("Price_Sell"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error");
			}//end if	
		}//end my life.i spend this part like a two days,wtf am i this stupid.

		private void FormReport_Load(object sender, EventArgs e)
		{
			
		}

		private void btnCleanGph_Click(object sender, EventArgs e)
		{
			foreach (var series in chart1.Series)
			{
				series.Points.Clear();
			}
		}
		//never fucking skydrive in coding
		// finaly i did it, omg
	}//end class
}//end namespace
