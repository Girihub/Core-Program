using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class TicTacToe
    {
        public static void TicTacToeFunction()
        {
            Utility utility = new Utility();

            Random random = new Random();
            for(int i = 1; i <= 20; i++)
            {
                int num = random.Next(0,10);
                Console.WriteLine(num);
            }
        }
    }
}
