using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Utility
{
    public class Deque
    {
        Node head;

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

        public bool IsEmpty()
        {
            return Size() == 0;
        }
    }
}
