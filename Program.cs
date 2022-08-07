namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            //CreateContact contact = new CreateContact();
            //AddContact addcontact = new AddContact();
            //addcontact.AddNewContact();
            //Console.WriteLine();
            //addcontact.Display();
            //Console.WriteLine();
            //addcontact.EditContact();
            //Console.WriteLine();
            //addcontact.Display();
            //editContact editcontact = new editContact();
            //editcontact.AddNewContact();
            //Console.WriteLine();
            //editcontact.Display();
            //Console.WriteLine();
            //editcontact.EditContact();
            //Console.WriteLine();
            //editcontact.Display();
            //deleteContact deletecontact = new deleteContact();
            //deletecontact.AddNewContact();
            //Console.WriteLine();
            //deletecontact.Display();
            //Console.WriteLine();
            //deletecontact.RemoveContact();
            //Console.WriteLine();
            //deletecontact.Display();
            AddMultipleContact addMultipleContact = new AddMultipleContact();
            addMultipleContact.AddMultipleContacts();

        }
    }
}