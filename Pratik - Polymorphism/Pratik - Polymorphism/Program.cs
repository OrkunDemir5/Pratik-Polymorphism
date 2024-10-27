using Pratik_Polymorphism;

// Kare için nesne oluşturulup alan hesaplanır
Kare kare = new Kare { Genislik = 5, Yukseklik = 5 };
Console.WriteLine($"Kare Alanı: {kare.AlanHesapla()}");

// Dikdörtgen için nesne oluşturulup alan hesaplama
Dikdortgen dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 6 };
Console.WriteLine($"Dikdörtgen Alanı: {dikdortgen.AlanHesapla()}");

// Dik Üçgen için nesne oluşturulup alan hesaplama
DikUcgen dikUcgen = new DikUcgen { Genislik = 3, Yukseklik = 7 };
Console.WriteLine($"Dik Üçgen Alanı: {dikUcgen.AlanHesapla()}");