using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Utility
{
    public class LinkedList
    {
        Node head;

        public LinkedList List()
        {
            return new LinkedList();
        }

        public void append(Object data)
        {
            Node n = new Node();
            n.data = data;
            n.next = null;
            if (head == null)
            {
                head = n;
            }
            else
            {
                Node n1 = head;
                while (n1.next != null)
                {
                    n1 = n1.next;
                }
                n1.next = n;
            }
        }

        public void show()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node n = head;
                while (n != null)
                {
                    Console.Write(n.data+" ");
                    n = n.next;
                }
            }
        }

        public void add(Object data)
        {
            Node n = new Node();
            n.data = data;
            if (head == null)
            {
                head = n;
                head.next = null;
            }
            else
            {
                Node n1 = head;
                head = n;
                head.next = n1;
            }
        }

        public void shift()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {                
                head = head.next;
            }
        }

        public Object pop()
        {
            Node n = head;
            Node n1 = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.next == null)
            {
                head = null;
                return n.data;
            }
            else
            {                
                while (n.next.next != null)
                {
                    n = n.next;
                }
                n1 = n.next;
                n.next = null;
            }
            return n1.data;
        }

        public int size()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            else
            {
                Node n = head;
                while (n != null)
                {
                    count++;
                    n = n.next;
                }
                return count;
            }
        }

        public void insert(int index, Object data)
        {
            Node n = new Node();
            n.data = data;
            if (head == null)
            {
                head = n;
                head.next = null;
            }
            else if(index==0)
            {
                Node n1 = head;
                head = n;
                head.next = n1;
            }
            else
            {
                Node n1 = head;
                for(int i = 0; i < index-1; i++)
                {
                    n1 = n1.next;
                    if (n1.next == null)
                    {
                        Node n3 = n1.next;
                        n1.next = n;
                        n.next = n3;
                        return;
                    }

                }
                Node n2 = n1.next;
                n1.next = n;
                n.next = n2;
            }
        }

        public Object pop(int index)
        {
            Node n = head;
            Node n2 = head;
            if (index == 0)
            {
                head = head.next;
                return n.data;
            }
            if(index >= size())
            {                
                return pop();
            }
            for(int i = 0; i < index - 1; i++)
            {
                n = n.next;             
            }
            Node n1 = n;
            n2 = n.next;
            n.next = n1.next.next;
            return n2.data;
        }

        public void remove(Object data)
        {
            Node n = head, prev = null;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
               if(n!=null && n.data+"" == data+"")
                {
                    head = n.next;
                    return;
                }
               while(n!=null && n.data+"" != data+"")
                {
                    prev = n;
                    n = n.next;
                }
                if (n == null)
                {
                    return;
                }
                prev.next = n.next;
            }
        }

        public bool search(Object data)
        {
            if (head == null)
            {
                return false;
            }
            Node n = head;            
            while (n != null )
            {
                if (n.data + "" == data + "")
                {
                    return true;
                }
                n = n.next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        public int index(Object data)
        {
            int find = 0;
            Node n = head;
            while(n!=null && n.data+"" != data + "")
            {
                n = n.next;
                find++;
            }
            if (n == null)
            {
                return -1;
            }
            return find;
        }
        
        public Object get(int index)
        {
            Node n = head;
            if (head == null)
            {
                return null;
            }
            else if (index == 0)
            {
                return n.data;
            }
            else
            {
                if (index >= size())
                {
                    return null;
                }
                for(int i = 0; i < index-1; i++)
                {
                    n = n.next;
                }
                n = n.next;
                return n.data;
            }
        }

        public void put(int index, Object data)
        {
            Node n = new Node();
            n.data = data;
            if (head.next == null)
            {
                head = n;
                head.next = null;
            }
            else if(index == 0)
            {
                Node n1 = head.next;
                head = n;
                head.next = n1;
            }
            {
                Node n2 = head;
                for (int i = 0; i < index - 1; i++)
                {
                    n2 = n2.next;
                }
                Node n3 = n2.next.next; ;
                n2.next = n;
                n.next = n3;
            }
        }

        public void addOrder(Object data)
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
                Node n = head;
                while(n.next!=null && Convert.ToInt32(n.next.data) < Convert.ToInt32(data)){
                    n = n.next;
                }
                Node n1 = n.next;
                n.next = node;
                node.next = n1;
            }
        }
    }
}
