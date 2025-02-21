namespace Osztalyok
{
	internal class Program
	{
		static void Main(string[] args)
		{
		Cicaa cicaa = new Cicaa("Cirmi", 3, "Perzsa", 5, "Fekete", 10, 10, "Nőstény");
		Cicaa Milo = new Cicaa("Milo", 2, "Bengál", 4, "Fekete", 10, 10, "Hím");
		Cicaa cicamica = new Cicaa("Felhö",18,"Vadmacska",10,"narancs",88,5,"Hím");
		Cicaa Urbal = new Cicaa("Urbal",10,"Vadmacska",8,"szürke",50,5,"Hím");

        Console.WriteLine("A macskák Besorolása Elkezdödött");
            List<Cicaa> cicak = new List<Cicaa>();
		cicak.Add(cicaa);
		cicak.Add(Milo);
		cicak.Add(cicamica);
		cicak.Add(Urbal);

            for (int i = 0; i < cicak.Count; i++)
            {
				cicak[i].FajBeSorolas();
                
            }
            for (int i = 0; i < cicak.Count; i++)
            {
				Console.WriteLine(cicak[i]);

            }


       Milo.Jatek();
		cicamica.RomlottKaja();
		cicaa.Eves(0.2);
        Console.WriteLine(Urbal);
		Urbal.Alvas();
        Console.WriteLine(Urbal);
        }
	}
}
