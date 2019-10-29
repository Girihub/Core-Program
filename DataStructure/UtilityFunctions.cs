using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;
using System.IO;

namespace DataStructure
{
    public class UtilityFunctions
    {
        public bool PalindromCheck(string input)
        {
            Deque deque = new Deque();
            string temp = "";
            for(int i = 0; i < input.Length; i++)
            {
                deque.AddFront(input[i]);                
            }
            while (!deque.IsEmpty())
            {
                temp += deque.RemoveFront();
            }
            if (temp == input)
            {
                return true;
            }

            return false;
        }

         public void DispalyHash(Hash[] hash,string path)
        {
            StreamReader file = new StreamReader(path, Encoding.UTF8);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] numbers = line.Split(',', ' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = Convert.ToInt32(numbers[i]);
                    int remainder = number % hash.Length; ;
                    hash[remainder].add(number);
                }
            }
            string end = file.ReadToEnd();
            file.Close();
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i].show();
            }
        }

        public void DeleteFromFile(int input,Hash hash)
        {
            hash.Remove(input);
            string changeFile = File.ReadAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\HashNumbers.txt", Encoding.UTF8);
            changeFile = changeFile.Replace(input + "", "0");
            File.WriteAllText(@"C:\Users\admin\source\Bridge\DataStructure\DataStructure\HashNumbers.txt", changeFile);
        }

        public void InsertInFile(int input, Hash[] hash, string path)
        {
            int remainder = input % hash.Length;
            hash[remainder].add(input);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input);
            }
        }

        public bool IsPrime(int input)
        {
            if (input == 2)
            {
                return true;
            }
            for(int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return input > 1;
        }

        public bool IsAnagram(string stringOne, string stringTwo)
        {
            if (stringOne.Length != stringTwo.Length)
            {
                return false;
            }

            char[] stringOneArray = stringOne.ToLower().ToCharArray();
            char[] stringTwoArray = stringTwo.ToLower().ToCharArray();
            Array.Sort(stringOneArray);
            Array.Sort(stringTwoArray);
            for (int i = 0; i < stringOneArray.Length; i++)
            {
                if(stringOneArray[i]!= stringTwoArray[i])
                {
                    return false;
                }
            }

            return true;
        }
      
    }    
}
