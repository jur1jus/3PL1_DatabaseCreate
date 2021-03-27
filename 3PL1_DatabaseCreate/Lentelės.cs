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
		public Lentelės()
		{
			InitializeComponent();
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
	}
}
