using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi {

    enum Kategori {
        Laptop,
        Masaüstü,
        TemizlikUrunleri
    }
    class Ilan {
        static int IlanSayısı = 0;
        int _ilanNo;
        DateTime _ilanTarihi;
        float _fiyat;
        Kullanici _kullanici;
        Kategori _Kategori;
        public Ilan(Kullanici kullanici, int fiyat)
        {
            IlanSayısı += 1;
            _ilanNo = IlanSayısı;
            _ilanTarihi = DateTime.Now;
            Fiyat = fiyat;
            _kullanici = kullanici;
        }

        public float Fiyat { get => _fiyat; set => _fiyat = value; }
        internal Kullanici Kullanici { get => _kullanici; }
        public Kategori Kategori { get => _Kategori; set => _Kategori = value; }
        public DateTime IlanTarihi { get => _ilanTarihi; }
        public int IlanNo { get => _ilanNo;  }

        public void BilgiYaz()
        {
            Console.WriteLine($"İlan Numarası: {this.IlanNo} İlan Tarihi: {this.IlanTarihi}\n" +
                $"Kullanıcı: {this.Kullanici} UrunFiyatı: {this.Fiyat}");
        }

        public void IndirimYap(int indirim)
        {
            this.Fiyat = this.Fiyat - this.Fiyat * indirim / 100;
            Console.WriteLine($"{indirim} İndirim oranı başarılı şekilde uygulandı.");
        }




    }
}
