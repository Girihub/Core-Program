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

        public bool IsEmpty()
        {
            return top < 0;
        }

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

        public int Size()
        {
            return top + 1;
        }        
    }
}
