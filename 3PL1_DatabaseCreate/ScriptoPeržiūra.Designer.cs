
namespace _3PL1_DatabaseCreate
{
	partial class ScriptoPeržiūra
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnPatvritinti = new System.Windows.Forms.Button();
			this.btnGrįžti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(362, 335);
			this.textBox1.TabIndex = 0;
			// 
			// btnPatvritinti
			// 
			this.btnPatvritinti.Location = new System.Drawing.Point(13, 354);
			this.btnPatvritinti.Name = "btnPatvritinti";
			this.btnPatvritinti.Size = new System.Drawing.Size(362, 23);
			this.btnPatvritinti.TabIndex = 1;
			this.btnPatvritinti.Text = "Patvirtinti";
			this.btnPatvritinti.UseVisualStyleBackColor = true;
			this.btnPatvritinti.Click += new System.EventHandler(this.btnPatvritinti_Click);
			// 
			// btnGrįžti
			// 
			this.btnGrįžti.Location = new System.Drawing.Point(13, 384);
			this.btnGrįžti.Name = "btnGrįžti";
			this.btnGrįžti.Size = new System.Drawing.Size(362, 23);
			this.btnGrįžti.TabIndex = 2;
			this.btnGrįžti.Text = "Grįžti";
			this.btnGrįžti.UseVisualStyleBackColor = true;
			// 
			// ScriptoPeržiūra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 442);
			this.Controls.Add(this.btnGrįžti);
			this.Controls.Add(this.btnPatvritinti);
			this.Controls.Add(this.textBox1);
			this.Name = "ScriptoPeržiūra";
			this.Text = "ScriptoPeržiūra";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnPatvritinti;
		private System.Windows.Forms.Button btnGrįžti;
	}
}