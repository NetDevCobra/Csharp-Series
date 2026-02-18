using System;

namespace Episode03;

class Program
{
    static void Main(string[] args)
    {
        // 1. Data Input
        int totalBelanja = 150000;
        bool isMember = true;

        // 2. Logika Operator (AND)
        // Syarat: Belanja > 100rb DAN harus Member
        bool kenaDiskon = (totalBelanja > 100000) && (isMember == true);

        // 3. Output
        Console.WriteLine("=== STRUK BELANJA ===");
        Console.WriteLine($"Total: Rp{totalBelanja}");
        Console.WriteLine($"Status Member: {isMember}");
        Console.WriteLine($"Dapet Diskon? {kenaDiskon}");
        Console.WriteLine("======================");

        Console.ReadKey();
    }
}
