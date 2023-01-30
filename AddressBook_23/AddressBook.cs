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
            personEntered.FirstName = Console.ReadLine();

            Console.Write("Enter Last name : ");
            string lastName = Console.ReadLine();

            if (contactDetailsList.Find(i => personEntered.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            personEntered.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            personEntered.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            personEntered.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            string zipString = zip.ToString();
            personEntered.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            string phoneNumberString = phoneNumber.ToString();
            personEntered.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            personEntered.Email = Console.ReadLine();
            contactDetailsList.Add(personEntered);
        }
        public List<Details> AddDetails(string addressBook, string firstName, string LastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            Details contactDetails = new Details();
            contactDetailsList.Add(contactDetails);
            return contactDetailsList;
        }
        public void Details(string addressBook)
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
                Console.WriteLine("City: {0}  {1}", i.Key, i.Value.toString());
            }

            foreach (KeyValuePair<string, Details> i in detailState)
            {
                Console.WriteLine("State: {0}  {1}", i.Key, i.Value.toString());
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
