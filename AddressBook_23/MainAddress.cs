﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_23
{
    public  class MainAddress
    {
        CreateContact contact = new CreateContact();
        public void CreateContact()
        {
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address : ");
            contact.Email = Console.ReadLine();
        }
    }
}
