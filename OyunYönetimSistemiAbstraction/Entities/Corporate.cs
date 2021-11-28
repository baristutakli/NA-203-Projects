using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class Corporate:User {
        public Corporate(string userName, string mail, string natiınalityId, string firstName, string lastName, string birthYear,string companyName) : base(userName, mail, natiınalityId, firstName, lastName, birthYear)
        {
            Games = new List<Game>();
            CompanyName = companyName;
        }

        public List<Game> Games { get; set; }
        public string CompanyName { get; set; }
     
    }
}
