using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class Utility
    {
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
    }
}
