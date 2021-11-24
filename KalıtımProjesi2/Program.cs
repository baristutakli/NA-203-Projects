using System;

namespace KalıtımProjesi2 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Personel personel1 = new Personel("Barış Manço", 42, Bolumler.IK);
            Personel personel2 = new Personel("Barış Akarsu", 25, Bolumler.IT_Birimi);
            Yonetici yönetici = new Yonetici("Cem Yılmaz", 55, Bolumler.IT_Birimi,2);
            personel1.BilgiYaz();
            personel2.BilgiYaz();
            yönetici.BilgiYaz();



        }
    }
}
