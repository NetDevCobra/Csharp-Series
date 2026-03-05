using System;

class Program 
{
    static void Main() 
    {
        TampilkanPeringatan("Virus");
    }

    static void TampilkanPeringatan(string bahaya) 
    {
        Console.WriteLine("AWAS! Bahaya terdeteksi: " + bahaya);
    }
}
