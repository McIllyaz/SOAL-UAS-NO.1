# MATERI INHERITANCE
Pada materi inheritance ini saya mencoba untuk membuat sebuah program yang sangat sederhana yaitu Input data mobil. data yang diinputkan berupa merk, model, tipe (SUV, MPV / LCGC). Yang dimana variable nya menggunakan public untuk menyimpan informasi pada objek. 

Disini saya membuat kelas “Mobil.cs” sebagai base class dengan variable merk, dan mobil untuk menyimpan data. Dan terdapat sebuah method yaitu “DataMobil” yang digunakan untuk mengoutputkan data dari 2 variabel tadi.

Terdapat kelas “Type.cs” sebagai derived class yang memiliki variable tipe mobil, tipe mesin, dan penggerak yang digunakan untuk menyimpan data, lalu terdapat sebuah method “Chasis” yang digunakan untuk mengoutputkan variable tadi.

Di Program.cs saya gunakan untuk mengoutputkan pilihan menu dengan perulangan while. Dan tidak lupa saya membuat 2 objek baru Bernama “myCar” dan “Cartype” sesuai tempat menyimpan nya Mobil.cs dan Type.cs
