using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABicycle {
    class Bicycle {
      
        static int bicycleCount = 0;
        private int _id = 0;
        private string _brand;
        private string _model;
        private string _rimSize;
        private int _numberOfGears;

        public Bicycle(string brand, string model, string rimSize, int numberOfGears)
        {
            bicycleCount = +1;
            _id = bicycleCount;
            Brand = brand;
            Model = model;
            RimSize = rimSize;
            NumberOfGears = numberOfGears;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public string RimSize { get => _rimSize; set => _rimSize = value; }
        public int NumberOfGears { get => _numberOfGears; set => _numberOfGears = value; }


    }
}
