using System.Drawing;

namespace uas5
{
    public class Program
    {
        static void Main(string[] args)
        {
            BangunRuang[] bangunruang = new BangunRuang[5];
            bangunruang[0] = new Kubus();
            bangunruang[1] = new Balok();
            bangunruang[2] = new Kerucut();
            bangunruang[3] = new Tabung();
            bangunruang[4] = new Limas();

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

                        ((Kubus)bangunruang[0]).SISI = sisi;
                        double volumekubus = bangunruang[0].HitungVolume();
                        Console.WriteLine("========================");
                        Console.WriteLine("VOLUME\t: " + volumekubus);
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
                        Console.Write("Tinggi\t: ");
                        double tinggibalok = Convert.ToDouble(Console.ReadLine());

                        ((Balok)bangunruang[1]).PANJANG = panjang;
                        ((Balok)bangunruang[1]).LEBAR = lebar;
                        ((Balok)bangunruang[1]).TINGGI = tinggibalok;
                        double volumebalok = bangunruang[1].HitungVolume();
                        Console.WriteLine("========================");
                        Console.WriteLine("VOLUME\t: " + volumebalok);
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
                        double jari_jarikerucut = Convert.ToDouble(Console.ReadLine());
                        Console.Write("TINNGI\t\t: ");
                        double tinggikerucut = Convert.ToDouble(Console.ReadLine());

                        ((Kerucut)bangunruang[2]).JARI_JARI = jari_jarikerucut;
                        ((Kerucut)bangunruang[2]).TINGGI = tinggikerucut;
                        double volumekerucut = bangunruang[2].HitungVolume();
                        Console.WriteLine("========================");
                        Console.WriteLine("VOLUME\t: " + volumekerucut);
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
                        Console.Write("JARI-JARI\t: ");
                        double jari_jaritabung = Convert.ToDouble(Console.ReadLine());
                        Console.Write("TINGGI\t\t: ");
                        double tinggitabung = Convert.ToDouble(Console.ReadLine());

                        ((Tabung)bangunruang[3]).JARI_JARI = jari_jaritabung;
                        ((Tabung)bangunruang[3]).TINGGI = tinggitabung;
                        double volumetabung = bangunruang[3].HitungVolume();
                        Console.WriteLine("========================");
                        Console.WriteLine("VOLUME\t: " + volumetabung);
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
                        Console.Write("SISI\t: ");
                        double sisilimas = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Tinggi\t: ");
                        double tinggitrapesium = Convert.ToDouble(Console.ReadLine());

                        ((Limas)bangunruang[4]).SISI = sisilimas;
                        ((Limas)bangunruang[4]).TINGGI = tinggitrapesium;
                        double volumelimas = bangunruang[4].HitungVolume();
                        Console.WriteLine("========================");
                        Console.WriteLine("VOLUME\t: " + volumelimas);
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