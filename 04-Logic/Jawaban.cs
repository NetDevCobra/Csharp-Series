//🔑 Jawaban (Key Answer)

//Berikut adalah logika koding yang benar untuk menyelesaikan latihan di atas:
//C#

Console.Write("Masukkan Suhu Tubuh: ");
double suhu = double.Parse(Console.ReadLine());

if (suhu > 37) 
{
    Console.WriteLine("Anda Demam, dilarang masuk!");
}
else 
{
    Console.WriteLine("Suhu Normal, silakan masuk.");
}
