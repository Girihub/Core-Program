using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.StockAccountManagement
{
    public class StockReport
    {
        public static void StockReportDetails()
        {
            try
            {
                Console.WriteLine("1. To add stock");
                Console.WriteLine("2. To get stock value");
                Console.WriteLine("3. To dispaly stocks");
                int input = Convert.ToInt32(Console.ReadLine());
                StockReportUtility utility = new StockReportUtility();
                switch (input)
                {
                    case 1:
                        utility.AddStock();
                        break;

                    case 2:
                        utility.StockValue();
                        break;

                    case 3:
                        utility.Dispaly();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
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
