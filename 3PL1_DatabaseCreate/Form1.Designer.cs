﻿
namespace _3PL1_DatabaseCreate
{
	partial class Form1
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
			if (disposing && (components != null)) {
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
			this.btnLenteliųKūrimas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLenteliųKūrimas
			// 
			this.btnLenteliųKūrimas.Location = new System.Drawing.Point(12, 12);
			this.btnLenteliųKūrimas.Name = "btnLenteliųKūrimas";
			this.btnLenteliųKūrimas.Size = new System.Drawing.Size(144, 23);
			this.btnLenteliųKūrimas.TabIndex = 0;
			this.btnLenteliųKūrimas.Text = "Lentelių kūrimas";
			this.btnLenteliųKūrimas.UseVisualStyleBackColor = true;
			this.btnLenteliųKūrimas.Click += new System.EventHandler(this.btnLenteliųKūrimas_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 339);
			this.Controls.Add(this.btnLenteliųKūrimas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLenteliųKūrimas;
	}
}

