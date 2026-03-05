### 🛠️ Episode 08: Methods (Fungsi Modular & Flow Control)
Selamat datang di Episode 08! Jika selama ini kita menumpuk semua kode di dalam Main(), sekarang saatnya kita belajar menjadi "Manajer" kode yang baik dengan memecah tugas menggunakan Methods (Fungsi).

### 📖 Inti Materi (Analogi Bos & Anak Buah)
Cara paling mudah memahami Method adalah dengan membayangkan struktur organisasi kerja:
- Main() adalah Bos: Dia yang mengatur alur jalannya program dari atas ke bawah.
- Method adalah Anak Buah: Dia spesialis yang diam saja sampai namanya dipanggil oleh si Bos.
- Ketika Bos (Main) memanggil Anak Buah (Method), Bos akan berhenti sejenak. Anak Buah mengerjakan tugasnya sampai selesai, lalu kembali lapor ke Bos. Setelah itu, barulah Bos lanjut ke baris tugas berikutnya.
---
### Anatomi Method C#
``bash
static void CetakPesan(string pesan) 
{
    // Isi tugas di sini
}
```
- static: Karena Main kita bersifat static (fasilitas umum), maka anak buah yang dipanggil juga harus static.
- void: Artinya method ini hanya "kerja bakti". Dia melakukan tugas tapi tidak memberikan laporan balik berupa data/nilai.
- (string pesan): Ini adalah Parameter. Titipan data dari si Bos untuk dikerjakan oleh Anak Buah.
---
### 💻 Full Source Code (Program.cs)
Berikut adalah struktur kode lengkap yang mensimulasikan "loncatan" alur kerja program:
```bash
using System;

class Program 
{
    // Si Bos (Entry Point)
    static void Main() 
    {
        Console.WriteLine("[1] MAIN: Program dimulai.");
        
        // Memanggil Method (Menyuruh anak buah)
        Console.WriteLine("[2] MAIN: Memanggil CetakPesan(\"Cobra\")...");
        CetakPesan("Cobra"); 
        
        Console.WriteLine("[4] MAIN: Tugas anak buah selesai, lanjut kerja.");
    }

    // Si Anak Buah (Method Tambahan)
    static void CetakPesan(string nama) 
    {
        // Lompat ke sini
        Console.WriteLine($"  └──> [3] METHOD: Menerima target '{nama}'. Eksekusi tugas!");
        // Setelah kurung kurawal tutup ini, program lompat balik ke Main
    }
}
```
---
### 📝 Exercise (Latihan)
Soal:
Buatlah sebuah method bernama TampilkanPeringatan. Method ini menerima satu parameter bertipe string bernama bahaya. Tugas method ini adalah mencetak teks: "AWAS! Bahaya terdeteksi: [isi parameter bahaya]".
Lalu, panggil method tersebut di dalam Main dengan mengirimkan kata "Virus".
---
## 📚 Curriculum (The Journey)

Di sini kita bakal ngelewatin tiap episode dengan seru:

| Episode | Title | Status | Highlight |
| :--- | :--- | :--- | :--- |
| [Eps 01](./01-Introduction/README.md) | **Halo, .NET World!** | ✅ Done | Fondasi & Struktur Dasar |
| [Eps 02](./02-Variables-DataType/README.md) | **Variables-DataType** |✅ Done | Manipulasi Data biar nggak *error* |
| [Eps 03](./03-Operators/README.md)| **Operators** | ✅ Done | Matematika tapi asik |
| [Eps 04](./04-Logic/README.md) | **IF/ELSE (Logic)** | ✅ Done | Biar program lo nggak *clueless* pas milih |
| [Eps 05](./05-Looping/README.md) | **Looping** | ✅ Done | Otomatisasi Tanpa Lelah |
| [Eps 06](./06-Array-Collection) | **Looping** | ✅ Done | Koleksi Data Statis) |
| [Eps 07](./07-List) | **List** | ✅ Done | Generic Collection) |
| [Eps 08](./08-METHOD-Modular-Flow-Control) | **METHOD** | ✅ Done | Fungsi Modular & Flow Control) |
| ⏳ Soon | **⏳ Soon** | ⏳ Soon | ⏳ Soon 
---
## 🚀 Cara Pakenya?
1. **Clone** repo ini: `https://github.com/NetDevCobra/Csharp-Series.git`
2. **Buka** di Visual Studio 2022 atau VS Code.
3. **Run** kodenya, trus rasain *magic*-nya! ✨
---
