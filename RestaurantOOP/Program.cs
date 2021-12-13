using System;

namespace RestaurantOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person client1 = new Client("Client1", "NameCli1", "TelClient1", "EmailClient1", "HomeAddressCli1", "TypeClient1","DeliveryAddCli1");
            client1.Introduction();
            client1.DisplayInfos();

            Console.WriteLine();
            Person waiter1 = new Employee("Waiter1", "NameWaiter1", "TelWaiter1", "EmailWaiter1", "HomeAddressWai1", 1200.0f, "Waiter", false );
            waiter1.Introduction();
            waiter1.DisplayInfos();
        }
    }
}
