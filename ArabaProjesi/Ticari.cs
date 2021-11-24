using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaProjesi {
    class Ticari : Arac {
        short _tasimaKapasitesi;

        public Ticari(short motorHacmi, byte vitesSayisi, int fiyat, short tasimaKapasitesi) :(motorHacmi, vitesSayisi, fiyat)
        {
            TasimaKapasitesi = tasimaKapasitesi;
        }

        public short TasimaKapasitesi { get => _tasimaKapasitesi; set => _tasimaKapasitesi = value; }

        public override void OTVHesapla()
        {

            if (0 < this.MotorHacmi && this.MotorHacmi <= 999)
            {
                this.OtvFiyat = this.MotorHacmi;

            }
            else if (1000 <= this.MotorHacmi && this.MotorHacmi <= 1599)
            {
                this.OtvFiyat = this.MotorHacmi * 0.05d;

            }
            else if (1600 <= this.MotorHacmi && this.MotorHacmi <= 1999)
            {
                this.OtvFiyat = this.MotorHacmi * 0.1d;

            }
            else
            {
                this.OtvFiyat = this.MotorHacmi * 0.2d;

            }
        }

        public override void YillikVergiHesapla()
        {
            double toplam = 0;
            if (0 < this.UretimYili && this.UretimYili <= 4)
            {
                toplam += this.UretimYili * 0.03d;
            }
            else if (5 <= this.UretimYili && this.UretimYili <= 9)
            {
                toplam += this.UretimYili * 0.02d;
            }
            else if (10 <= this.UretimYili)
            {
                toplam += this.UretimYili * 0.01d;
            }

            if (0 < this.MotorHacmi && this.MotorHacmi <= 999)
            {
                toplam += this.MotorHacmi ;

            }
            else if (1000 <= this.MotorHacmi && this.MotorHacmi <= 1599)
            {
                toplam += this.MotorHacmi * 0.02d;

            }
            else if (1600 <= this.MotorHacmi && this.MotorHacmi <= 1999)
            {
                toplam += this.MotorHacmi * 0.05d;

            }
            else if (2000 <= this.MotorHacmi)
            {
                toplam += this.MotorHacmi * 0.1d;

            }
            this.YillikVergiMiktari = toplam;
        }
    }
}
