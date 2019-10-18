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

        public int[] BinaryOf(int number)
        {
            int[] arr = new int[10];
            int i = 0;
            while (number > 0)
            {
                arr[i] = number % 2;
                number = number / 2;
                i++;
            }
            int[] arr1 = new int[i];
            int k = 0;
            for(int j = i-1; j >= 0; j--)
            {
                arr1[k] = arr[j];
                k++;
            }
            return arr1;
        }
    }
}
