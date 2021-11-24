using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi {

    enum KasaTipi {
        Dikey, Yatay
    }
    class Masaustu : Bilgisayar {

        bool _monitorVarMi;
        KasaTipi _kasaTipi;
        public Masaustu(Kullanici kullanici, int fiyat, string marka,
            string ıslemci, byte bellek, bool hDD, bool sSD, bool ethernetVarMi,
            bool wifiVarMi, bool monitorVarMi, KasaTipi kasaTipi)
            : base(kullanici, fiyat, marka, ıslemci, bellek, hDD, sSD, ethernetVarMi, wifiVarMi)
        {
            MonitorVarMi = monitorVarMi;
            KasaTipi = kasaTipi;

        }

        public bool MonitorVarMi { get => _monitorVarMi; set => _monitorVarMi = value; }
        public KasaTipi KasaTipi { get => _kasaTipi; set => _kasaTipi = value; }
        new public void BilgiYaz()
        {
            Console.WriteLine($"İlan Numarası: {base.IlanNo} İlan Tarihi: {base.IlanTarihi}\n" +
                $"Kullanıcı: {base.Kullanici.AdSoyad} UrunFiyatı: {base.Fiyat}\n" +
                $"Marka: {this.Marka} İşlemci: {this.Islemci} Bellek: {this.Bellek}\n" +
                $"HDD: {this.HDD} SSD: {this.SSD} Ethernet: {this.EthernetVarMi}\n" +
                $"HDD Kapasitesi: {this.HDDKapasitesi} SDD Kapasitesi: {this.SSDKapasitesi}\n" +
                $"Wifi: {this.WifiVarMi} Monitor var mı: {this.MonitorVarMi} Kasa Tipi:{this.KasaTipi}\n");

        }
    }
}
