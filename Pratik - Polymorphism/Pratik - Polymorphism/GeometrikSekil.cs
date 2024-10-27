using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Polymorphism
{
    class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // AlanHesapla metodu Base class içinde tanımlanır ve polimorfizm sağlanır.
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
    class Kare : BaseGeometrikSekil
    {
        // Kare hesaplama
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
    class Dikdortgen : BaseGeometrikSekil
    {
        // Dikdörtgen hesaplama
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
    class DikUcgen : BaseGeometrikSekil
    {
        // Dik Üçgende hesaplama
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
