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
	public partial class ScriptoPeržiūra : Form
	{
		private string _scriptas;
		public ScriptoPeržiūra(string scriptas)
		{
			InitializeComponent();
			_scriptas = scriptas;
			textBox1.Text = _scriptas;
		}
	}
}
