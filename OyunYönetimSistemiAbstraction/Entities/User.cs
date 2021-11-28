using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYönetimSistemiAbstraction.Entities {
    class User : IEntity {
        static int s_CountUser = 0;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string NatiınalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthyear { get; set; }

        public User(string userName, string mail, string natiınalityId,string firstName,string lastName, string birthYear)
        {
            s_CountUser += 1;
            Id = s_CountUser;
            UserName = userName;
            Mail = mail;
            NatiınalityId = natiınalityId;
            FirstName = firstName;
            LastName = lastName;
            Birthyear = birthYear;
        }
       

     
    }
}
