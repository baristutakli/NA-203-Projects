using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımProjesi2 {
    enum Bolumler { Muhasebe, Yazılım_Birimi, IT_Birimi, IK, Satın_Alma, Hukuk, Satış }
    class Personel {
        static int personelSay = 0;
        int _id;
        string _adSoyad;
        int _yas;
        Bolumler _bolumler;

        public Personel(string adSoyad, int yas, Bolumler bolum)
        {
            personelSay += 1;
            _id = personelSay;
            AdSoyad = adSoyad;
            Yas = yas;
            Bolumler = bolum;
        }

        public int Id { get => _id; }
        public string AdSoyad { get => _adSoyad; set => _adSoyad = value; }
        public int Yas { get => _yas; set => _yas = value; }
        internal Bolumler Bolumler { get => _bolumler; set => _bolumler = value; }

        public void BilgiYaz()
        {
            Console.WriteLine($"Id: {Id} Ad Soyad: {AdSoyad} Yas: {Yas} Bölüm: {Bolumler}" );
        }
    }
}
