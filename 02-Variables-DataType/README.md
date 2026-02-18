# Episode 02: Variabel & Tipe Data 📦✨

Halo lagi! Di episode ini, kita bakal belajar cara "nyimpen" data biar nggak ilang pas program jalan. Bayangin variabel itu kayak **laci**, dan tipe data itu **label** di lacinya biar lo nggak salah masukin barang.

## Kenapa Harus Pilih Tipe Data? (No Cap!) 🧢
C# itu *Strongly Typed*. Artinya, kalau lo bilang lacinya buat **Angka**, jangan coba-coba masukin **Chat Mantan (Teks)**. Bakal *error* parah!

### Tipe Data Starter Pack:
1. **`int` (Integer)**: Buat angka bulat (Contoh: Jumlah mantan, umur, level game).
2. **`double`**: Buat angka koma-komaan (Contoh: IPK, harga diskon, koordinat GPS).
3. **`string`**: Buat teks (Contoh: Nama user, alamat, curhatan).
4. **`bool` (Boolean)**: Cuma ada dua pilihan: `true` atau `false` (Kayak status hubungan: Rumit atau Enggak).

---

## Contoh Kode (Sat-Set Version) 💻
```csharp
// Cara bikin variabel: TipeData NamaVariabel = IsiDatanya;

string heroName = "Lancelot"; 
int powerLevel = 99;
double winRate = 75.5;
bool isMythic = true;

Console.WriteLine($"Hero: {heroName} | Power: {powerLevel} | WR: {winRate}% | Mythic: {isMythic}");
