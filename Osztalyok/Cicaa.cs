using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
	internal class Cicaa
	{
		private string nev;
		int kor;
		string fajta;
		int suly;
		string szin;
		int rendetlensegSzint;
		int fogyasztas;
		bool ehes;
		string nem;

		public Cicaa(string nev, int kor, string fajta, int suly, string szin, int rendetlensegSzint, int fogyasztas, string nem)
		{
			this.nev = nev;
			this.kor = kor;
			this.fajta = fajta;
			this.suly = suly;
			this.szin = szin;
			this.rendetlensegSzint = rendetlensegSzint;
			this.fogyasztas = fogyasztas;
			ehes = true;
			this.nem = nem;
		}

		public void Eves(double kajasuly)
		{
			int esely = new Random().Next(0, 101);

			ehes = false;


			if (esely < 4)
			{
				szin = "zöld";
				suly -= (int)(suly * (esely / 100.0));
				rendetlensegSzint /= 2;

			}
			else
			{
				suly += (int)Math.Ceiling(fogyasztas * kajasuly);
			}


		}
		public void Alvas()
		{
			rendetlensegSzint = 0;
			if (szin == "zöld")
			{
				szin = "Eredeti";

			}

		}
		public void Ebredes()
		{
			rendetlensegSzint = 100;
			ehes = true;
		}
		public void Jatek()
		{ }

		public void RomlottKaja()
		{
            Console.WriteLine($"A {this.nev} Nevu Macska Romlott Kaját evett ");
            Eves(0.1);
		}
		public void EnergiaSzint()
		{
			if (0 <= kor && kor <= 10)
			{
				rendetlensegSzint = rendetlensegSzint * 1;
			}
			else if (10 < kor && kor <= 20)
			{
				rendetlensegSzint = rendetlensegSzint / 2;

			}
            else
            {
                rendetlensegSzint = rendetlensegSzint / 4;
            }


        }
		public void FajBeSorolas()
		{
            if (szin == "narancs")
            {
                rendetlensegSzint = rendetlensegSzint * 2;
            }
            if (szin == "fekete")
            {
				fogyasztas += 1;
            }
        }

	}
	
}

