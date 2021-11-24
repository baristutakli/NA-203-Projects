using System;

namespace KalıtımProjesi {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Urun İlanı Yayınlama Programı\n");
            Masaustu casper = new Masaustu(new Kullanici("Barış Manço", "555555"), 1000, "Hp", "intel", 8, true, false, true,
                true, false, KasaTipi.Dikey);
            casper.HDDKapasitesi = 128;
            casper.SSDKapasitesi = 256;

            Console.WriteLine("Bir Sonraki urun yükleniyor...");
            Dizustu Hp = new Dizustu(new Kullanici("Barış Manço", "555555"), 1000, "Hp", "intel", 8, true, false, true,
    true, false,EkranBoyutu.INC10,EkranTipi.Oled);
            Hp.SSDKapasitesi = 64;
            Hp.HDDKapasitesi = 1024;
            Console.WriteLine();
            Console.WriteLine($"Ürün bilgisi yazılıyor...");
            casper.BilgiYaz();
            Console.WriteLine($"Ürün bilgisi yazılıyor...");
            Hp.BilgiYaz();


           

        }
    }


    
}
