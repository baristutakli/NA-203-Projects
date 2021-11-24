using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABicycle {
    class Renting {
        // Kiralama: Id, BisikletID, KullanıcıId, Sure, Ucret, Başlama zamanı, bitiş zamanı.Metotlar: 
        static int totalRentedBicycle = 0;
        private int _id=0;
        private User _user;
        private Bicycle _bicycle;
        private TimeSpan _usedTime;
        private double _charge =0;
        private DateTime _start;
        private DateTime _finish;

        public Renting( User user, Bicycle bicycle)
        {
            totalRentedBicycle += 1;
            this._id = totalRentedBicycle;
            this._user = user;
            this._bicycle = bicycle;
        }

        public void StartRenting()
        {
            this._start = DateTime.Now;
            
        }
        public void EndRenting()
        {
            this._finish = DateTime.Now;
        }

        public double DebtCalculator()
        {

            TimeSpan diff = _finish - _start;
            return diff.Seconds * 0.5;
        }

        public override string ToString()
        {
            return $"Started at: {this._start}\nFinished at:{this._finish}\n Debt: {DebtCalculator()}";
        }



        /*
         **KiralamaBasalt() => Başlama zamanını tut, 
        *KiralamaBitir() => bitiş zamanını tut ve ucretHesapla()=> Bitiş ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek (double).
        *BilgiYaz() => Şu zamanda başladın bu zamanda bitirdin toplam dakika kullandın ödemen gereken ücret liradır.
        *Birim ücret:dakikası 50 kuruş. 
         */

    }
}
