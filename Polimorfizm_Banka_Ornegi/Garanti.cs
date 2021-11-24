using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Banka_Ornegi {
    class Garanti:Banka {
        public Garanti()
        {
            base._EFTUcreti = 20.0D;
        }
        public override void EFT()
        {
            Console.WriteLine($"Garanti Eft ücreti: {this._EFTUcreti}");
        }
    }
}
