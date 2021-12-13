using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOOP
{
    public class Client: Person
    {
        public string ClientType { get; set; }
        
        public string DeliveryAddress { get; set; }


        public Client()
        {

        }
        public Client(string firstName, string lastName, string telephone, string email, string homeAddress,
            string clientType, string deliveryAddress): base(firstName, lastName, telephone,  email, homeAddress)
        {
            
            this.ClientType = clientType;
            this.DeliveryAddress = deliveryAddress; 
        }

        public override void DisplayInfos()
        {
            Console.WriteLine("My infos: \nFullname: " + FirstName +" " + LastName + "\n" + "Telephone: " 
                            + Telephone + "\n" + "Home address: " + HomeAddress + "\n" +  "Type Client: " + ClientType + 
                            "\n" + "Delivery Adress: "  + DeliveryAddress);            
        }

        public override void Introduction()
        {
            Console.WriteLine("Hello! I'am a client."); 
        }

        
    }
}
