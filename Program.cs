namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            //CreateContact contact = new CreateContact();
            AddContact addcontact = new AddContact();
            addcontact.AddNewContact();
            Console.WriteLine();
            addcontact.Display();
            Console.WriteLine();
            addcontact.EditContact();
            Console.WriteLine();
            addcontact.Display();

        }
    }
}