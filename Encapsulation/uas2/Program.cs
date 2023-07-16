using System;

namespace uas2 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(); // Buat objek Data di sini
            string saku = null;

            while (true)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("  \tMENU DATA DIRI");
                Console.WriteLine("====================================");

                Console.WriteLine("1. ISI DATA DIRI");
                Console.WriteLine("2. LIHAT DATA DIRI");
                Console.WriteLine("3. KELUAR");
                Console.WriteLine("====================================");
                int pilih = Convert.ToInt32(Console.ReadLine());

                switch (pilih)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Nama\t\t: ");
                        string nama = Console.ReadLine();

                        Console.Write("Umur\t\t: ");
                        int umur = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Pekerjaan\t: ");
                        string pekerjaan = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("====================================");
                        Console.WriteLine("Uang saku :\n1. 0 - 1.000.000\n2. 1.000.000 - 2.000.000\n3. > 2.000.000");
                        Console.WriteLine("====================================");
                        Console.Write("Pilihan anda : ");
                        int pilihan = Convert.ToInt32(Console.ReadLine());

                        if (pilihan == 1)
                        {
                            saku = "0 - 1.000.000";
                        }else if (pilihan == 2)
                        {
                            saku = "1.000.000 - 2.000.000";
                        }
                        else if (pilihan == 3)
                        {
                            saku = "Lebih dari 2.000.000";
                        }

                        data.Nama = nama;
                        data.Umur = umur;
                        data.Pekerjaan = pekerjaan;
                        data.Saku = saku;

                        Console.WriteLine();
                        Console.WriteLine("Data telah terinput\nTekan sembarang tombol untuk kembali ke menu..");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        data.TampilanDataDiri();
                        break;
                    case 3:
                        Console.WriteLine("Terima kasih telah menggunakan program ini.");
                        Console.WriteLine("Tekan sembarang tombol untuk keluar...");
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }
            }
        }
    }
}