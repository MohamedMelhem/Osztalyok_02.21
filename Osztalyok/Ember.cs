using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
	internal class Ember
	{
		private string nev;
		private int kor;



		public string Nev
		{
			get { return nev; }
			set { nev = value; }
		}

		public Ember(string nev)
		{
			this.nev = nev;
		}

		public void Futas()
		{
			Console.WriteLine("Futok");

		}







	}
}
