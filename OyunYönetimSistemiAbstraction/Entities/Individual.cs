using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class Individual:User  {
        public List<Game> Games { get; set; }

        public MemberShip Membership { get; set; }
        public Individual(string userName, string mail, string natiınalityId, string firstName, string lastName, string birthYear,MemberShip memberShip) : base(userName, mail, natiınalityId, firstName, lastName, birthYear)
        {
            Games = new List<Game>();
            this.Membership = memberShip;
        }

  

    }
}
