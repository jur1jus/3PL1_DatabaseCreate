namespace _3PL1_DatabaseCreate
{
	public class Laukas
	{
		public string LaukoPavadinimas { get; set; }

		public string DuomenųTipas { get; set; }

		public string Ilgis { get; set; }

		public bool ArPirminisRaktas { get; set; }

		public Laukas(string laukoPavadinimas, string duomenųTipas, bool arPirminisRaktas)
		{
			LaukoPavadinimas = laukoPavadinimas;
			DuomenųTipas = duomenųTipas;
			ArPirminisRaktas = arPirminisRaktas;
		}

		public Laukas(string laukoPavadinimas, string duomenųTipas, string ilgis, bool arPirminisRaktas)
		{
			LaukoPavadinimas = laukoPavadinimas;
			DuomenųTipas = duomenųTipas;
			Ilgis = ilgis;
			ArPirminisRaktas = arPirminisRaktas;
		}

		public override string ToString()
		{
			return $"{LaukoPavadinimas} {DuomenųTipas} {Ilgis} Ar pirminis: {ArPirminisRaktas}";
		}
	}
}
