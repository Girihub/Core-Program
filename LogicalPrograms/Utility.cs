using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class Utility
    {
        public const double epsilon = 1e-15;
        public void Gambling(int stake, int goal, int time)
        {
            int win = 0, j = 0;
            Random random = new Random();
            for(int i = 1; i <= time; i++)
            {
                j++;
                if (random.NextDouble() > 0.5)
                {
                    stake++;
                    win++;
                }
                else
                {
                    stake--;
                }
                if (stake == goal)
                {
                    Console.WriteLine("CONGRATS! YOU WON!");
                    break;
                }
                if (stake == 0)
                {
                    Console.WriteLine("Sorry. You Lost");
                    break;
                }
            }
            Console.WriteLine("You won " + win + " times");
            Console.WriteLine("You lost " + (j- win) + " times");
            double winPercent = ((double)win / j) * 100;
            double lossPercent = ((double)(j - win) / j) * 100;
            Console.WriteLine("Win percentages are " + winPercent + "%");
            Console.WriteLine("Loss percentages are " + lossPercent + "%");
        }

        public bool contains(int[] arr, int num)
        {
            foreach(int i in arr)
            {
                if (i == num)
                {
                    return true;
                }
            }
            return false;
        }

        public void Coupon(int number)
        {
            string coupon = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            int[] arr = new int[number];
            Random random = new Random();
            int i = 0, j = 0;
            while (i < number)
            {
                int RandomNumber = random.Next(coupon.Length);
                if (!contains(arr, RandomNumber))
                {
                    arr[i] = RandomNumber;
                    i++;
                }
                j++;
            }
            Console.WriteLine("Total " + j + " random numbers required to generate " + i + " distinct coupon numbers");
            Console.Write("Generated coupon is ");
            foreach (var k in arr)
            {
                Console.Write(coupon[k-1]);
            }
            Console.WriteLine();
        }

        public long Time()
        {
            return Environment.TickCount;             
        }

        public long ElapsedTime(long start, long stop)
        {
            return stop - start;
        }

        public double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * (double)5 / 9;
        }


        public double MonthlyPayments(int P, int R, int Y)
        {
            double n, payments;
            n = 12 * Y;
            double r = (double)R / (12 * 100);
            payments = (P * r) /(1 - Math.Pow((1 + r), -n));
            return payments;
        }

        public double Squareroot(double c)
        {            
            double t = c;           
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }
            return t;
        }      

        public void BinaryOf(int number)
        {
            int[] arr = new int[10];
            int i = 0;
            while (number > 0)
            {
                arr[i] = number % 2;
                number = number / 2;
                i++;
            }
            for(int j = i - 1; j >= 0; j--)
            {
                if((j % 4) - 3 == 0)
                {
                    Console.Write(" ");
                }
                Console.Write(arr[j]);
            }
            Console.WriteLine();
        }

        public int[] DecimalToBinaryArray(int number)
        {
            int[] arr = new int[8];
            int[] arr1 = new int[8];
            int i = 0;
            int len = arr.Length;
            while (number > 0)
            {
                arr[i] = number % 2;
                number = number / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                arr1[len - 1 - j] = arr[j];
            }
            return arr1;
        }

        public double BinaryToDecimal(int[] arr)
        {
            double number = 0;
            int len = arr.Length;
            for(int i = 0; i <arr.Length; i++)
            {
               number+= (arr[len - 1 - i]) * (Math.Pow(2, i));
            }
            return number;
        }      

        public void SwapNibbles(int number)
        {
            int[] arr = DecimalToBinaryArray(number);
            int mid = arr.Length / 2;
            int[] FirstNibble = new int[mid];
            int[] SecondNibble = new int[mid];
            for(int i = 0; i < mid; i++)
            {
                FirstNibble[i] = arr[i];
                SecondNibble[i] = arr[mid + i];
            }
            int length1 = FirstNibble.Length;
            int length2 = SecondNibble.Length;
            mid = (length1 + length2) / 2;
            int[] arr1 = new int[length1 + length2];
            for(int j = 0; j < mid; j++)
            {
                arr1[j] = SecondNibble[j];
                arr1[mid + j] = FirstNibble[j];
            }
            Console.Write("Binary of " + number + " is ");
            foreach(int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.Write("After swapping nibbles it becomes ");
            foreach(int i in arr1)
            {
                Console.Write(i);
            }
            Console.Write(" which is " + BinaryToDecimal(arr1) + " in decimal");
        }
       
        public void FewestNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int total = 0;
            for(int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    int numberOfNote = amount / notes[i];
                    Console.WriteLine(numberOfNote + " notes needed of " + notes[i]);
                    amount = amount - (notes[i] * numberOfNote);
                    total += numberOfNote;
                }                
            }
            Console.WriteLine("Total " + total + " notes will need");
        }

        public void DayOfweek(int d,int m,int y)
        {
            double y0 = y - Math.Floor((double)(14 - m) / 12);
            double x = y0 + Math.Floor(y0 / 4) - Math.Floor(y0 / 100) + Math.Floor(y0 / 400);
            double m0 = m + 12 * Math.Floor((double)((14 - m) / 12)) - 2;
            double d0 = Math.Ceiling((d + x + 31 * m0 / 12) % 7);
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine(days[(int)d0 - 1]);
        }
    }
}
