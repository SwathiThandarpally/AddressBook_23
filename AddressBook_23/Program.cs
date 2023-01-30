using System;
using AddressBook_23;

namespace AddressBook_23
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Address Book Program");
            //UC_1
            CreateContact create = new CreateContact();
            MainAddress address = new MainAddress();
            address.CreateContact();

        }
    }
}