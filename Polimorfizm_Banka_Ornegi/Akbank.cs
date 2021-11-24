using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Banka_Ornegi {
    class Akbank:Banka {
        public Akbank()
        {
            base._EFTUcreti = 30.0;
        }

        public override void EFT()
        {
            Console.WriteLine($"Akbank EFT {this._EFTUcreti}");
        }
    }
}
