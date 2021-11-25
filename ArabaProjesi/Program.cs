using System;

namespace ArabaProjesi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Otomobil otomobil = new Otomobil(500, 4, 100000, Renk.Beyaz, KapiSayisi.Kapı4);
            Otomobil otomobil1 = new Otomobil(1500, 5, 1000000, Renk.Siyah, KapiSayisi.Kapı6);
            Ticari ticari = new Ticari(2400, 10, 150000, 25000);
            Ticari ticari1 = new Ticari(1000, 10, 150000, 25000);

            Console.WriteLine($"OTV: {otomobil.OTVHesapla()} Yıllık Vergi Hesaplama: {otomobil.YillikVergiHesapla()}");
            Console.WriteLine($"OTV: {otomobil1.OTVHesapla()} Yıllık Vergi Hesaplama: {otomobil1.YillikVergiHesapla()}");


        }
    }
}
