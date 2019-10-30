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
        /// <summary>
        /// set limit of stack
        /// </summary>
        private static int limit = 1000;

        /// <summary>
        /// initialize top with -1
        /// </summary>
        private int top = -1;

        /// <summary>
        /// create array
        /// </summary>
        private object[] stack = new object[limit];

        /// <summary>
        /// Function to add the data in stack
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void Push(object data)
        {
            if (this.top >= limit - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                this.top = this.top + 1;
                this.stack[this.top] = data;
            }
        }

        /// <summary>
        /// Function to delete data from the stack
        /// </summary>
        public void Pop()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                this.top--;
            }
        }

        /// <summary>
        /// Function to get the data at the top of the stack
        /// </summary>
        public void Peek()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }

            Console.WriteLine(this.stack[this.top]);
            return;
        }

        /// <summary>
        /// Function to check if the stack is empty
        /// </summary>
        /// <returns>Returns true if the stack is empty</returns>
        public bool IsEmpty()
        {
            return this.top < 0;
        }

        /// <summary>
        /// Function to print the elements in the stack
        /// </summary>
        public void Print()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                for (int i = this.top; i >= 0; i--)
                {
                    Console.Write(this.stack[i] + " ");
                }
            }
        }

        /// <summary>
        /// Function to return the size of the stack
        /// </summary>
        /// <returns>returns the size of the stack</returns>
        public int Size()
        {
            return this.top + 1;
        }
    }
}