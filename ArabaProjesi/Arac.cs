using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaProjesi {
    abstract class Arac {
        static int aracSay = 0;
        int _id;
        short _motorHacmi;
        byte _vitesSayisi;
        int _fiyat;
        double _otvFiyat;
        int  _uretimYili;
        double _yillikVergiMiktari;

        public Arac( short motorHacmi, byte vitesSayisi, int fiyat)
        {
            aracSay += 1;
            Id = aracSay;
            MotorHacmi = motorHacmi;
            VitesSayisi = vitesSayisi;
            Fiyat = fiyat;
            _uretimYili = DateTime.Now.Year;

        }

        public static int AracSay { get => aracSay; set => aracSay = value; }
        public int Id { get => _id; set => _id = value; }
        public short MotorHacmi { get => _motorHacmi; set => _motorHacmi = value; }
        public byte VitesSayisi { get => _vitesSayisi; set => _vitesSayisi = value; }
        public int Fiyat { get => _fiyat; set => _fiyat = value; }
        public int UretimYili { get => _uretimYili;  }
        public double OtvFiyat { get => _otvFiyat; set => _otvFiyat = value; }
        public double YillikVergiMiktari { get => _yillikVergiMiktari; set => _yillikVergiMiktari = value; }

        public void IndirimYap(byte indirim)
        {
            // indirim yap
        }
        public void GetFiyat()
        {
            Console.Write($"Fiyat: {this.Fiyat}");
        }


        abstract public double OTVHesapla();
        abstract public double YillikVergiHesapla();
    }
}
