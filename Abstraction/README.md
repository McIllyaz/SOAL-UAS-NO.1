# MATERI ABSTRAKSI
Pada materi Abstraction ini saya membuat sebuah program menghitung sebuah volume bangun ruang, diantaranya adalah kubus, balok, kerucut, tabung, dan limas. Jadi user hanya diminta untuk menginputkan data yang diperlukan, sebagai contoh balok dengan rumus volume Panjang * Lebar * Tinggi, maka user hanya diminta untuk menginput panjang, lebar, dan tinggi nya saja tanpa menginputkan rumus.

Pada program ini saya menggunakan sebuah kelas dan metode abstrak yaitu “abstract class BangunRuang” dan “abstract double HitungVolume()”. Kenapa? Dengan menggunakan abstract class, kita dapat membuat kerangka kerja yang lebih fleksibel dan memungkinkan adanya variasi dalam perilaku kelas turunan yang spesifik. Selain itu, penggunaan abstract class juga membantu menerapkan prinsip-prinsip OOP seperti polimorfisme, enkapsulasi, dan pewarisan. 

Kemudian pada setiap class bangun ruang (kubus, balok, kerucut, tabung, dan limas) menggunakan variable double untuk tempat penyimpanan datanya, kenapa? Karena dikhawatirkan hasilnya akan ada komanya maka saya buat semua (termasuk input) menjadi tipe data double agar user juga dapat menginputkan nilai yang ada komanya. Dan di setiap kelas (kubus, balok, kerucut, tabung, dan limas) mengoverride metode “HitungVolume()” dengan isi rumus sesuai dengan volume bangun ruang yang dipilih user, pada matematika saya menggunakan syntax dari system berupa Math.pi (Thanks Microsoft) yang memudahkan kita sehingga tidak perlu menginisialisasi pi dengan nilai 3.14 atau 22/7.

Pada Program.cs saya membuat sebuah array bangunruang yang dapat menampung objek-objek yang mewarisi kelas BangunRuang. Setiap elemen dalam array tersebut diinisialisasi dengan objek dari kelas turunan yang berbeda, yaitu kubus, balok, kerucut, tabung, dan limas.

Pada baris kode kesembilan, BangunRuang[ ] bangunruang = new BangunRuang[5]; kita membuat array bangunruang yang memiliki panjang 5, yang berarti dapat menampung 5 objek.
((Kubus)bangunruang[0]).SISI = sisi; Pada baris ini, kita melakukan casting objek pada bangunruang[0] ke tipe Kubus menggunakan (Kubus) dan kemudian mengakses properti SISI pada objek Kubus tersebut.

double volumekubus = bangunruang[0].HitungVolume(); Pada baris ini, kita memanggil metode HitungVolume() pada objek pada bangunruang[0]. Ini memanggil metode HitungVolume() yang didefinisikan dalam kelas Kubus (atau turunannya) dan mengembalikan nilai volume kubus tersebut.
Perlu diketahui bahwa untuk materi polymorphism dan abstraction kurang lebih sama, kenapa? Karena sama-sama menggunakan abstract class didalam programnya. Hanya saja tujuan dari programnya yang membedakan, tetapi pure saya yang buat.

Perlu diketahui bahwa output an dibawah ini adalah urut dari nomor 1 – 5. 6 
untuk keluar.
