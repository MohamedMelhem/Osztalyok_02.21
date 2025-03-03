﻿using System;
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
                Console.WriteLine($"A  {nev} macska meglett mérgezve");
                szin = "zöld";
				suly -= (int)(suly * (esely / 100.0));
				rendetlensegSzint /= 2;

			}
			else
			{
                Console.WriteLine($"A {nev} macska egy Finomat Evett MEOWW");
                suly += (int)Math.Ceiling(fogyasztas * kajasuly);
			}


		}
		public void Alvas()
		{
            Console.WriteLine($"{nev} Elaludt ");
            rendetlensegSzint = 0;
			if (szin == "zöld")
			{
				szin = "Eredeti";

			}

		}
		public void Ebredes()
		{
            Console.WriteLine($"{nev} Felébredtt");
            rendetlensegSzint = 100;
			ehes = true;
		}
		public void Jatek()
		{
			List<string> tevekenysegek = new List<string> { "ugral", "kapar", "rohan", "futkarozik","nyavog","zuz","tollal jatszik","cérnázik" };
			Random random = new Random();
			string tevekenyseg = "";
            if (0 <= rendetlensegSzint && rendetlensegSzint <= 30)
            {
				tevekenyseg = tevekenysegek[random.Next(0, tevekenysegek.Count-3)];
                Console.WriteLine($" {nev} éppen {tevekenyseg}");

            }
            if (30 <=  rendetlensegSzint && rendetlensegSzint < 60)
            {
                tevekenyseg = tevekenysegek[random.Next(0, tevekenysegek.Count-2)];
				Console.WriteLine($" {nev} éppen {tevekenyseg}");
			}
			if (60 <= rendetlensegSzint && rendetlensegSzint < 90)
			{
				tevekenyseg = tevekenysegek[random.Next(0, tevekenysegek.Count - 1)];
				Console.WriteLine($" {nev} éppen {tevekenyseg}");
			}
			if (90 <= rendetlensegSzint )
			{
				tevekenyseg = tevekenysegek[random.Next(0, tevekenysegek.Count)];
				Console.WriteLine($" {nev} éppen {tevekenyseg}");
			}

		}
		public void RomlottKaja()
		{
            Console.WriteLine($"A {this.nev} Nevu Macska Romlott Kaját evett, nézzuk mi lett vele ");
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

		public override string? ToString()
		{
			return $" Macska neve : {nev} Életkora : {kor} Fajtája : {fajta} Suly : {suly} Szine : {szin}  Rendetlensege : {rendetlensegSzint}  Éhes : {ehes} SEX : {nem}" ;
		}
	}
	
}

