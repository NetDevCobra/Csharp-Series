### 🚀 Episode 07: List (Generic Collection) - Full Structure
Selamat datang di Episode 07! Jika di episode sebelumnya kita belajar Array yang kaku, sekarang kita pindah ke List<T>, koleksi data paling populer dan fleksibel di dunia .NET.
---
### 📖 Materi Edukasi (Cobra Course)
Pada episode ini, terminal COBRA tidak hanya menampilkan logika, tapi juga struktur program C# yang benar.
1. Struktur Lengkap Program
Untuk menggunakan List, kita wajib memanggil namespace khusus di bagian paling atas:
```bash
using System.Collections.Generic; // Wajib untuk List
```
2. Deklarasi & Inisialisasi
Berbeda dengan Array, List menggunakan sistem Generic <T> untuk menentukan tipe datanya:
```bash
List<string> squad = new List<string>();
```
3. Manipulasi Data Dinamis
Inilah kelebihan utama List dibanding Array:
.Add(): Menambahkan data di akhir urutan.
.Remove(): Menghapus data berdasarkan nilainya.
.Count: Properti untuk mengetahui jumlah elemen saat ini.
---
### 💻 Full Source Code (Program.cs)
Berikut adalah kode lengkap yang didemokan di terminal:
```bash
using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        // 1. Membuat List baru
        var squad = new List<string>();

        // 2. Menambah Data
        squad.Add("Cobra");
        squad.Add("Viper");

        // 3. Menghapus Data
        squad.Remove("Viper");

        // 4. Menampilkan Data dengan Looping
        foreach(var m in squad) 
        {
            Console.WriteLine($"Agent: {m}");
        }
    }
}
```
### 📝 Exercise (Latihan)
Soal:
Buatlah sebuah program yang memiliki List<int> bernama skor.
Masukkan angka 80, 90, 100.
Hapus angka 80.
Tampilkan semua sisa angka di dalam list menggunakan foreach.
---
Cobra Note: "List adalah sahabat terbaik programmer C#. Belajarlah menguasainya, dan kamu bisa mengelola data apa pun dengan mudah!" 🐍
---
