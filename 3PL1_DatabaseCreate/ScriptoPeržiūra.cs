using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3PL1_DatabaseCreate
{
	public partial class ScriptoPeržiūra : Form
	{
		private string _scriptas;
		public ScriptoPeržiūra(string scriptas)
		{
			InitializeComponent();
			_scriptas = scriptas;
			textBox1.Text = _scriptas;
		}

		private void btnPatvritinti_Click(object sender, EventArgs e)
		{
			var connectioString = ConfigurationManager.ConnectionStrings["DbGenerator"].ConnectionString;

			using (MySqlConnection connection = new MySqlConnection(connectioString)) {
				using (MySqlCommand command = new MySqlCommand(null, connection)) {
					try {
						connection.Open();
						command.CommandText = _scriptas;
						command.ExecuteNonQuery();
					} catch (Exception ex) {
						MessageBox.Show($"Įvyko klaida!{Environment.NewLine}{ex.Message}");
					} finally {
						connection.Close();
					}
				}
			}
		}
	}
}
