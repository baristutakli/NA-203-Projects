using System;
using System.Threading;

namespace RentABicycle {
    class Program {
        static void Main(string[] args)
        {


            /*
             Bisiklet kiralama Yazılımı
            *Bisiklet: ID, Marka, Model, JantBoyutu, VitesSayisi, 
            *Kullanıcı Id, AdSoyad, Telefon
            *Kiralama: Id, BisikletID, KullanıcıId, Sure, Ucret, Başlama zamanı, bitiş zamanı. Metotlar: 
            *KiralamaBasalt() => Başlama zamanını tut, 
            *KiralamaBitir() => bitiş zamanını tut ve ucretHesapla()=> Bitiş ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek (double).
            *BilgiYaz() => Şu zamanda başladın bu zamanda bitirdin toplam dakika kullandın ödemen gereken ücret liradır.
            *Birim ücret:dakikası 50 kuruş.
            *
            */

            User user1 = new User("Barış","Tutakli","5555555");
            User user2 = new User("Barış", "Tutakli", "666666");
            User user3 = new User("Barış", "Tutakli", "7777777");
            Bicycle bicycle = new Bicycle("MBI", "sport", "18", 21);
            Bicycle bicycle2 = new Bicycle("F1", "Race", "41", 28);
            Bicycle bicycle3 = new Bicycle("Toyota", "retro", "18", 8);

            Renting rent1 = new Renting(user1, bicycle);
            rent1.StartRenting();
            Thread.Sleep(5000);
            rent1.EndRenting();
            Console.WriteLine(rent1.ToString());

            Renting rent2 = new Renting(user1, bicycle);
            rent2.StartRenting();
            Thread.Sleep(7000);
            rent2.EndRenting();
            Console.WriteLine(rent2.ToString());

            Renting rent3 = new Renting(user1, bicycle);
            rent2.StartRenting();
            Thread.Sleep(3000);
            rent3.EndRenting();
            Console.WriteLine(rent3.ToString());


        }
    }
}
