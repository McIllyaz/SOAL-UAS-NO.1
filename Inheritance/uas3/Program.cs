using System;
using System.Runtime.ConstrainedExecution;

namespace uas3 
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tipe = null;
            Mobil myCar = new Mobil();
            Type Cartype = new Type();

            while (true)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("    MENU DATA MOBIL");
                Console.WriteLine("=======================");
                Console.WriteLine("1. ISI DATA MOBIL");
                Console.WriteLine("2. LIHAT DATA MOBIL");
                Console.WriteLine("3. KELUAR");
                Console.WriteLine("========================");
                int pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Merk\t\t: ");
                        string merk = Console.ReadLine();

                        Console.Write("Nama Model\t: ");
                        string model = Console.ReadLine();

                        Console.WriteLine("=======================");
                        Console.WriteLine("Tipe : ");
                        Console.WriteLine("1. SUV");
                        Console.WriteLine("2. MPV");
                        Console.WriteLine("3. LCGC");
                        Console.WriteLine("=======================");
                        Console.Write("Pilihan anda [1..3] : ");
                        int pilihantipe = Convert.ToInt32(Console.ReadLine());

                        if (pilihantipe == 1)
                        {
                            tipe = "SUV";
                        }
                        else if (pilihantipe == 2)
                        {
                            tipe = "MPV";
                        }
                        else if (pilihantipe == 3)
                        {
                            tipe = "LCGC";
                        }

                        Console.Write("Tipe Mesin\t: ");
                        string mesin = Console.ReadLine();

                        Console.Write("Penggerak\t: ");
                        string penggerak = Console.ReadLine();

                        myCar.Merk = merk;
                        myCar.Model = model;
                        Cartype.TipeMobil = tipe;
                        Cartype.TipeMesin = mesin;
                        Cartype.Penggerak = penggerak;

                        Console.WriteLine("Tekan sembarang tombol untuk keluar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        myCar.DataMobil();
                        Cartype.Chasis();

                        Console.WriteLine("Tekan sembarang tombol untuk keluar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}