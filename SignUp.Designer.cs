﻿
namespace CD_Dealership
{
	partial class Form2
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
			this.label3 = new System.Windows.Forms.Label();
			this.userIDTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lastnameTxt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.confirmPassTxt = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.firstnameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(206, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "New User";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(145, 363);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please enter your details to register profile";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(106, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "First Name:";
			// 
			// userIDTxt
			// 
			this.userIDTxt.Location = new System.Drawing.Point(192, 91);
			this.userIDTxt.Name = "userIDTxt";
			this.userIDTxt.Size = new System.Drawing.Size(210, 22);
			this.userIDTxt.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(106, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Last Name:";
			// 
			// lastnameTxt
			// 
			this.lastnameTxt.Location = new System.Drawing.Point(192, 164);
			this.lastnameTxt.Name = "lastnameTxt";
			this.lastnameTxt.Size = new System.Drawing.Size(210, 22);
			this.lastnameTxt.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 33);
			this.button1.TabIndex = 6;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Enter your password:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(61, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Confirm Password:";
			// 
			// passwordTxt
			// 
			this.passwordTxt.Location = new System.Drawing.Point(192, 206);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(210, 22);
			this.passwordTxt.TabIndex = 9;
			// 
			// confirmPassTxt
			// 
			this.confirmPassTxt.Location = new System.Drawing.Point(193, 246);
			this.confirmPassTxt.Name = "confirmPassTxt";
			this.confirmPassTxt.Size = new System.Drawing.Size(209, 22);
			this.confirmPassTxt.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(306, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 65);
			this.button2.TabIndex = 11;
			this.button2.Text = "Enter and Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(50, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Entery Employee ID:";
			// 
			// firstnameTxt
			// 
			this.firstnameTxt.Location = new System.Drawing.Point(192, 125);
			this.firstnameTxt.Name = "firstnameTxt";
			this.firstnameTxt.Size = new System.Drawing.Size(210, 22);
			this.firstnameTxt.TabIndex = 13;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(499, 403);
			this.Controls.Add(this.firstnameTxt);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.confirmPassTxt);
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lastnameTxt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.userIDTxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form2";
			this.Text = "Sign Up";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox userIDTxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox lastnameTxt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.TextBox confirmPassTxt;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox firstnameTxt;
	}
}