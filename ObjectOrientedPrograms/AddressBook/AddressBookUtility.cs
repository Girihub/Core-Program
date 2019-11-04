using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    public class AddressBookUtility
    {
        string path = @"C:\Users\admin\source\Bridge\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook\AddressBook.json";

        public void Display()
        {
            var json = File.ReadAllText(path);
            var jObject = JObject.Parse(json);
            Console.WriteLine("First Name  Last Name  \tAddress  \tCity  \tState  \t\tZip  \tMobile");
            foreach (var details in jObject["AddressBook"])
            {
                Console.WriteLine(details["firstName"]+ "\t\t" + details["lastName"]+ "\t" + details["address"]+"\t" + details["city"]+"\t"+ details["state"]+"\t" +details["zip"]+"\t" + details["mobile"]);
            }
        }

        public void AddInfo()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip code");
            int zip = Convert.ToInt32(Console.ReadLine());
            int mobile = 0;
            do
            {
                Console.WriteLine("Enter 10 Digit Mobile Number");
                mobile = Convert.ToInt32(Console.ReadLine());
            } while ((mobile + string.Empty).Length != 1);
            var newPerson = "{'firstName': '" + firstName + "' ,'lastName':'"+ lastName + "','address':'" + address + "','city':'" + city + "' ,'state':'" + state + "','zip':" + zip + ",'mobile':" + mobile + "}";


            var json = File.ReadAllText(path);
            var jsonObj = JObject.Parse(json);
            var personArrary = jsonObj.GetValue("AddressBook") as JArray;
            var newMember = JObject.Parse(newPerson);
            personArrary.Add(newMember);
            jsonObj["AddressBook"] = personArrary;
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, newJsonResult);
            this.Display();
        }
    }
}
