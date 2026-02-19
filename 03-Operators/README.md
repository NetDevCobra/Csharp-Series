# Episode 03: Operators (Matematika & Logika) ⚡️

Waduh, variabel udah ada, tapi kalau didiemin doang ya nggak guna! Di sini kita bakal belajar cara memanipulasi data pakai **Operators**. Ada yang buat hitung-hitungan, ada juga yang buat banding-bandingin (kayak lo bandingin spek HP).

## 1. Arithmetic Operators (Matematika Dasar) ➕
Buat lo yang dulu pas sekolah sering nanya "MTK buat apa sih?", nah ini jawabannya!
- `+` : Tambah
- `-` : Kurang
- `*` : Kali
- `/` : Bagi
- `%` : Modulo (Sisa bagi, berguna banget buat nyari angka ganjil/genap!)

## 2. Comparison Operators (Banding-Bandingan) ⚖️
Hasilnya pasti `bool` (True/False).
- `==` : Sama dengan (Hati-hati, double `=` ya!)
- `!=` : Nggak sama dengan
- `>` / `<` : Lebih besar / Lebih kecil
- `>=` / `<=` : Lebih besar sama dengan / Lebih kecil sama dengan

## 3. Logical Operators (Logika Hubungan) 🧠
- `&&` (AND) : Harus bener dua-duanya baru `true`.
- `||` (OR) : Salah satu bener aja udah `true`.
- `!` (NOT) : Kebalikan (True jadi False, False jadi True).

---

## Contoh Kode (No Cap!) 💻
```csharp
int tabungan = 1000000;
int hargaKopi = 50000;

// Sisa uang setelah jajan kopi
int sisaUang = tabungan - hargaKopi;

// Cek apakah uang cukup buat beli lagi?
bool masihBisaJajan = sisaUang >= hargaKopi;

Console.WriteLine($"Sisa uang: {sisaUang}");
Console.WriteLine($"Bisa jajan lagi? {masihBisaJajan}");
```
---
## 📝 Exercise (Tantangan!)
Coba buat sistem "Diskon Member" sederhana:

Buat variabel totalBelanja (int) dan isMember (bool).

Tentukan variabel kenaDiskon (bool) yang bernilai true HANYA JIKA totalBelanja lebih dari 100.000 DAN isMember itu true.

Print hasilnya di Console!
---
---

## 📚 Curriculum (The Journey)

Di sini kita bakal ngelewatin tiap episode dengan seru:

| Episode | Title | Status | Highlight |
| :--- | :--- | :--- | :--- |
| [Eps 01](../01-Introduction/README.md) | **Halo, .NET World!** | ✅ Done | Fondasi & Struktur Dasar |
| [Eps 02](../02-Variables-DataType/README.md) | **Variables-DataType** |✅ Done | Manipulasi Data biar nggak *error* |
| [Eps 03](../03-Operators/README.md)| **Operators** | ✅ Done | Matematika tapi asik |
| [Eps 04](../04-Logic/README.md) | **IF/ELSE (Logic)** | ✅ Done | Biar program lo nggak *clueless* pas milih |
| ⏳ Soon | **⏳ Soon** | ⏳ Soon | ⏳ Soon 

---
