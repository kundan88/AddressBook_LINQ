using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddreeBook_LINQ
{
    public class AddressBook
    {
        DataTable dataTable = new DataTable();
        public AddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
        }
        public void AddContact()
        {
            dataTable.Rows.Add("Rita", "Smith", "Street77", "New York", "America", 254632, 8863914598, "ritasmith@gmail.com");
            dataTable.Rows.Add("Sam", "Kales", "Ohio", "Florida", "America", 789652, 8785214569, "ohiojack@gmail.com");
            dataTable.Rows.Add("Pablo", "Escobar", "Philadelphia", "Texas", "America", 123652, 8563269547, "pablotexas@gmail.com");
            dataTable.Rows.Add("ElChapo", "Gusman", "Hublo", "Miami", "America", 145236, 7854125632, "miamigusman@gmail.com");
            dataTable.Rows.Add("Brandon", "Tan", "Rebublic", "Washington", "America", 145298, 7452145639, "tanbrandon@gmail.com");
            Console.WriteLine("Contact is Added");
        }
        public void DisplayContacts()
        {
            foreach (var contact in dataTable.AsEnumerable())
            {
                Console.WriteLine("FirstName:" + contact.Field<string>("FirstName"));
                Console.WriteLine("LastName:" + contact.Field<string>("LastName"));
                Console.WriteLine("Address:" + contact.Field<string>("Address"));
                Console.WriteLine("City:" + contact.Field<string>("City"));
                Console.WriteLine("State:" + contact.Field<string>("State"));
                Console.WriteLine("ZipCode:" + contact.Field<int>("Zip"));
                Console.WriteLine("PhoneNumber:" + contact.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:" + contact.Field<string>("Email"));
                Console.WriteLine();
            }
        }
    }
}