using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcikArtirmaUygulamasi {
    class Urun {
        // URun: Id, Ad, Baslamazamanı, IlandaKalma süresi, List<Teklif>
        static int urunSayısı = 0;
        private int _id;
        string _ad;
        DateTime _baslamaZamanı;
        int _ilandaKalmaSüresi;
        List<Teklif> teklifler;
        Teklif _teklif;

        public Urun(string ad, int ilandaKalmaSüresi)
        {

            urunSayısı += 1;
            _id = urunSayısı;
            Ad = ad;
            BaslamaZamanı = DateTime.Now;
            IlandaKalmaSüresi = ilandaKalmaSüresi;
            this.Teklifler = new List<Teklif>();
        }

        public DateTime BaslamaZamanı { get => _baslamaZamanı; set => _baslamaZamanı = value; }
        public int IlandaKalmaSüresi { get => _ilandaKalmaSüresi; set => _ilandaKalmaSüresi = value; }
        public string Ad { get => _ad; set => _ad = value; }
        internal List<Teklif> Teklifler { get => teklifler; set => teklifler = value; }
        internal Teklif Teklif { get => _teklif; }

        public void TeklifKontrol(Teklif teklif)
        {

            TimeSpan fark = DateTime.Now - BaslamaZamanı;
            if (IlandaKalmaSüresi - fark.Milliseconds > 0)
            {
                if (teklifler.Count == 0)
                {
                    teklifler.Add(teklif);
                }
                else
                {
                    if (teklifler[0].Fiyat < teklif.Fiyat)
                    {
                        teklifler[0] = teklif;
                    }
                }

            }

        }
        public string Kazanan()
        {
            if (teklifler.Count > 0)
            {
                return $"Kazanan teklif: {teklifler[0].Kullanici.FirstName} / Ödenen miktar:{teklifler[0].Fiyat} ";
            }
            else
            {
                return "Hiçbir teklif yapılmadı!";
            }
        }


    }
}
