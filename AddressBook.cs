using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        public List<CreateContact> addresslist = new List<CreateContact>();
        Dictionary<string, List<CreateContact>> dict = new Dictionary<string, List<CreateContact>>();
        public void Addcontact(CreateContact contact)
        {
            addresslist.Add(contact);
        }
        public void Editcontact(string name)
        {
            foreach (var contact in addresslist)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    bool flag = true;
                    while (flag == true)
                    {
                        Console.WriteLine("what to be edited:\n1.firstname\n2.lastname\n3.address\n4.city\n5.state\n6.zip\n7.phone.no\n8.email-id\n9.exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                string Firstname = Console.ReadLine();
                                contact.FirstName = Firstname;
                                Display();
                                break;
                            case 2:
                                string Lastname = Console.ReadLine();
                                contact.LastName = Lastname;
                                Display();
                                break;
                            case 3:
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Display();
                                break;
                            case 4:
                                string City = Console.ReadLine();
                                contact.City = City;
                                Display();
                                break;
                            case 5:
                                string State = Console.ReadLine();
                                contact.State = State;
                                Display();
                                break;
                            case 6:
                                string Zip = Console.ReadLine();
                                contact.Zip = Zip;
                                Display();
                                break;
                            case 7:
                                string PhoneNo = Console.ReadLine();
                                contact.PhNo = PhoneNo;
                                Display();
                                break;
                            case 8:
                                string emailid = Console.ReadLine();
                                contact.Email = emailid;
                                Display();
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("your choice should be between 1 to 9");
                                break;
                        }
                    }
                }
            }
        }
        public void Display()
        {
            foreach (var contact in addresslist)
            {
                Console.WriteLine("firstname =" + contact.FirstName + "\nlastname =" + contact.LastName + "\njAddress =" + contact.Address + "\nCity =" + contact.City + "\nState =" + contact.State + "\nZip =" + contact.Zip + "\nPhone-Number =" + contact.PhNo + "Email-Id =" + contact.Email);
            }
        }
        public void DeleteContact(string name)
        {
            CreateContact delete = new CreateContact();
            foreach (var contact in addresslist.ToList())
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    delete = contact;
                }
                addresslist.Remove(delete);
                Console.WriteLine(name + "contact has deleted");
            }
        }
        public void AddUniqueContact(string firstname)
        {
            foreach (var contact in addresslist)
            {
                if (addresslist.Contains(contact))
                {
                    string uniquename = Console.ReadLine();
                    dict.Add(uniquename, addresslist);
                }
            }
        }
        public void DisplayUniqueContact()
        {
            Console.WriteLine("Enter the name of dictionary");
            string firstname = Console.ReadLine();
            foreach (var contact in dict)
            {
                if (contact.Key == firstname)
                {
                    foreach (var item in contact.Value)
                    {
                        Console.WriteLine("Firstname:" + item.FirstName + "\n" + "lastname:" + item.LastName + "\n" + "Address:" + item.Address + "\n" + "City:" + item.City + "\n" + "State:" + item.State + "\n" + "Zip:" + item.Zip + "\n" + "Phone.No-" + item.PhNo + "\n" + "Email.Id:" + item.Email);
                    }
                }
            }
        }
    }
}
