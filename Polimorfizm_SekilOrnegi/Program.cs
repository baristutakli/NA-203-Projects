using System;

namespace Polimorfizm_SekilOrnegi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Ucgen ucgen = new Ucgen(12, 18, 15, 15);
            Dortgen dorgen = new Dortgen(10, 20);
            Daire daire = new Daire(4);

            AlanHesapla(ucgen);
            CevreHesapla(ucgen);

            AlanHesapla(dorgen);
            CevreHesapla(dorgen);

            AlanHesapla(daire);
            CevreHesapla(daire);

        }

        static void AlanHesapla(Sekil sekil)
        {
            sekil.AlanHesapla();
        }
        static void CevreHesapla(Sekil sekil)
        {
            sekil.CevreHesapla();
        }
    }
}
