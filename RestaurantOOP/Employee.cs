using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP
{
    public class Employee : Person
    {
        private string role;

        public float Salary { get; set; }
        public string Role  {get; set;}
        public bool IsManager { get; set;}

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string telephone, string email, string homeAddress,
            float salary, string role, bool isManager): base(firstName, lastName, telephone, email, homeAddress)
        {
            this.Salary = salary;
            this.Role = role;
            this.IsManager = isManager;  
        }

        
        public override void DisplayInfos()
        {

            Console.WriteLine("My infos: \nFullname: " + FirstName + " " + LastName + "\n" + "Telephone: "
                            + Telephone + "\n" + "Home address: " + HomeAddress + "\n" + "Salary: " + Salary +
                            "\n" + "Role " + Role);
        }

        public override void Introduction()
        {
            Console.WriteLine("Hello! I'am an employee.");
        }
    }
}
