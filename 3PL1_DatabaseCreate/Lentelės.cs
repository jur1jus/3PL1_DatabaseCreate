using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PL1_DatabaseCreate
{
	public partial class Lentelės : Form
	{
		private List<Laukas> _laukai;

		public Lentelės()
		{
			InitializeComponent();

			_laukai = new List<Laukas>();
		}

		private void cmbxLaukoTipas_SelectedIndexChanged(object sender, EventArgs e)
		{
			var duomenųTipai = new List<string>() { "varchar" };
			var value = ((ComboBox)sender).SelectedItem.ToString();

			if (!string.IsNullOrWhiteSpace(value) && duomenųTipai.Contains(value)) {
				txtLaukoIlgis.Show();
			} else {
				txtLaukoIlgis.Clear();
				txtLaukoIlgis.Hide();
			}
		}

		private void btnPridėti_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtLaukoPavadinimas.Text)) {
				MessageBox.Show("Nenurodytas lauko pavadinimas.");
				return;
			}

			if (string.IsNullOrEmpty(cmbxLaukoTipas.SelectedItem.ToString())) {
				MessageBox.Show("Nenurodytas lauko tipas.");
				return;
			}

			var laukas = new Laukas(txtLaukoPavadinimas.Text, cmbxLaukoTipas.SelectedItem.ToString(), txtLaukoIlgis.Text, chxPirminisRaktas.Checked);
			_laukai.Add(laukas);
			listBoxLaukai.Items.Add(laukas);
		}

		private void btnGeneruoti_Click(object sender, EventArgs e)
		{
			if (_laukai.Any() && !_laukai.Any(m => m.ArPirminisRaktas)) {
				MessageBox.Show("Lentelė turi turėti priminį raktą.");
				return;
			}

			Random random = new Random();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"CREATE TABLE Test{random.Next(1, 100000)} (");
			//CREATE TABLE Test44545457 (

			foreach (var laukas in _laukai) {
				var pridėdamasLaukas = GeneruokLauką(laukas);

				if (string.IsNullOrEmpty(pridėdamasLaukas)) continue;

				stringBuilder.AppendLine(pridėdamasLaukas);
			}

			var priminiaiRaktai = _laukai.Where(m => m.ArPirminisRaktas).ToList();
			var pirminisRaktas = GeneruokPirminįRaktą(priminiaiRaktai);

			stringBuilder.AppendLine(pirminisRaktas);
			stringBuilder.AppendLine(")");

			var lentelė = stringBuilder.ToString();
			ScriptoPeržiūra scriptoPeržiūra = new ScriptoPeržiūra(lentelė);
			scriptoPeržiūra.ShowDialog();
		}

		private string GeneruokPirminįRaktą(List<Laukas> laukai)
		{
			var pirminisRaktasStringBuilder = new StringBuilder();
			pirminisRaktasStringBuilder.Append("\tPRIMARY KEY (");

			var prLaukai = "";
			foreach (var laukas in laukai) {
				prLaukai += $"{laukas.LaukoPavadinimas}, ";
			}
			prLaukai = prLaukai.TrimEnd(',', ' ');

			pirminisRaktasStringBuilder.Append(prLaukai);
			pirminisRaktasStringBuilder.Append(")");

			return pirminisRaktasStringBuilder.ToString();
		}

		private string GeneruokLauką(Laukas laukas)
		{
			switch (laukas.DuomenųTipas) {
				case "int":
				case "double":
				case "datetime":
				case "bool": return $"\t{laukas.LaukoPavadinimas} {laukas.DuomenųTipas},";
				case "varchar": {
						if (string.IsNullOrEmpty(laukas.Ilgis))
							return $"\t{laukas.LaukoPavadinimas} {laukas.DuomenųTipas}(255),";

						return $"\t{laukas.LaukoPavadinimas} {laukas.DuomenųTipas}({laukas.Ilgis}),";
					}
				default:
					return null;
			}
		}

	}
}
