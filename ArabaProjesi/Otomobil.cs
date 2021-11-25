using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaProjesi {

    enum Renk {
        Siyah, Beyaz, Gri, Kırmızı, Yeşil
    }

    enum KapiSayisi {
        Kapı2, Kapı4, Kapı6
    }

    class Otomobil : Arac {
        Renk _renk;
        KapiSayisi _kapiSayisi;

        internal Renk Renk { get => _renk; set => _renk = value; }
        internal KapiSayisi KapiSayisi { get => _kapiSayisi; set => _kapiSayisi = value; }

        public Otomobil(short motorHacmi, byte vitesSayisi, int fiyat, Renk renk, KapiSayisi kapiSayisi) : base(motorHacmi, vitesSayisi, fiyat)
        {
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }

        public override double OTVHesapla()
        {

            if (0 < this.MotorHacmi && this.MotorHacmi <= 999)
            {
                this.OtvFiyat = this.Fiyat * 0.05d;
              
            }
            else if (1000 <= this.MotorHacmi && this.MotorHacmi <= 1599)
            {
                this.OtvFiyat = this.Fiyat * 0.1d;
             
            }
            else if (1600 <= this.MotorHacmi && this.MotorHacmi <= 1999)
            {
                this.OtvFiyat = this.Fiyat * 0.15d;
              
            }
            else
            {
                this.OtvFiyat = this.Fiyat * 0.2d;
             
            }
            return this.OtvFiyat;

        }

        public override double YillikVergiHesapla()
        {
            // Yillik 
            double toplam = 0;
            if (0 < this.UretimYili && this.UretimYili <= 4)
            {
                toplam += this.Fiyat * 0.05d;
            }
            else if (5 <= this.UretimYili && this.UretimYili <= 9)
            {
                toplam += this.Fiyat * 0.04d;
            }
            else if(10 <= this.UretimYili)
            {
                toplam += this.Fiyat * 0.03d;
            }

            if (0 < this.MotorHacmi && this.MotorHacmi <= 999)
            {
                toplam += this.Fiyat * 0.02d;
                
            }
            else if (1000 <= this.MotorHacmi && this.MotorHacmi <= 1599)
            {
                toplam += this.Fiyat * 0.05d;
               
            }
            else if (1600 <= this.MotorHacmi && this.MotorHacmi <= 1999)
            {
                toplam += this.Fiyat * 0.08d;
               
            }
            else if(2000 <= this.MotorHacmi)
            {
                toplam += this.Fiyat * 0.1d;
              
            }
            this.YillikVergiMiktari = toplam;
            return this.YillikVergiMiktari;

        }
    }
}
