using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_23
{
    public  class AddressBook
    {
        List<Details> contactDetailsList;
        private Dictionary<string, Details> contactDetailsMap;
        private Dictionary<string, Dictionary<string, Details>> multipleAddressBookMap;


        public AddressBook()
        {
            contactDetailsList = new List<Details>();
            contactDetailsMap = new Dictionary<string, Details>();
            multipleAddressBookMap = new Dictionary<string, Dictionary<string, Details>>();
        }

        public void ContactList()
        {
            Details personEntered = new Details();
            Console.Write("Enter First name : ");
            string firstName = Console.ReadLine();
            personEntered.FirstName = "FirstName";
            personEntered.LastName = "LastName";
            personEntered.PhoneNumber = 9999999;
            personEntered.Zip = 1233;
            personEntered.State = "State";
            personEntered.Email = "abc@gmail.com";
            personEntered.City = "hyd";
            personEntered.Address = "address";

           
        }
        public List<Details> AddDetails(string addressBook, string firstName, string LastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            Details contactDetails = new Details();
            contactDetailsList.Add(contactDetails);
            return contactDetailsList;
        }
        public void AddressBookDetails(string addressBook)
        {
            multipleAddressBookMap.Add(addressBook, contactDetailsMap);
        }
        //Searching a Person
        public Dictionary<string, Details> Search()
        {
            Console.Write(" Enter state : ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.Write(" Enter city : ");
            string city = Console.ReadLine();
            var cityCheck = stateCheck.FindAll(x => x.City == city);
            Console.Write(" Find Person : ");
            string firstName = Console.ReadLine();
            var person = cityCheck.Where(x => x.FirstName == firstName).FirstOrDefault(); //Returns the First Element 
            if (person != null)
            {
                Console.WriteLine(firstName + " is  in " + city);
            }
            else
            {
                Console.WriteLine(firstName + " is not  in " + city);
            }


            Dictionary<string, Details> detailCity = new Dictionary<string, Details>();
            Dictionary<string, Details> detailState = new Dictionary<string, Details>();
            detailCity.Add(city, person);
            detailState.Add(state, person);
            foreach (KeyValuePair<string, Details> i in detailCity)
            {
                Console.WriteLine(i);
            }

            foreach (KeyValuePair<string, Details> i in detailState)
            {
                Console.WriteLine( i);
            }

            Console.WriteLine(detailCity.Count());
            return detailCity;
        }
        public void Count()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.WriteLine(" No of contacts from the state: " + state + " are " + stateCheck.Count);
        }
        public void ComputeDetails()
        {
            foreach (Details book in contactDetailsList)
            {
                Console.WriteLine(book.toString());
            }
        }
    }
}
