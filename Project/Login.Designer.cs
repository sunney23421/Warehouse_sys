namespace Project
{
	partial class Login
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "UserName";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(122, 45);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(148, 20);
			this.txtUser.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(122, 76);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(148, 20);
			this.txtPass.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(163, 116);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(107, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.Controls.Add(this.txtPass);
			this.groupBox1.Controls.Add(this.txtUser);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(30, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(287, 163);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(42, 116);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(97, 23);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(281, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Login(Fake)";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 225);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Login";
			this.Text = "LoginForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnClear;
	}
}