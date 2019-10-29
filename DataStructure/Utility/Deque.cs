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
        Node head;
        /// <summary>
        /// Function to add data to the front
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void AddFront(Object data)
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
        }

        /// <summary>
        /// Function to add data to the rear
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void AddRear(Object data)
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
        }

        /// <summary>
        /// Function to remove data from the front
        /// </summary>
        /// <returns>Returns removed data</returns>
        public Object RemoveFront()
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                Node tempNode = head;
                head = head.next;
                return tempNode.data;
            }
        }

        /// <summary>
        /// Function to remove data at the rear
        /// </summary>
        /// <returns>Returns removed data</returns>
        public Object RemoveRear()
        {
            if (head == null)
            {
                return null;
            }
            else if(head.next==null)
            {
                Node tempNode = head;
                head = null;
                return tempNode.data;
            }
            else
            {
                Node tempNode = head;
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
        /// Function to count size of deque
        /// </summary>
        /// <returns>Returns size of deque</returns>
        public int Size()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    count++;
                    node = node.next;
                }
                return count;
            }
        }

        /// <summary>
        /// Function to check if deque is empty
        /// </summary>
        /// <returns>Returns true if empty. False otherwise</returns>
        public bool IsEmpty()
        {
            return Size() == 0;
        }
    }
}
