using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms.InventoryDataManagement
{
    public class InventoryDataManagement
    {
        public static void InventoryDataManagementFunction()
        {
            try
            {
                InventoryUtility utility = new InventoryUtility();
                utility.Display();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
