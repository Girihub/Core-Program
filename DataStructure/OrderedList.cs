using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class OrderedList
    {
        public static void OrderedListFunction()
        {
            LinkedList list = new LinkedList();            
            var file = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\Numbers.txt", Encoding.UTF8);
            string[] values = file.Split(',');            
            for (int i = 0; i < values.Length; i++)
            {
                list.append(Convert.ToInt32(values[i]));
            }
            for (int i = 0; i < list.size(); i++)
            {
                for (int j = 0; j < list.size() - 1; j++)
                {
                    if (Convert.ToInt32(list.get(j)) > Convert.ToInt32(list.get(j + 1)))
                    {
                        int temp = Convert.ToInt32(list.get(j));
                        list.put(j, list.get(j + 1));
                        list.put(j + 1, temp);
                    }
                }
            }
            list.show();
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (list.search(input))
            {
                list.remove(input);
            }
            else
            {
                list.addOrder(input);
            }
            list.show();
            Console.WriteLine();
        }
    }
}
