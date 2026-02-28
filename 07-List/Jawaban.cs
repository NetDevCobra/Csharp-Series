List<int> skor = new List<int> { 80, 90, 100 };
skor.Remove(80);

foreach(int s in skor) 
{
    Console.WriteLine("Skor: " + s);
}
