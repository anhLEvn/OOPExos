using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP
{
    public class Waiter: Employee
    {
        public override void Introduction()
        {
            Console.WriteLine("Hello! I'am a waiter.");
        }
    }
}
