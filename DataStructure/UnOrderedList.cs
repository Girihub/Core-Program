using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class UnOrderedList
    {
        public static void UnOrderedListFunction()
        {
            try
            {
                LinkedList list = new LinkedList();
                StreamReader file = new StreamReader(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt", Encoding.UTF8);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    for (int i = 0; i < word.Length; i++)
                    {
                        list.append(word[i]);
                    }
                }
                list.show();
                string end = file.ReadToEnd();
                file.Close();
                Console.WriteLine();
                Console.WriteLine("Enter word to find");
                string find = Console.ReadLine();
                string changeFile = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt", Encoding.UTF8);
                if (list.search(find))
                {
                    list.remove(find);
                    changeFile = changeFile.Replace(find, "");
                    File.WriteAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt", changeFile);
                }
                else
                {
                    list.append(find);
                    using (StreamWriter sw = File.AppendText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt"))
                    {
                        sw.WriteLine(find);                        
                    }
                }
                list.show();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }        
    }
}
