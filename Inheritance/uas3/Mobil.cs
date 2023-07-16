using System;
namespace uas3
{
	public class Mobil
	{
		public string Merk { get; set; }
		public string Model { get; set; }

		public void DataMobil()
		{
			Console.WriteLine("======================");
            Console.WriteLine("      Data Mobil");
            Console.WriteLine("======================");

            Console.WriteLine("Merk\t: {0}", Merk);
            Console.WriteLine("Model\t: {0}", Model);
        }
	}
}

