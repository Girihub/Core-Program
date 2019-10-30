//----------------------------------------------------
// <copyright file="QueueUsingLinkedList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// QueueUsingLinkedList as a class to implement queue by linked list
    /// </summary>
    public class QueueUsingLinkedList
    {
        /// <summary>
        /// Node as head
        /// </summary>
        private Node head;

        /// <summary>
        /// initialize size
        /// </summary>
        private int size = 0;

        /// <summary>
        /// Function to check if queue is empty
        /// </summary>
        /// <returns>returns true if the queue is empty</returns>
        public bool IsEmpty()
        {
            return this.size == 0;
        }

        /// <summary>
        /// Function to add the data in queue
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void Enqueue(object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (this.head == null)
            {
                this.head = node;                                
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                tempNode.next = node;
            }

            this.size++;
        }

        /// <summary>
        /// Function to remove data from queue
        /// </summary>
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is already empty");
                return;
            }
            else 
            {
                this.head = this.head.next;                
            }

            this.size--;
        }

        /// <summary>
        /// Function to print or show data in queue
        /// </summary>
        public void Show()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode != null)
                {
                    Console.Write(tempNode.data + " ");
                    tempNode = tempNode.next;
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Function to calculate the elements in queue
        /// </summary>
        /// <returns>returns total no. of elements in queue</returns>
        public int Size()
        {
            return this.size;
        }

        /// <summary>
        /// Function to get the data in the front queue
        /// </summary>
        /// <returns>returns data in the front from queue</returns>
        public object Get()
        {
            return this.head.data;
        }        
    }
}