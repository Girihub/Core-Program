using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    public class AddressBookUtility
    {
        public void Display()
        {
            using (StreamReader file = new StreamReader(@"C:\Users\admin\source\Bridge\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\AddressBook.json",Encoding.UTF8))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<AddressBookData>>(json);
                Console.WriteLine("FirstName | LastName | Address | City | State | Zip | Mobile");
                Console.WriteLine();
                foreach (var item in items)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6}", item.FirstName, item.LastName, item.Address, item.City, item.State, item.Zip, item.Mobile);
                }
            }
        }
    }
}
