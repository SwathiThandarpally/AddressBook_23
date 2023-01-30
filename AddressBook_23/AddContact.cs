using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_23
{
    public  class AddContact
    {
        CreateContact contact = new CreateContact();
        List<CreateContact> addressBook = new List<CreateContact>();
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
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine("First Name : " + contact.FirstName + "\nLast Name : " + contact.LastName + "\nAddress : " + contact.Address + "\nCity : " + contact.City
                    + "\nState : " + contact.State + "\nZip Code : " + contact.Zip + "\nPhone Number : " + contact.PhoneNumber + "\nEmail Address : " + contact.Email);
            }
        }
    }
}
