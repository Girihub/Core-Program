using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class Utility
    {
        public int Factorial(int number)
        {
            int result = 1;
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public void Swap(ref char a, ref char b)
        {
            char temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void PermutationOfCharArray(char[] charArray, int i, int n)
        {
            int j;
            if (i == n)
            {
                Console.WriteLine(charArray);
            }
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref charArray[i], ref charArray[j]);
                    PermutationOfCharArray(charArray, i + 1, n);
                    Swap(ref charArray[i], ref charArray[j]);
                }
            }
        }

        public char[] CharSort(char[] chr)
        {        
            for(int i = 0; i < chr.Length; i++)
            {
                for(int j = 0; j < chr.Length - 1; j++)
                {
                    if (chr[j].CompareTo(chr[j + 1]) > 0)
                    {
                        char temp = chr[j];
                        chr[j] = chr[j + 1];
                        chr[j + 1] = temp;
                    }
                }
            }
            return chr;
        }      

        public string[] StringSort(string str1)
        {
            string[] str = str1.Split(',', ' ');
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j].CompareTo(str[j+1]) > 0)
                    {
                        string temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }
            return str;
        }

        public int BinarySearchString(string str1,string input)
        {
            string[] str = this.StringSort(str1);
            int first = 0;
            int last = str.Length;
            int mid = (first + last) / 2;
            while (first <= last)
            {
                if (str[mid].CompareTo(input) > 0)
                {
                    last = mid - 1;
                }else if(str[mid].CompareTo(input) < 0)
                {
                    first = mid + 1;
                }else if(str[mid].CompareTo(input) == 0)
                {
                    return mid;
                }
                mid = (last + first) / 2;
            }
            return -1;
        }

        public string[] InsertionSortString(string[] str)
        {
            for(int i = 1; i < str.Length; i++)
            {
                string key = str[i];
                int j = i - 1;
                while(j>=0 && str[j].CompareTo(key) > 0)
                {
                    str[j + 1] = str[j];
                    j--;
                }
                str[j + 1] = key;
            }
            return str;
        }

        public string[] BubbleSortString(string[] str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < str.Length - 1; j++)
                {
                    if (str[j].CompareTo(str[j + 1]) > 0)
                    {
                        string temp = str[j];
                        str[j] = str[j + 1];
                        str[j + 1] = temp;
                    }
                }
            }
            return str;
        }

        public void MergeSort(string[] str)
        {
            if (str.Length > 1)
            {
                string[] left = new string[str.Length / 2];
                string[] right = new string[str.Length - str.Length / 2];
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = str[i];
                }
                for(int i = 0; i < right.Length; i++)
                {
                    right[i] = str[i + str.Length / 2];
                }
                MergeSort(left);
                MergeSort(right);
                Merge(str, left, right);
            }            
        }

        public void Merge(string[] str, string[] left, string[] right)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (b >= right.Length || (a < left.Length && left[a].ToLower().CompareTo(right[b].ToLower()) < 0))
                {
                    str[i] = left[a];
                    a++;
                }
                else
                {
                    str[i] = right[b];
                    b++;
                }
            }
        }
    }
}
