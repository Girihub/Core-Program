//----------------------------------------------------
// <copyright file="UnOrderedList.cs" company="Bridgelabz">
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
    /// UnOrderedList as a class
    /// </summary>
    public class UnOrderedList
    {
        /// <summary>
        /// UnOrderedListFunction as a function
        /// </summary>
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
                        list.Append(word[i]);
                    }
                }

                list.Show();
                string end = file.ReadToEnd();
                file.Close();
                Console.WriteLine();
                Console.WriteLine("Enter word to find");
                string find = Console.ReadLine();
                string changeFile = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt", Encoding.UTF8);
                if (list.Search(find))
                {
                    list.Remove(find);
                    changeFile = changeFile.Replace(find, string.Empty);
                    File.WriteAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt", changeFile);
                }
                else
                {
                    list.Append(find);
                    using (StreamWriter sw = File.AppendText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\File.txt"))
                    {
                        sw.WriteLine(find);                        
                    }
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
