using System;
namespace uas2
{
	public class Data
	{
		private string NAMA;
        protected int UMUR;
		internal string PEKERJAAN;
        private string SAKU;

		public string Nama
		{
			get { return NAMA; }
			set { NAMA = value; }
		}

        public int Umur
        {
            get { return UMUR; }
            set { UMUR = value; }
        }

        public string Pekerjaan
        {
            get { return PEKERJAAN; }
            set { PEKERJAAN = value; }
        }

        public string Saku
        {
            get { return SAKU; }
            set { SAKU = value; }
        }

        public void TampilanDataDiri()
		{
            Console.WriteLine("======================================");
            Console.WriteLine("\tDATA DIRI");
            Console.WriteLine("======================================");
            Console.WriteLine();

            Console.WriteLine("Nama\t\t: {0}", Nama);
            Console.WriteLine("Umur\t\t: {0}", Umur);
            Console.WriteLine("Pekerjaan\t: {0}", Pekerjaan);
            Console.WriteLine("Uang saku\t: {0}", Saku);

            Console.WriteLine();
            Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu..");
            Console.ReadKey();
            Console.Clear();
        }
	}
}