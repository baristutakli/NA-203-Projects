using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi {
    enum EkranBoyutu {
        INC10,
        INC15,
        INC17
    }
    enum EkranTipi {
        Oled,
        LCD
    }
    class Dizustu : Bilgisayar {

        EkranTipi _ekranTipi;
        EkranBoyutu _ekranBoyutu;

        public Dizustu(Kullanici kullanici, int fiyat, string marka, string ıslemci,
            byte bellek, bool hDD, bool sSD, bool ethernetVarMi, bool wifiVarMi,
            bool monitorVarMi, EkranBoyutu ekranBoyutu, EkranTipi ekranTipi) :
            base(kullanici, fiyat, marka, ıslemci, bellek, hDD, sSD, ethernetVarMi, wifiVarMi)
        {
            EkranBoyutu = ekranBoyutu;
            EkranTipi = ekranTipi;
        }

        public EkranBoyutu EkranBoyutu { get => _ekranBoyutu; set => _ekranBoyutu = value; }
        public EkranTipi EkranTipi { get => _ekranTipi; set => _ekranTipi = value; }

        new public void BilgiYaz()
        {
            Console.WriteLine($"İlan Numarası: {base.IlanNo} İlan Tarihi: {base.IlanTarihi}\n" +
                $"Kullanıcı: {base.Kullanici.AdSoyad} UrunFiyatı: {base.Fiyat}\n" +
                $"Marka: {this.Marka} İşlemci: {this.Islemci} Bellek: {this.Bellek}\n" +
                $"HDD: {this.HDD} SSD: {this.SSD} Ethernet: {this.EthernetVarMi}\n" +
                $"HDD Kapasitesi: {this.HDDKapasitesi} SDD Kapasitesi: {this.SSDKapasitesi}\n" +
                $"Wifi: {this.WifiVarMi} Ekran Tipi: {this.EkranTipi} Ekran Boyutu: {this.EkranBoyutu}\n");

        }
    }
}
