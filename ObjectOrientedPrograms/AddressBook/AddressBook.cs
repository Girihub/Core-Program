using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    public class AddressBook
    {
        public static void AddressBookFunction()
        {
            try
            {
                AddressBookUtility utility = new AddressBookUtility();
                Console.WriteLine("1. To view all person's info");
                Console.WriteLine("2. To create new person info");
                Console.WriteLine("3. To edit existing person's info");
                Console.WriteLine("4. To delete person's info");
                Console.WriteLine("5. To sort person's info by name");
                Console.WriteLine("6. To sort person's info by zip");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        utility.Display();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
