using System;
using AddressBook_23;


namespace AddressBook_23
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Address Book Program");
            Console.WriteLine("Welcome To The Address Book Program\n===================================");
            MainAddress addingContact = new MainAddress();
            bool end = true;
            while (end)
            {
                Console.WriteLine("Choose an option to execute :\n1. Create Contact\n2. Add Contact\n3. Edit Contact\n4." +
                    " Delete Contact\n5. View Contact\n6. Restricting Duplicate Contact\n7. End The Program");
                 int option = (int)Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addingContact.CreateContact();
                        Console.WriteLine("Contact has created");
                        break;
                    case 2:
                        addingContact.CreateContact();
                        Console.WriteLine("Contact has added ");
                        addingContact.CreateContact();
                        break;
                    case 3:
                        EditContact editContact = new EditContact();
                        editContact.Edit();
                        break;
                    case 4:
                       DeleteContact deleteContact = new DeleteContact();
                        deleteContact.Delete();
                        break;
                    case 5:
                        MultipleContacts multipleContacts = new MultipleContacts();
                        multipleContacts.ViewContact();
                        break;
                    case 6:
                        AddressBook studentAddressBook = new AddressBook();
                        studentAddressBook.AddDetails("Student", "Swathi","Goud","IBP", "Hyd","TS", 21334, 321456789, "dwdaf@mail.com");
                        studentAddressBook.AddDetails("Fruit", "Apple", "sweet", "shimla", "Mumbai", "Maharashtra", 560464, 1236547899, "@gmail.com");
                        studentAddressBook.AddDetails("Vegetable", "carrot", "cool", "ts", "Bengaluru", "tn", 560066, 1234567, "32ed@gmail.com");
           
                        Console.WriteLine("Enter Engineer Address Book Name : ");
                        string addressBook = Console.ReadLine();
                        studentAddressBook.Details(addressBook);
                        studentAddressBook.ComputeDetails();
                        studentAddressBook.Search();
                        studentAddressBook.Count();
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }

        }
    }
    
}