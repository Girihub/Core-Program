using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class BankingCashCounter
    {
        public static void BankingCashCounterFunction()
        {
            try
            {
                Queue peopleInQueue = new Queue();
                int bankBalance = 200000;
                Console.WriteLine("Enter no. of people");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter names of people");
                for (int i = 0; i < numberOfPeople; i++)
                {
                    peopleInQueue.enqueue(Console.ReadLine());
                }
                Console.WriteLine("1: To withdraw money");
                Console.WriteLine("2: To deposite money");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    default:
                        Console.WriteLine("Enter valid choice");
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
