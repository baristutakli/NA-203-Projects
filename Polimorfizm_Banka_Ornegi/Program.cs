using System;

namespace Polimorfizm_Banka_Ornegi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Garanti grnt = new Garanti();
            Akbank akbn = new Akbank();
            EFT(grnt);
            EFT(akbn);


        }

        static void EFT(Banka bnk)
        {
            bnk.EFT();
        }

    }
}
