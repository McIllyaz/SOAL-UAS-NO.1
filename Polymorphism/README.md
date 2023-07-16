Pada materi Polymorphism saya membuat sebuah program menghitung sebuah luas bangun datar, diantaranya adalah persegi, persegi panjang, lingkaran, segitiga, dan trapesium. Jadi user hanya diminta untuk menginputkan data yang diperlukan, sebagai contoh segitiga dengan luas Alas * Tinggi / 2, maka user hanya diminta untuk menginput alas dan tinggi nya saja saja tanpa menginputkan rumus.

Pada program ini saya menggunakan sebuah kelas dan metode abstrak yaitu “abstract class BangunDatar” dan “abstract double HitungArea()”. Kenapa? Dengan menggunakan abstract class, kita dapat membuat kerangka kerja yang lebih fleksibel dan memungkinkan adanya variasi dalam perilaku kelas turunan yang spesifik. Selain itu, penggunaan abstract class juga membantu menerapkan prinsip-prinsip OOP seperti polimorfisme, enkapsulasi, dan pewarisan. 

Kemudian pada setiap class bangun datar (persegi, persegi panjang, lingkaran, segitiga, dan trapesium) menggunakan variable double untuk tempat penyimpanan datanya, kenapa? Karena dikhawatirkan hasilnya akan ada komanya maka saya buat semua (termasuk input) menjadi tipe data double agar user juga dapat menginputkan nilai yang ada komanya. Dan di setiap kelas (persegi, persegi panjang, lingkaran, segitiga, dan trapesium) mengoverride metode “HitungArea()” dengan isi rumus sesuai dengan luas bangun datar yang dipilih user, “pada lingkaran.cs” saya menggunakan syntax dari system berupa Math.pi (Thanks Microsoft) yang memudahkan kita sehingga tidak perlu menginisialisasi pi dengan nilai 3.14 atau 22/7.

Pada Program.cs saya membuat sebuah array bangundatar yang dapat menampung objek-objek yang mewarisi kelas BangunDatar. Setiap elemen dalam array tersebut diinisialisasi dengan objek dari kelas turunan yang berbeda, yaitu Persegi, PersegiPanjang, Lingkaran, Segitiga, dan Trapesium.

Pada baris kode kesembilan, BangunDatar[ ] bangundatar = new BangunDatar[5]; kita membuat array bangundatar yang memiliki panjang 5, yang berarti dapat menampung 5 objek.

((Persegi)bangundatar[0]).SISI = sisi; Pada baris ini, kita melakukan casting objek pada bangundatar[0] ke tipe Persegi menggunakan (Persegi) dan kemudian mengakses properti SISI pada objek Persegi tersebut.

double luaspersegi = bangundatar[0].HitungArea(); Pada baris ini, kita memanggil metode HitungArea() pada objek pada bangundatar[0]. Ini memanggil metode HitungArea() yang didefinisikan dalam kelas Persegi (atau turunannya) dan mengembalikan nilai luas persegi tersebut.

Perlu diketahui bahwa output an dibawah ini adalah urut dari nomor 1 – 5. 6 
untuk keluar.
