using System;

namespace LokantaYazılımı {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // static metodlar virual olarak bildirilemez
            LokantaMersin mersin = new LokantaMersin();
            LokantaTokat tokat = new LokantaTokat();
            LokantaYozgat yozgat = new LokantaYozgat();
            // Tek bir işlem yaparak her nesne için farklı bir işlem yapabiliriz.

            BelediyeHarcOde(mersin);
            BelediyeHarcOde(tokat);
            BelediyeHarcOde(yozgat);
        }
        static void BelediyeHarcOde(Lokanta lkt)
        {
            lkt.BelediyeHarcOde();
        }
    }
 
}
