using AddreeBook_LINQ;

namespace AddressBook_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Using LINQ");
            AddressBook addressbook = new AddressBook();
            int option = 0;
            do
            {
                Console.WriteLine("1: For Add the Contact");
                Console.WriteLine("2: For Display Contact");
                Console.WriteLine("3: For Editing Contact");
                Console.WriteLine("4: For Removing Contact");
                Console.WriteLine("5: For Getting Details Using City And State");
                Console.WriteLine("6: For Getting Count Details By City Name");
                Console.WriteLine("7: For Sorting By FirstName");
                Console.WriteLine("0: For Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    case 1:
                        addressbook.AddContact();
                        break;
                    case 2:
                        addressbook.DisplayContacts();
                        break;
                    case 3:
                        addressbook.EditContact();
                        break;
                    case 4:
                        addressbook.RemoveContact();
                        break;
                    case 5:
                        addressbook.GetContactByUsingCityAndState();
                        break;
                    case 6:
                        addressbook.CountContactByUsingCity();
                        break;
                    case 7:
                        addressbook.SortContactsByFirstName();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Input");
                        break;
                }
            }
            while (option != 0);
        }
    }
}

