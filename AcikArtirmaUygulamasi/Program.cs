using System;
using System.Threading;

namespace AcikArtirmaUygulamasi {
    class Program {
        static void Main(string[] args)
        {
            // Açık artırmanuygulaması:
            // Urun : ID, Ad, BaslamaZ, IlandaKalmaSuresi,List<Teklif>
            // Basla(). Başlama zamanını tutacak.
            // TeklifKontrol() : yayın süresi içindeyse gelen teklifi alıp listeye ekleyecek.
            // Sonuclandir(): süre dolduğuysa teklifleri ekrana yazdıracak. Ve en yüksek teklifi kazanan olarak yazacak.


            // Teklif: ID,Kullanici,Urun,Fiyat

            // Kullanici tanımlı.
            Urun urun1 = new Urun("saniye", 10);
            Kullanici k1 = new Kullanici("Barış", "Akarsu", "55555555");
            Teklif t1 = new Teklif(k1, urun1, 100);
            urun1.TeklifKontrol(t1);
            Thread.Sleep(5000);
            Teklif t2 = new Teklif(k1, urun1, 200);
            urun1.TeklifKontrol(t2);
            Thread.Sleep(10000);
            Teklif t3 = new Teklif(k1, urun1, 2000);
            urun1.TeklifKontrol(t3);
            Console.WriteLine(urun1.Kazanan());


        }
    }
}
