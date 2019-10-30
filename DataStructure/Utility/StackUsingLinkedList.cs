//----------------------------------------------------
// <copyright file="StackUsingLinkedList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StackUsingLinkedList as a class
    /// </summary>
    public class StackUsingLinkedList
    {
        Node head;
        int top = -1;

        /// <summary>
        /// Function to add the data in stack
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void push(Object data)
        {
            Node node = new Node();
            node.data = data;
            if (head == null)
            {
                head = node;
                node.next = null;
            }
            else
            {
                Node tempNode = head;
                head = node;
                node.next = tempNode;
            }
            top++;
        }

        /// <summary>
        /// Function to delete data from the stack
        /// </summary>
        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            head = head.next;
            top--;
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
                Console.WriteLine("Stack is empty");
                return;
            }
            Node tempNode = head;
            while (tempNode != null)
            {
                Console.Write(tempNode.data + " ");
                tempNode = tempNode.next;
            }
        }

        /// <summary>
        /// Function to return the size of the stack
        /// </summary>
        /// <returns>Returns the size of the stack</returns>
        public int Size()
        {
            return top + 1;
        }        
    }
}
