### 📦 Episode 06: Array (Koleksi Data Statis)
Selamat datang di Episode 06! Di sini kita belajar cara mengelola banyak data secara efisien tanpa harus membuat variabel satu per satu. Array adalah dasar dari semua struktur data di C#.
---
### 📖 Materi Edukasi (Cobra Course)
Pada episode ini, kita beralih dari variabel tunggal ke koleksi data tersusun.
1. Apa itu Array?
Array adalah sebuah wadah yang dapat menampung sekumpulan data dengan tipe yang sama. Bayangkan seperti deretan loker di sebuah gedung; satu kunci (nama variabel) untuk mengakses banyak pintu (indeks).
2. Konsep Indexing (Penting!)
Hal yang paling sering membuat pemula bingung: Komputer mulai menghitung dari 0.
Data pertama = Index [0]
Data kedua = Index [1]
Data ketiga = Index [2]
3. Sifat Statis
Array bersifat Fixed Size. Sekali kamu menentukan ukurannya (misal: 5 data), kamu tidak bisa menambahnya menjadi 6 di tengah jalan. Untuk itu, kamu butuh List (Eps 07).
---
💻 Full Source Code (Program.cs)
Berikut adalah struktur kode lengkap yang didemokan di terminal COBRA:
```bash
using System;

class Program 
{
    static void Main() 
    {
        // 1. Deklarasi dan Inisialisasi Array
        string[] agents = { "Cobra", "Python", "Viper", "Mamba", "Anaconda" };

        // 2. Mengakses Data berdasarkan Index
        Console.WriteLine("Agent Pertama: " + agents[0]); // Output: Cobra
        
        // 3. Mengetahui Jumlah Data
        Console.WriteLine("Total Agent: " + agents.Length); // Output: 5

        Console.WriteLine("\n--- Daftar Seluruh Agent ---");

        // 4. Menampilkan semua data dengan Looping
        for (int i = 0; i < agents.Length; i++) 
        {
            Console.WriteLine($"[Index {i}] Nama Agent: {agents[i]}");
        }
    }
}
```
---
📝 Exercise (Latihan)
Soal:
Buatlah sebuah Array tipe int berisi 5 angka sembarang. Tampilkan hasil penjumlahan antara angka pertama (index 0) dan angka terakhir (index 4).
---


