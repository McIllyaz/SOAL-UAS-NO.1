using System.Drawing;

namespace uas4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bangunruang[] bangunruang = new Bangunruang[5];
            bangunruang[0] = new Persegi();
            bangunruang[1] = new PersegiPanjang();
            bangunruang[2] = new Lingkaran();
            bangunruang[3] = new Segitiga();
            bangunruang[4] = new Trapesium();

            while (true)
            {
                Console.WriteLine("========================");
                Console.WriteLine("HITUNG LUAS BANGUN RUANG");
                Console.WriteLine("========================");
                Console.WriteLine("1. VOLUME KUBUS");
                Console.WriteLine("2. VOLUME BALOK");
                Console.WriteLine("3. VOLUME KERUCUT");
                Console.WriteLine("4. VOLUME TABUNG");
                Console.WriteLine("5. VOLUME LIMAS");
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

                        ((Persegi)bangunruang[0]).SISI = sisi;
                        double luaspersegi = bangunruang[0].HitungArea();
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

                        ((PersegiPanjang)bangunruang[1]).PANJANG = panjang;
                        ((PersegiPanjang)bangunruang[1]).LEBAR = lebar;
                        double luaspersegipanjang = bangunruang[1].HitungArea();
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

                        ((Lingkaran)bangunruang[2]).JARI_JARI = jari_jari;
                        double luaslingkaran = bangunruang[2].HitungArea();
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

                        ((Segitiga)bangunruang[3]).ALAS = alas;
                        ((Segitiga)bangunruang[3]).TINGGI = tinggi;
                        double luassegitiga = bangunruang[3].HitungArea();
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

                        ((Trapesium)bangunruang[4]).SISIA = sisia;
                        ((Trapesium)bangunruang[4]).SISIB = sisib;
                        ((Trapesium)bangunruang[4]).TINGGI = tinggitrapesium;
                        double luastrapesium = bangunruang[4].HitungArea();
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