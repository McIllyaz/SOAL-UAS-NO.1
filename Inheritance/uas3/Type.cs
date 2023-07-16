using System;
namespace uas3
{
	public class Type : Mobil
	{
		public string TipeMobil;
		public string TipeMesin;
		public string Penggerak;

		public void Chasis()
		{
            Console.WriteLine("Tipe\t: {0}", TipeMobil);
            Console.WriteLine("Mesin\t: {0}", TipeMesin);
            Console.WriteLine("Penggerak {0}", Penggerak);
            Console.WriteLine("=====================");
        }
	}
}

