using MySql.Data.MySqlClient;
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

namespace _3PL1_DatabaseCreate
{
	public partial class IšorinisRaktas : Form
	{
		private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DbGenerator"].ConnectionString;

		public IšorinisRaktas()
		{
			InitializeComponent();
			KonfiguruokListBoxus();
			var lentelės = GaukLenteles();
			UžpildykLenteliųListBoxus(lentelės);
		}

		private void KonfiguruokListBoxus()
		{
			listBoxPirmosLentelėsLaukai.DisplayMember = "LaukoPavadinimas";
			listBoxAntrosLentelėsLaukai.DisplayMember = "LaukoPavadinimas";
		}

		private void UžpildykLenteliųListBoxus(List<string> lentelės)
		{
			listBoxPirmaLentelė.Items.AddRange(lentelės.ToArray());
			listBoxAntraLentelė.Items.AddRange(lentelės.ToArray());
		}


		private List<string> GaukLenteles()
		{
			var rezultatas = new List<string>();

			using (MySqlConnection connection = new MySqlConnection(_connectionString)) {
				using (MySqlCommand command = new MySqlCommand("SHOW TABLES", connection)) {
					try {
						connection.Open();
						var reader = command.ExecuteReader();

						while (reader.Read()) {
							rezultatas.Add(reader.GetString(0));
						}

					} catch (Exception ex) {
						MessageBox.Show($"Įvyko klaida!{Environment.NewLine}{ex.Message}");
					} finally {
						connection.Close();
					}
				}
			}

			return rezultatas;
		}

		private List<Laukas> GaukLentelėsLaukus(string lentelėsPavadinimas)
		{
			var rezultatas = new List<Laukas>();

			using (MySqlConnection connection = new MySqlConnection(_connectionString)) {
				using (MySqlCommand command = new MySqlCommand($"DESCRIBE {lentelėsPavadinimas}", connection)) {
					try {
						connection.Open();

						var reader = command.ExecuteReader();

						while (reader.Read()) {
							var laukas = new Laukas(reader.GetString("Field"), reader.GetString("Type"), string.IsNullOrEmpty(reader.GetString("Key")) ? false : true);

							rezultatas.Add(laukas);
						}

					} catch (Exception ex) {
						MessageBox.Show($"Įvyko klaida!{Environment.NewLine}{ex.Message}");
					} finally {
						connection.Close();
					}
				}
			}

			return rezultatas;
		}

		private void listBoxPirmaLentelė_SelectedIndexChanged(object sender, EventArgs e)
		{
			var lentelėsPavadinimas = ((ListBox)sender).SelectedItem.ToString();

			var laukai = GaukLentelėsLaukus(lentelėsPavadinimas);
			

			listBoxPirmosLentelėsLaukai.Items.Clear();
			listBoxPirmosLentelėsLaukai.Items.AddRange(laukai.ToArray());
		}

		private void listBoxAntraLentelė_SelectedIndexChanged(object sender, EventArgs e)
		{
			var lentelėsPavadinimas = ((ListBox)sender).SelectedItem.ToString();

			var laukai = GaukLentelėsLaukus(lentelėsPavadinimas);


			listBoxAntrosLentelėsLaukai.Items.Clear();
			listBoxAntrosLentelėsLaukai.Items.AddRange(laukai.ToArray());
		}
	}
}
