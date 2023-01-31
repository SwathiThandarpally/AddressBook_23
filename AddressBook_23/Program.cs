using System;
using AddressBook_23;


namespace AddressBook_23
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Address Book Program");
            CreateContact create = new CreateContact();
            MainAddress address = new MainAddress();
            address.CreateContact();
            //UC_2
            AddContact add = new AddContact();
            MainAddress mainAddress = new MainAddress();
            add.CreateContact();
            add.Display();
            //UC_3
            EditContact edit = new EditContact();
            edit.CreateContact();
            edit.Display();
            edit.Edit();
            //UC_4
            DeleteContact delete = new DeleteContact();
            delete.CreateContact();
            delete.Display();
            delete.Delete();
            //UC_5
            MultipleContacts contacts = new MultipleContacts();
            contacts.AddContact();
            contacts.ViewContact();
            contacts.Display();
            //UC_6
            AddMultipleContacts multipleContacts = new AddMultipleContacts();
            multipleContacts.AddContact();
            multipleContacts.ViewContact();
            multipleContacts.EditContact();
            multipleContacts.DeleteContact();
            multipleContacts.ChangeAddressBook();
            multipleContacts.AddContact();
            multipleContacts.Display();
            //UC_7
            AddMultipleContacts multipleContacts1 = new AddMultipleContacts();
            multipleContacts.AddContact();
            multipleContacts.ViewContact();
            multipleContacts.EditContact();
            multipleContacts.DeleteContact();
            multipleContacts.ChangeAddressBook();
            multipleContacts.Display();
            //UC_8
            AddressBook addressBook = new AddressBook();
            addressBook.ContactList();
            addressBook.AddDetails("swathi", "apple", "goud", "adc", "uus", "gyi", 123, 344, "wwee");
            addressBook.AddressBookDetails("Addressbook");
            addressBook.Search();
            addressBook.ComputeDetails();
            Details details = new Details("swathi", "apple", "goud", "adc", "uus", "gyi", 123, 344, "wwee");
            details.toString();


            //UC_9
            AddressBook addressBook1 = new AddressBook();
            addressBook.ContactList();
            addressBook.AddDetails("swathi", "apple", "goud", "adc", "uus", "gyi", 123, 344, "wwee");
            addressBook.AddressBookDetails("Addressbook");
            addressBook.Search();
            addressBook.ComputeDetails();
            Details details1 = new Details("swathi","apple","goud","adc","uus","gyi",123,344,"wwee");
            details.toString();
            //UC_10
            AddressBook addressBook2 = new AddressBook();
            addressBook.ContactList();
            addressBook.AddDetails("swathi", "apple", "goud", "adc", "uus", "gyi", 123, 344, "wwee");
            addressBook.AddressBookDetails("Addressbook");
            addressBook.Search();
            addressBook.Count();
            addressBook.ComputeDetails();
            Details details2 = new Details("swathi", "apple", "goud", "adc", "uus", "gyi", 123, 344, "wwee");
            details.toString();





        }
    }
    
}