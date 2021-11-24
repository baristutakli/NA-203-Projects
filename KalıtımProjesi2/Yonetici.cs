using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi2 {
    class Yonetici : Personel {
        int _altPersonelSayisi = 0;

        public int AltPersonelSayisi { get => _altPersonelSayisi; set => _altPersonelSayisi = value; }

        public Yonetici(string adSoyad, int yas, Bolumler bolum, int altPersonelSayisi) : base(adSoyad, yas, bolum)
        {
            AltPersonelSayisi = altPersonelSayisi;
        }
        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine($"Alt Personel Sayisi: {AltPersonelSayisi}");
        }
    }
}
