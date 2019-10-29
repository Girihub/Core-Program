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
    /// QueueUsingLinkedList as a class
    /// </summary>
    public class QueueUsingLinkedList
    {
        Node head;
        int size = 0;

        public bool IsEmpty()
        {
            return size==0;
        }

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

        public int Size()
        {
            return size;
        }

        public Object get()
        {
            return head.data;
        }
        
    }
}
