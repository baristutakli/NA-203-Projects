using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class Game {
        static int s_CountGame = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public Game(int ıd, string name)
        {
            s_CountGame += 1;
            Id = s_CountGame;
            Name = name;
        }


    }
}
