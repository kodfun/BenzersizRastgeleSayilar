// ********************************************
//       BENZERSİZ RASTGELE SAYILAR
// ********************************************
Random rnd = new Random();
int bas = 1, bit = 10, adet = 10;

// TEKRARLI GELEBİLEN
Console.WriteLine("TEKRARLI GELEBİLEN");
for (int i = 0; i < adet; i++)
{
    Console.Write(rnd.Next(bas, bit + 1) + " ");
}
Console.WriteLine();

// YÖNTEM 1: ÖNCEDEN ÇIKMADIYSA EKLE
List<int> sonuc1 = new List<int>();

for (int i = 0; i < adet; i++)
{
	int yeni;
	do
	{
		yeni = rnd.Next(bas, bit + 1);
	} while (sonuc1.Contains(yeni));
	sonuc1.Add(yeni);
}
Console.WriteLine("YÖNTEM 1: ÖNCEDEN ÇIKMADIYSA EKLE");
Console.WriteLine(String.Join(" ", sonuc1));

// YÖNTEM 2: SAYI HAVUZUNDAN SEÇİM
List<int> havuz = Enumerable.Range(bas, bit - bas + 1).ToList();
List<int> sonuc2 = new List<int>();
for (int i = 0; i < adet; i++)
{
	int indeks = rnd.Next(havuz.Count);
	sonuc2.Add(havuz[indeks]);
	havuz.RemoveAt(indeks);
}
Console.WriteLine("YÖNTEM 2: SAYI HAVUZUNDAN SEÇİM");
Console.WriteLine(String.Join(" ", sonuc2));

// YÖNTEM 3: HashSet KULLANARAK
HashSet<int> sonuc3 = new HashSet<int>();

while (sonuc3.Count < adet)
{
	sonuc3.Add(rnd.Next(bas, bit + 1));
}
Console.WriteLine("YÖNTEM 3: HashSet KULLANARAK");
Console.WriteLine(String.Join(" ", sonuc3));

Console.ReadKey();