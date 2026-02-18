using System;

namespace Episode02;

class Program
{
    static void Main(string[] args)
    {
        // --- JAWABAN EXERCISE ---
        
        // 1. Deklarasi Variabel
        string namaLengkap = "Budi Slebew";
        int umur = 20;
        double tinggiBadan = 175.5;
        bool isLulus = true;

        // 2. Output ke Console pake String Interpolation ($)
        Console.WriteLine("=== KTP DIGITAL GEN-Z ===");
        Console.WriteLine($"Nama   : {namaLengkap}");
        Console.WriteLine($"Umur   : {umur} Tahun");
        Console.WriteLine($"Tinggi : {tinggiBadan} cm");
        Console.WriteLine($"Status : {(isLulus ? "Alumni" : "Masih Sekolah")}"); 
        Console.WriteLine("=========================");

        // Biar window console nggak langsung ketutup
        Console.WriteLine("\nTekan apa aja buat cabut...");
        Console.ReadKey();
    }
}
