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
## 📚 Curriculum (The Journey)

Di sini kita bakal ngelewatin tiap episode dengan seru:

| Episode | Title | Status | Highlight |
| :--- | :--- | :--- | :--- |
| [Eps 01](../01-Introduction/README.md) | **Halo, .NET World!** | ✅ Done | Fondasi & Struktur Dasar |
| [Eps 02](../02-Variables-DataType/README.md) | **Variables-DataType** |✅ Done | Manipulasi Data biar nggak *error* |
| [Eps 03](../03-Operators/README.md)| **Operators** | ✅ Done | Matematika tapi asik |
| [Eps 04](../04-Logic/README.md) | **IF/ELSE (Logic)** | ✅ Done | Biar program lo nggak *clueless* pas milih |
| [Eps 05](../05-Looping/README.md) | **Looping** | ✅ Done | Otomatisasi Tanpa Lelah |
| [Eps 06](../06-Array-Collection) | **Looping** | ✅ Done | Koleksi Data Statis) |
| [Eps 07](../07-List) | **List** | ✅ Done | Generic Collection) |
| [Eps 08](../08-METHOD-Modular-Flow-Control) | **METHOD** | ✅ Done | Fungsi Modular & Flow Control) |
| ⏳ Soon | **⏳ Soon** | ⏳ Soon | ⏳ Soon 
---

