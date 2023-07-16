Pada materi encapsulasi ini saya mencoba untuk membuat sebuah program yang sangat sederhana yaitu input data diri, data yang diinputkan berupa nama, umur, pekerjaan dan uang saku. Yang dimana variable nya menggunakan private, protected, dan internal untuk menyimpan informasi pada objek yang dibuat dari class tersebut. 

Variable tersebut menggunakan property yang didefinisikan dalam kelas tersebut (Data.cs) Properti memberikan akses kontrol dan abstraksi untuk membaca dan menulis nilai variabel anggota. Perlu dicatat bahwa akses langsung ke variabel anggota (NAMA, UMUR, dan PEKERJAAN) tidak diperbolehkan dari luar kelas, karena mereka memiliki aksesibilitas yang lebih rendah (private, protected, dan internal).

Method yang saya gunakan selain Main method adalah method TampilanDataDiri() yang berada pada Data.cs, yang fungsinya tidak lain adalah untuk output data yang telah di inputkan oleh user. 

Untuk tampilan sendiri saya taruh pada Program.cs dengan perulangan while, sehingga user dapat kembali ke menu utama setiap kali keluar dari pilihan 1 maupun 2. Dan untuk pilihan 3 adalah untuk keluar aplikasi (terminal). Dan saya membuat sebuah objek baru yaitu “data” sesuai tempat menyimpan nya Data.cs
