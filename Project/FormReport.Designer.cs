namespace Project
{
	partial class FormReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnReport = new System.Windows.Forms.Button();
			this.btnTotoalPro = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnGph = new System.Windows.Forms.Button();
			this.btnCleanGph = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(105, 23);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(594, 193);
			this.dataGridView1.TabIndex = 0;
			// 
			// btnReport
			// 
			this.btnReport.Location = new System.Drawing.Point(105, 256);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(176, 59);
			this.btnReport.TabIndex = 1;
			this.btnReport.Text = "Check Report";
			this.btnReport.UseVisualStyleBackColor = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// btnTotoalPro
			// 
			this.btnTotoalPro.Location = new System.Drawing.Point(312, 256);
			this.btnTotoalPro.Name = "btnTotoalPro";
			this.btnTotoalPro.Size = new System.Drawing.Size(176, 59);
			this.btnTotoalPro.TabIndex = 2;
			this.btnTotoalPro.Text = "Total Product";
			this.btnTotoalPro.UseVisualStyleBackColor = true;
			this.btnTotoalPro.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(105, 339);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(176, 59);
			this.button2.TabIndex = 3;
			this.button2.Text = "Total Expens";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(312, 339);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(176, 59);
			this.button3.TabIndex = 4;
			this.button3.Text = "Total Profit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(523, 339);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(176, 59);
			this.button4.TabIndex = 5;
			this.button4.Text = "NetProfit";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(523, 256);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(176, 59);
			this.button5.TabIndex = 6;
			this.button5.Text = "Total Retrun Product\r\n(Not sure how to do in SQL)";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(721, 339);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(67, 59);
			this.btnB.TabIndex = 7;
			this.btnB.Text = "Back to Main Page";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Click += new System.EventHandler(this.btnB_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(105, 427);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series1.YValuesPerPoint = 2;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(594, 300);
			this.chart1.TabIndex = 8;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// btnGph
			// 
			this.btnGph.Location = new System.Drawing.Point(12, 357);
			this.btnGph.Name = "btnGph";
			this.btnGph.Size = new System.Drawing.Size(87, 61);
			this.btnGph.TabIndex = 9;
			this.btnGph.Text = "Update Graph";
			this.btnGph.UseVisualStyleBackColor = true;
			this.btnGph.Click += new System.EventHandler(this.btnGph_Click);
			// 
			// btnCleanGph
			// 
			this.btnCleanGph.Location = new System.Drawing.Point(12, 437);
			this.btnCleanGph.Name = "btnCleanGph";
			this.btnCleanGph.Size = new System.Drawing.Size(87, 61);
			this.btnCleanGph.TabIndex = 10;
			this.btnCleanGph.Text = "Clean Graph";
			this.btnCleanGph.UseVisualStyleBackColor = true;
			this.btnCleanGph.Click += new System.EventHandler(this.btnCleanGph_Click);
			// 
			// FormReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 749);
			this.Controls.Add(this.btnCleanGph);
			this.Controls.Add(this.btnGph);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnTotoalPro);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormReport";
			this.Text = "FormReport";
			this.Load += new System.EventHandler(this.FormReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Button btnTotoalPro;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button btnGph;
		private System.Windows.Forms.Button btnCleanGph;
	}
}