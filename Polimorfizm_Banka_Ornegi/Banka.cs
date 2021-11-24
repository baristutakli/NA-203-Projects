using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Banka_Ornegi {
    class Banka {
        protected double _EFTUcreti;
        public Banka()
        {
            this._EFTUcreti = 0;
        }
        virtual public void EFT()
        {
            Console.WriteLine($"Banka EFT işlemi başarı ile yapıldı. Ücreti {this._EFTUcreti}");
        }
    }
}
