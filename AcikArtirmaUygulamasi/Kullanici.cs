using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcikArtirmaUygulamasi {
    class Kullanici {
        static int KullaniiıSayisi = 0;
        private int _id;
        string _firstName;
        string _lastName;
        string tel;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Tel { get => tel; set => tel = value; }

        public Kullanici(string firstName, string lastName, string tel)
        {
            KullaniiıSayisi += 1;
            _id = KullaniiıSayisi;
            FirstName = firstName;
            LastName = lastName;
            Tel = tel;
        }
    }
}
