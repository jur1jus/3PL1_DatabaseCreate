
namespace _3PL1_DatabaseCreate
{
	partial class Lentelės
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
			this.txtLaukoPavadinimas = new System.Windows.Forms.TextBox();
			this.cmbxLaukoTipas = new System.Windows.Forms.ComboBox();
			this.listBoxLaukai = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPridėti = new System.Windows.Forms.Button();
			this.chxPirminisRaktas = new System.Windows.Forms.CheckBox();
			this.txtLaukoIlgis = new System.Windows.Forms.TextBox();
			this.btnGeneruoti = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLentelėsPavadinimas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtLaukoPavadinimas
			// 
			this.txtLaukoPavadinimas.Location = new System.Drawing.Point(124, 48);
			this.txtLaukoPavadinimas.Name = "txtLaukoPavadinimas";
			this.txtLaukoPavadinimas.Size = new System.Drawing.Size(121, 20);
			this.txtLaukoPavadinimas.TabIndex = 0;
			// 
			// cmbxLaukoTipas
			// 
			this.cmbxLaukoTipas.FormattingEnabled = true;
			this.cmbxLaukoTipas.Items.AddRange(new object[] {
            "",
            "int",
            "double",
            "varchar",
            "bool",
            "datetime"});
			this.cmbxLaukoTipas.Location = new System.Drawing.Point(124, 74);
			this.cmbxLaukoTipas.Name = "cmbxLaukoTipas";
			this.cmbxLaukoTipas.Size = new System.Drawing.Size(121, 21);
			this.cmbxLaukoTipas.TabIndex = 1;
			this.cmbxLaukoTipas.SelectedIndexChanged += new System.EventHandler(this.cmbxLaukoTipas_SelectedIndexChanged);
			// 
			// listBoxLaukai
			// 
			this.listBoxLaukai.FormattingEnabled = true;
			this.listBoxLaukai.Location = new System.Drawing.Point(12, 152);
			this.listBoxLaukai.Name = "listBoxLaukai";
			this.listBoxLaukai.Size = new System.Drawing.Size(275, 290);
			this.listBoxLaukai.TabIndex = 2;
			this.listBoxLaukai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxLaukai_KeyPress);
			this.listBoxLaukai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxLaukai_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Lauko pavadinimas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Lauko tipas";
			// 
			// btnPridėti
			// 
			this.btnPridėti.Location = new System.Drawing.Point(124, 123);
			this.btnPridėti.Name = "btnPridėti";
			this.btnPridėti.Size = new System.Drawing.Size(75, 23);
			this.btnPridėti.TabIndex = 5;
			this.btnPridėti.Text = "Pridėti";
			this.btnPridėti.UseVisualStyleBackColor = true;
			this.btnPridėti.Click += new System.EventHandler(this.btnPridėti_Click);
			// 
			// chxPirminisRaktas
			// 
			this.chxPirminisRaktas.AutoSize = true;
			this.chxPirminisRaktas.Location = new System.Drawing.Point(124, 101);
			this.chxPirminisRaktas.Name = "chxPirminisRaktas";
			this.chxPirminisRaktas.Size = new System.Drawing.Size(105, 17);
			this.chxPirminisRaktas.TabIndex = 6;
			this.chxPirminisRaktas.Text = "Ar priminis raktas";
			this.chxPirminisRaktas.UseVisualStyleBackColor = true;
			// 
			// txtLaukoIlgis
			// 
			this.txtLaukoIlgis.Location = new System.Drawing.Point(251, 74);
			this.txtLaukoIlgis.Name = "txtLaukoIlgis";
			this.txtLaukoIlgis.Size = new System.Drawing.Size(31, 20);
			this.txtLaukoIlgis.TabIndex = 7;
			this.txtLaukoIlgis.Visible = false;
			// 
			// btnGeneruoti
			// 
			this.btnGeneruoti.Location = new System.Drawing.Point(12, 470);
			this.btnGeneruoti.Name = "btnGeneruoti";
			this.btnGeneruoti.Size = new System.Drawing.Size(275, 23);
			this.btnGeneruoti.TabIndex = 8;
			this.btnGeneruoti.Text = "Generuoti";
			this.btnGeneruoti.UseVisualStyleBackColor = true;
			this.btnGeneruoti.Click += new System.EventHandler(this.btnGeneruoti_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Lentelės pavadinimas";
			// 
			// txtLentelėsPavadinimas
			// 
			this.txtLentelėsPavadinimas.Location = new System.Drawing.Point(124, 19);
			this.txtLentelėsPavadinimas.Name = "txtLentelėsPavadinimas";
			this.txtLentelėsPavadinimas.Size = new System.Drawing.Size(121, 20);
			this.txtLentelėsPavadinimas.TabIndex = 10;
			// 
			// Lentelės
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 550);
			this.Controls.Add(this.txtLentelėsPavadinimas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGeneruoti);
			this.Controls.Add(this.txtLaukoIlgis);
			this.Controls.Add(this.chxPirminisRaktas);
			this.Controls.Add(this.btnPridėti);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxLaukai);
			this.Controls.Add(this.cmbxLaukoTipas);
			this.Controls.Add(this.txtLaukoPavadinimas);
			this.Name = "Lentelės";
			this.Text = "Lentelės";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLaukoPavadinimas;
		private System.Windows.Forms.ComboBox cmbxLaukoTipas;
		private System.Windows.Forms.ListBox listBoxLaukai;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnPridėti;
		private System.Windows.Forms.CheckBox chxPirminisRaktas;
		private System.Windows.Forms.TextBox txtLaukoIlgis;
		private System.Windows.Forms.Button btnGeneruoti;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLentelėsPavadinimas;
	}
}