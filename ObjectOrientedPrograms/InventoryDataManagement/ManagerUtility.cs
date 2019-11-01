using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventoryDataManagement
{
    public class ManagerUtility
    {
        InventoryUtility utility = new InventoryUtility();
        public void AddInventory()
        {            
            int choice;
            do
            {
                Console.WriteLine("1. Add rice inventory");
                Console.WriteLine("2. Add wheat inventory");
                Console.WriteLine("3. Add pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    utility.AddRice();
                    break;

                case 2:
                    utility.AddWheat();
                    break;

                case 3:
                    utility.AddPulse();
                    break;

                default:
                    break;
            }
        }

        public void DeleteInventory()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Delete rice inventory");
                Console.WriteLine("2. Delete wheat inventory");
                Console.WriteLine("3. Delete pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    utility.DeleteRice();
                    break;

                case 2:
                    utility.DeleteWheat();
                    break;

                case 3:
                    utility.DeletePulse();
                    break;

                default:
                    break;
            }
        }

        public void EditInventory()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Edit rice inventory");
                Console.WriteLine("2. Edit wheat inventory");
                Console.WriteLine("3. Edit pulse inventory");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice > 3 || choice < 1);

            switch (choice)
            {
                case 1:
                    utility.EditRice();
                    break;

                case 2:
                    utility.EditWheat();
                    break;

                case 3:
                    utility.EditPulse();
                    break;

                default:
                    break;
            }
        }

        public void DisplayInventory()
        {
            utility.Display();
        }
    }
}
