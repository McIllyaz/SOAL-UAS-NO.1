using System.Drawing;

namespace uas4
{
    public class Program
    {
        static void Main(string[] args)
        {
            BangunDatar[] bangundatar = new BangunDatar[5];
            bangundatar[0] = new Persegi();
            bangundatar[1] = new PersegiPanjang();
            bangundatar[2] = new Lingkaran();
            bangundatar[3] = new Segitiga();
            bangundatar[4] = new Trapesium();

            while (true)
            {
                Console.WriteLine("========================");
                Console.WriteLine("HITUNG LUAS BANGUN DATAR");
                Console.WriteLine("========================");
                Console.WriteLine("1. LUAS PERSEGI");
                Console.WriteLine("2. LUAS PERSEGI PANJANG");
                Console.WriteLine("3. LUAS LINGKARAN");
                Console.WriteLine("4. LUAS SEGITIGA");
                Console.WriteLine("5. TRAPESIUM");
                Console.WriteLine("6. KELUAR");
                Console.WriteLine("========================");
                Console.Write("PILIHAN ANDA [1..6] : ");
                int pilihmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihmenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("========================");
                        Console.WriteLine("ISI DATA YANG DIBUTUHKAN");
                        Console.WriteLine("========================");
                        Console.Write("SISI\t: ");
                        double sisi = Convert.ToDouble(Console.ReadLine());

                        ((Persegi)bangundatar[0]).SISI = sisi;
                        double luaspersegi = bangundatar[0].HitungArea();
                        Console.WriteLine("========================");
                        Console.WriteLine("LUAS\t: " + luaspersegi);
                        Console.WriteLine("");
                        Console.WriteLine("TEKAN ENTER UNTUK KEMBALI");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("========================");
                        Console.WriteLine("ISI DATA YANG DIBUTUHKAN");
                        Console.WriteLine("========================");
                        Console.Write("PANJANG\t: ");
                        double panjang = Convert.ToDouble(Console.ReadLine());
                        Console.Write("LEBAR\t: ");
                        double lebar = Convert.ToDouble(Console.ReadLine());

                        ((PersegiPanjang)bangundatar[1]).PANJANG = panjang;
                        ((PersegiPanjang)bangundatar[1]).LEBAR = lebar;
                        double luaspersegipanjang = bangundatar[1].HitungArea();
                        Console.WriteLine("========================");
                        Console.WriteLine("LUAS\t: " + luaspersegipanjang);
                        Console.WriteLine("");
                        Console.WriteLine("TEKAN ENTER UNTUK KEMBALI");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("========================");
                        Console.WriteLine("ISI DATA YANG DIBUTUHKAN");
                        Console.WriteLine("========================");
                        Console.Write("JARI-JARI\t: ");
                        double jari_jari = Convert.ToDouble(Console.ReadLine());

                        ((Lingkaran)bangundatar[2]).JARI_JARI = jari_jari;
                        double luaslingkaran = bangundatar[2].HitungArea();
                        Console.WriteLine("========================");
                        Console.WriteLine("LUAS\t: " + luaslingkaran);
                        Console.WriteLine("");
                        Console.WriteLine("TEKAN ENTER UNTUK KEMBALI");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("========================");
                        Console.WriteLine("ISI DATA YANG DIBUTUHKAN");
                        Console.WriteLine("========================");
                        Console.Write("ALAS\t: ");
                        double alas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("TINNGI\t: ");
                        double tinggi = Convert.ToDouble(Console.ReadLine());

                        ((Segitiga)bangundatar[3]).ALAS = alas;
                        ((Segitiga)bangundatar[3]).TINGGI = tinggi;
                        double luassegitiga = bangundatar[3].HitungArea();
                        Console.WriteLine("========================");
                        Console.WriteLine("LUAS\t: " + luassegitiga);
                        Console.WriteLine("");
                        Console.WriteLine("TEKAN ENTER UNTUK KEMBALI");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("========================");
                        Console.WriteLine("ISI DATA YANG DIBUTUHKAN");
                        Console.WriteLine("========================");
                        Console.Write("SISI A\t: ");
                        double sisia = Convert.ToDouble(Console.ReadLine());
                        Console.Write("SISI B\t: ");
                        double sisib = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tinggi\t: ");
                        double tinggitrapesium= Convert.ToDouble(Console.ReadLine());

                        ((Trapesium)bangundatar[4]).SISIA = sisia;
                        ((Trapesium)bangundatar[4]).SISIB = sisib;
                        ((Trapesium)bangundatar[4]).TINGGI = tinggitrapesium;
                        double luastrapesium = bangundatar[4].HitungArea();
                        Console.WriteLine("========================");
                        Console.WriteLine("LUAS\t: " + luastrapesium);
                        Console.WriteLine("");
                        Console.WriteLine("TEKAN ENTER UNTUK KEMBALI");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}