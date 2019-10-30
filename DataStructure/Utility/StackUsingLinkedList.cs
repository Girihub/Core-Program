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
        /// <summary>
        /// Node as head
        /// </summary>
        private Node head;

        /// <summary>
        /// initialize top with -1
        /// </summary>
        private int top = -1;

        /// <summary>
        /// Function to add the data in stack
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void Push(object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                node.next = null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                node.next = tempNode;
            }

            this.top++;
        }

        /// <summary>
        /// Function to delete data from the stack
        /// </summary>
        public void Pop()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }

            this.head = this.head.next;
            this.top--;
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
                Console.WriteLine("Stack is empty");
                return;
            }

            Node tempNode = this.head;
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
            return this.top + 1;
        }        
    }
}
