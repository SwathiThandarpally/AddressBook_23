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
            multipleContacts.Display();
        }
    }
}