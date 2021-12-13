using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP
{
    public abstract class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }


        public Person()
        {

        }
        public Person(string firstName, string lastName, string telephone, string email, string homeAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Telephone = telephone;
            this.Email = email;
            this.HomeAddress = homeAddress;
        }

        public abstract void Introduction(); 
        public abstract void DisplayInfos();
        
    }

}
