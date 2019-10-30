//----------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Text.RegularExpressions;
    using DataStructure.Utility;

    /// <summary>
    /// BalancedParenthesis as a class
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// BalancedParenthesisFunction as a function
        /// </summary>
        public static void BalancedParenthesisFunction()
        {
            try
            {
                Stack stack = new Stack();
                Console.WriteLine("Enter arithmatic expression");
                string expression = Console.ReadLine();

                /// Regex expression to accept elements which is necessary for valid expression
                while (!Regex.IsMatch(expression, @"^[0-9-+/*)(]+$"))
                {
                    Console.WriteLine("Enter valid arithmatic expression");
                    expression = Console.ReadLine();
                }

                /// iterating to push elements on respective condition
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] + string.Empty == "(")
                    {
                        stack.Push("(");
                    }

                    if (expression[i] + string.Empty == ")")
                    {
                        stack.Pop();
                    }
                }

                if (stack.IsEmpty())
                {
                    Console.WriteLine("Arithmatic expression is balanced");
                }
                else
                {
                    Console.WriteLine("Arithmatic expression is not balanced");
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
