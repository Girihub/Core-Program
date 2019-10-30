//----------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using DataStructure.Utility;

    /// <summary>
    /// OrderedList as a class
    /// </summary>
    public class OrderedList
    {
        /// <summary>
        /// OrderedListFunction as a function
        /// </summary>
        public static void OrderedListFunction()
        {
            try
            {
                LinkedList list = new LinkedList();
                var file = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\Numbers.txt", Encoding.UTF8);
                string[] values = file.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    list.Append(Convert.ToInt32(values[i]));
                }

                for (int i = 0; i < list.Size(); i++)
                {
                    for (int j = 0; j < list.Size() - 1; j++)
                    {
                        if (Convert.ToInt32(list.Get(j)) > Convert.ToInt32(list.Get(j + 1)))
                        {
                            int temp = Convert.ToInt32(list.Get(j));
                            list.Put(j, list.Get(j + 1));
                            list.Put(j + 1, temp);
                        }
                    }
                }

                list.Show();
                Console.WriteLine("Enter any number");
                int input = Convert.ToInt32(Console.ReadLine());
                if (list.Search(input))
                {
                    list.Remove(input);
                }
                else
                {
                    list.AddOrder(input);
                }

                list.Show();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
