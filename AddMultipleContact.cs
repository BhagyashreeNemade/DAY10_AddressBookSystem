using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddMultipleContact
    {
        public List<CreateContact> contactlist = new List<CreateContact>();
        public void AddNewContact()
        {

            CreateContact person = new CreateContact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            foreach (CreateContact createcontact in contactlist)
            {
                if (createcontact.FirstName.ToLower() == person.FirstName.ToLower())
                {
                    Console.WriteLine("person already exist");
                    return;
                }
            }
            CreateContact contact = new CreateContact();

            Console.WriteLine("enter first name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("enter second name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("enter address name");
            contact.Address = Console.ReadLine();

            Console.WriteLine("enter phno name");
            contact.PhNo = Console.ReadLine();

            Console.WriteLine("enter city name");
            contact.City = Console.ReadLine();

            Console.WriteLine("enter state name");
            contact.State = Console.ReadLine();

            Console.WriteLine("enter zip name");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("enter Email name");
            contact.Email = Console.ReadLine();

            contactlist.Add(contact);

        }
        public void AddMultipleContacts()
        {
            Console.WriteLine("enter number of contact you want to add");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                AddNewContact();
                N--;
            }
        }

    }
}
