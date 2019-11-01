using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class InventoryManager
    {
        public static void InventoryManagerFunction()
        {
            try
            {
                InventoryDataManagement.ManagerUtility utility = new InventoryDataManagement.ManagerUtility();
                int input;
                do
                {
                    Console.WriteLine("1. Add Inventory");
                    Console.WriteLine("2. Edit Inventory");
                    Console.WriteLine("3. Delete Inventory");
                    Console.WriteLine("4. Display Inventory");
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input > 4 || input < 1);
                
                switch (input)
                {
                    case 1:
                        utility.AddInventory();
                        break;

                    case 2:
                        utility.EditInventory();
                        break;

                    case 3:
                        utility.DeleteInventory();
                        break;

                    case 4:
                        utility.DisplayInventory();
                        break;

                    default:
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
