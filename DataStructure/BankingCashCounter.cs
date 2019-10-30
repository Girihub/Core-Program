//----------------------------------------------------
// <copyright file="BankingCashCounter.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructure.Utility;

    /// <summary>
    /// BankingCashCounter as a class name
    /// </summary>
    public class BankingCashCounter
    {
        /// <summary>
        /// BankingCashCounterFunction as a function
        /// </summary>
        public static void BankingCashCounterFunction()
        {
            try
            {
                QueueUsingLinkedList peopleInQueue = new QueueUsingLinkedList();
                int bankBalance = 200000;
                int withdrawLimit = 20000;                
                Console.WriteLine("Enter no. of people");
                int numberOfPeople = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter names of people");
                for (int i = 0; i < numberOfPeople; i++)
                {
                    peopleInQueue.enqueue(Console.ReadLine());
                } 
                
                while (!peopleInQueue.IsEmpty())
                {
                    peopleInQueue.show();                  
                    Console.WriteLine("Welcome to our bank " + peopleInQueue.get());
                    Console.WriteLine("1: To withdraw money");
                    Console.WriteLine("2: To deposite money");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter money to withdraw");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            while (amount > bankBalance && amount > withdrawLimit)
                            {
                                Console.WriteLine("Withdraw limit is " + withdrawLimit);
                                amount = Convert.ToInt32(Console.ReadLine());
                            }

                            bankBalance = bankBalance - amount;
                            peopleInQueue.dequeue();
                            break;

                        case 2:
                            Console.WriteLine("Enter cash to deposit");
                            int cash = Convert.ToInt32(Console.ReadLine());
                            while (cash < 1)
                            {
                                Console.WriteLine("Deposit amount should be atleast 1");
                                cash = Convert.ToInt32(Console.ReadLine());
                            }

                            bankBalance = bankBalance + cash;
                            peopleInQueue.dequeue();
                            break;

                        default:
                            Console.WriteLine("Enter valid choice");
                            break;
                    }

                    Console.WriteLine("Bank balance " + bankBalance);
                }
            }        
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
