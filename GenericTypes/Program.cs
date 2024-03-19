using GenericTypes;

GenericSinif<int> ogrenci = new GenericSinif<int>();
ogrenci.ID = 1;
// ogrenci.ID = "123";//type olarak int verdiğim için ıd ye farklı tip değişken verilemez.
ogrenci.Name = "Büşra";
ogrenci.SurName = "Konyar";

GenericSinif<Guid> ogretmen = new GenericSinif<Guid>();
//ogretmen.ID = 1; //type olarak guid belirlendiği için ıd ye farklı bir type değer verilemez.
ogretmen.ID = Guid.NewGuid();
ogretmen.Name = "Muhammed";
ogretmen.SurName = "İnan";
Console.WriteLine($"ID:{ogrenci.ID}\nAdı:{ogrenci.Name}\nSoyadı:{ogrenci.SurName}");
Console.WriteLine();
Console.WriteLine("******************");
Console.WriteLine();
Console.WriteLine($"ID:{ogretmen.ID}\nAdı:{ogretmen.Name}\nSoyadı:{ogretmen.SurName}");

Console.ReadLine();