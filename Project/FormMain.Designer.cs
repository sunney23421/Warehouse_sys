namespace Project
{
	partial class Form_Main
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
			this.btn_in_stock = new System.Windows.Forms.Button();
			this.btn_Sell_stock = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnFakeadd = new System.Windows.Forms.Button();
			this.btnQr2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnQr1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_in_stock
			// 
			this.btn_in_stock.Location = new System.Drawing.Point(24, 26);
			this.btn_in_stock.Name = "btn_in_stock";
			this.btn_in_stock.Size = new System.Drawing.Size(241, 134);
			this.btn_in_stock.TabIndex = 0;
			this.btn_in_stock.Text = "Add stock";
			this.btn_in_stock.UseVisualStyleBackColor = true;
			this.btn_in_stock.Click += new System.EventHandler(this.btn_in_stock_Click);
			// 
			// btn_Sell_stock
			// 
			this.btn_Sell_stock.Location = new System.Drawing.Point(304, 26);
			this.btn_Sell_stock.Name = "btn_Sell_stock";
			this.btn_Sell_stock.Size = new System.Drawing.Size(241, 134);
			this.btn_Sell_stock.TabIndex = 1;
			this.btn_Sell_stock.Text = "Sell stock";
			this.btn_Sell_stock.UseVisualStyleBackColor = true;
			this.btn_Sell_stock.Click += new System.EventHandler(this.btn_Sell_stock_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 193);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(241, 119);
			this.button1.TabIndex = 2;
			this.button1.Text = "Report";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnFakeadd
			// 
			this.btnFakeadd.Location = new System.Drawing.Point(27, 30);
			this.btnFakeadd.Name = "btnFakeadd";
			this.btnFakeadd.Size = new System.Drawing.Size(96, 52);
			this.btnFakeadd.TabIndex = 3;
			this.btnFakeadd.Text = "AddData(Fake) \r\nwith fix data";
			this.btnFakeadd.UseVisualStyleBackColor = true;
			this.btnFakeadd.Click += new System.EventHandler(this.btnFakeadd_Click);
			// 
			// btnQr2
			// 
			this.btnQr2.Location = new System.Drawing.Point(27, 167);
			this.btnQr2.Name = "btnQr2";
			this.btnQr2.Size = new System.Drawing.Size(96, 52);
			this.btnQr2.TabIndex = 4;
			this.btnQr2.Text = "QR2\r\n+ better\r\n- unable to read one time";
			this.btnQr2.UseVisualStyleBackColor = true;
			this.btnQr2.Click += new System.EventHandler(this.btncallQr2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnQr1);
			this.groupBox1.Controls.Add(this.btnQr2);
			this.groupBox1.Controls.Add(this.btnFakeadd);
			this.groupBox1.Location = new System.Drawing.Point(631, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 320);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TEST";
			// 
			// btnQr1
			// 
			this.btnQr1.Location = new System.Drawing.Point(27, 88);
			this.btnQr1.Name = "btnQr1";
			this.btnQr1.Size = new System.Drawing.Size(96, 73);
			this.btnQr1.TabIndex = 5;
			this.btnQr1.Text = "QR1\r\n+ read one at time \r\n- suck";
			this.btnQr1.UseVisualStyleBackColor = true;
			this.btnQr1.Click += new System.EventHandler(this.btnQr1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(304, 193);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(241, 119);
			this.button2.TabIndex = 6;
			this.button2.Text = "Return Product\r\n(Update Data Sql)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 413);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Sell_stock);
			this.Controls.Add(this.btn_in_stock);
			this.Name = "Form_Main";
			this.Text = "Form_Main";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_in_stock;
		private System.Windows.Forms.Button btn_Sell_stock;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnFakeadd;
		private System.Windows.Forms.Button btnQr2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnQr1;
		private System.Windows.Forms.Button button2;
	}
}

