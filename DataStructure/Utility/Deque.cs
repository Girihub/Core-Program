//----------------------------------------------------
// <copyright file="Deque.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Deque as a class
    /// </summary>
    public class Deque
    {
        /// <summary>
        /// Assume node as a head
        /// </summary>
        private Node head;
        
        /// <summary>
        /// Function to add data to the front
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void AddFront(object data)
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
        }

        /// <summary>
        /// Function to add data to the rear
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void AddRear(object data)
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
        }

        /// <summary>
        /// Function to remove data from the front
        /// </summary>
        /// <returns>Returns removed data</returns>
        public object RemoveFront()
        {
            if (this.head == null)
            {
                return null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = this.head.next;
                return tempNode.data;
            }
        }

        /// <summary>
        /// Function to remove data at the rear
        /// </summary>
        /// <returns>Returns removed data</returns>
        public object RemoveRear()
        {
            if (this.head == null)
            {
                return null;
            }
            else if (this.head.next == null)
            {
                Node tempNode = this.head;
                this.head = null;
                return tempNode.data;
            }
            else
            {
                Node tempNode = this.head;
                while (tempNode.next.next != null)
                {
                    tempNode = tempNode.next;
                }

                Node tempNode1 = tempNode;
                tempNode.next = null;
                return tempNode1.data;
            }
        }

        /// <summary>
        /// Function to count size
        /// </summary>
        /// <returns>Returns size</returns>
        public int Size()
        {
            int count = 0;
            if (this.head == null)
            {
                return count;
            }
            else
            {
                Node node = this.head;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }

                return count;
            }
        }

        /// <summary>
        /// Function to check if queue is empty
        /// </summary>
        /// <returns>Returns true if empty. False otherwise</returns>
        public bool IsEmpty()
        {
            return this.Size() == 0;
        }
    }
}
