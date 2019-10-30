//----------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Stack as a class
    /// </summary>
    public class Stack
    {
        int top = -1;
        static int limit = 1000;
        Object[] stack = new Object[limit];

        /// <summary>
        /// Function to add the data in stack
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void push(Object data)
        {
            if (top >= limit - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top = top + 1;
                stack[top] = data;
            }
        }

        /// <summary>
        /// Function to delete data from the stack
        /// </summary>
        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {                
                top--;
            }
        }

        /// <summary>
        /// Function to get the data at the top of the stack
        /// </summary>
        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            Console.WriteLine(stack[top]);
            return;
        }

        /// <summary>
        /// Function to check if the stack is empty
        /// </summary>
        /// <returns>Returns true if the stack is empty</returns>
        public bool IsEmpty()
        {
            return top < 0;
        }

        /// <summary>
        /// Function to print the elements in the stack
        /// </summary>
        public void print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(stack[i] + " ");
                }
            }
        }

        /// <summary>
        /// Function to return the size of the stack
        /// </summary>
        /// <returns>returns the size of the stack</returns>
        public int size()
        {
            return top + 1;
        }
    }
}