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
        Node head;
        int size = 0;

        /// <summary>
        /// Function to check if queue is empty
        /// </summary>
        /// <returns>returns true if th queue is empty</returns>
        public bool IsEmpty()
        {
            return size==0;
        }

        /// <summary>
        /// Function to add the data in queue
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void enqueue(Object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;                                
            }
            else
            {
                Node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = node;
            }
            size++;
        }

        /// <summary>
        /// Function to remove data from queue
        /// </summary>
        public void dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is already empty");
                return;
            }
            else 
            {
                head = head.next;                
            }
            size--;
        }

        /// <summary>
        /// Function to print or show data in queue
        /// </summary>
        public void show()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node tempNode = head;
                while (tempNode != null){
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
            return size;
        }

        /// <summary>
        /// Function to get the data in the front queue
        /// </summary>
        /// <returns>returns data in the front from queue</returns>
        public Object get()
        {
            return head.data;
        }
        
    }
}
