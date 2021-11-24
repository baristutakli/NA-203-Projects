using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABicycle {

    class User {
        static int count = 0;
        private int _id = 0;
        private string _firstName;
        private string _lastName;
        private string _tel;

        public User()
        {

        }

        public User(string firstName, string lastName, string tel)
        {
            count += 1;
            this._id += count;
            this._firstName = firstName;
            this._lastName = lastName;
            this._tel = tel;
        }

        public int Id { get => _id; }
        public string FirstName
        {
            get => _firstName; set
            {
                if (!string.IsNullOrEmpty(value) && (!String.IsNullOrWhiteSpace(value)))
                {
                    _firstName = value;
                }
            }
        }
        public string LastName { get => _lastName; set
            {
                if (!string.IsNullOrEmpty(value) && (!String.IsNullOrWhiteSpace(value)))
                {
                    _lastName = value;
                }
            }}
        public string Tel { get => _tel; set {
                if (!string.IsNullOrEmpty(value) && (!String.IsNullOrWhiteSpace(value)))
                {
                    _tel = value;
                }
            } }



    }
}
