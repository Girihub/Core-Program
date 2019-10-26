using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DataStructure.Utility;

namespace DataStructure
{
    public class HashChain
    {
        public static void HashChainFunction()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();

                ////Creates array having 11 slots////
                Hash[] hash = new Hash[11];
                for (int i = 0; i < 11; i++)
                {
                    hash[i] = new Hash(i);
                }

                ////Read the numbers from file and display////
                string path = @"C:\Users\admin\source\Bridge\DataStructure\DataStructure\HashNumbers.txt";
                utility.DispalyHash(hash,path);

                
                ////Take user input to search it in hash////
                Console.WriteLine("Enter number to be searched");
                int searchInput = Convert.ToInt32(Console.ReadLine());
                bool find = false;
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i].Search(searchInput))
                    {
                        find = true;
                        Console.WriteLine(searchInput + " is present in hash. So it is going to be deleted");
                        utility.DeleteFromFile(searchInput, hash[i]);                        
                        return;
                    }
                }

                if (!find)
                {
                    Console.WriteLine(searchInput + " is not present. So it is going to be addded");
                    utility.InsertInFile(searchInput, hash, path);
                }
                utility.DispalyHash(hash, path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
