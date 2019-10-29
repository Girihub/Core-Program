//----------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// LinkedList as a class
    /// </summary>
    public class LinkedList
    {
        Node head;

        /// <summary>
        /// Function to create LinkedList
        /// </summary>
        /// <returns>returns new LinkedList</returns>
        public LinkedList List()
        {
            return new LinkedList();
        }

        /// <summary>
        /// Function to append the data in linked list
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void append(Object data)
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
        /// Function to show or print data in linked list
        /// </summary>
        public void show()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node node = head;
                while (node != null)
                {
                    Console.Write(node.data+" ");
                    node = node.next;
                }
            }
        }

        /// <summary>
        /// Function to add the data at the front
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void add(Object data)
        {
            Node node = new Node();
            node.data = data;
            if (head == null)
            {
                head = node;
                head.next = null;
            }
            else
            {
                Node tempNode = head;
                head = node;
                head.next = tempNode;
            }
        }

        /// <summary>
        /// Function to remove data from the front
        /// </summary>
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

        /// <summary>
        /// Function to remove the data from the end
        /// </summary>
        /// <returns>returns the removed data</returns>
        public Object pop()
        {
            Node tempNodeOne = head;
            Node tempNodeTwo = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.next == null)
            {
                head = null;
                return tempNodeOne.data;
            }
            else
            {                
                while (tempNodeOne.next.next != null)
                {
                    tempNodeOne = tempNodeOne.next;
                }
                tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = null;
            }
            return tempNodeTwo.data;
        }

        /// <summary>
        /// Function to count the size of linked list
        /// </summary>
        /// <returns></returns>
        public int size()
        {
            int count = 0;
            if (head == null)
            {
                return count;
            }
            else
            {
                Node tempNode = head;
                while (tempNode != null)
                {
                    count++;
                    tempNode = tempNode.next;
                }
                return count;
            }
        }

        /// <summary>
        /// Function to insert the data at given index
        /// </summary>
        /// <param name="index">index as a parameter</param>
        /// <param name="data">data as a parameter</param>
        public void insert(int index, Object data)
        {
            Node node = new Node();
            node.data = data;
            if (head == null)
            {
                head = node;
                head.next = null;
            }
            else if(index==0)
            {
                Node tempNodeOne = head;
                head = node;
                head.next = tempNodeOne;
            }
            else
            {
                Node tempNodeOne = head;
                for(int i = 0; i < index-1; i++)
                {
                    tempNodeOne = tempNodeOne.next;
                    if (tempNodeOne.next == null)
                    {
                        Node tempNodeThree = tempNodeOne.next;
                        tempNodeOne.next = node;
                        node.next = tempNodeThree;
                        return;
                    }

                }
                Node tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }

        /// <summary>
        /// Function to remove data from the given index
        /// </summary>
        /// <param name="index">index as a parameter</param>
        /// <returns>returns removed data</returns>
        public Object pop(int index)
        {
            Node node = head;
            Node tempNodeOne = head;
            if (index == 0)
            {
                head = head.next;
                return node.data;
            }
            if(index >= size())
            {                
                return pop();
            }
            for(int i = 0; i < index - 1; i++)
            {
                node = node.next;             
            }
            Node tempNodeTwo = node;
            tempNodeOne = node.next;
            node.next = tempNodeTwo.next.next;
            return tempNodeOne.data;
        }

        /// <summary>
        /// Function to remove given data from linked list
        /// </summary>
        /// <param name="data">data, to be removed, as a parameter</param>
        public void remove(Object data)
        {
            Node tempNode = head, prev = null;
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
               if(tempNode != null && tempNode.data+"" == data+"")
                {
                    head = tempNode.next;
                    return;
                }
               while(tempNode != null && tempNode.data+"" != data+"")
                {
                    prev = tempNode;
                    tempNode = tempNode.next;
                }
                if (tempNode == null)
                {
                    return;
                }
                prev.next = tempNode.next;
            }
        }

        /// <summary>
        /// Function to search the given data in the linked list
        /// </summary>
        /// <param name="data">data, to be searched, as a parameter</param>
        /// <returns>returns true if the given data found</returns>
        public bool search(Object data)
        {
            if (head == null)
            {
                return false;
            }
            Node tempNode = head;            
            while (tempNode != null )
            {
                if (tempNode.data + "" == data + "")
                {
                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }
        
        /// <summary>
        /// Function to check if the linked is empty
        /// </summary>
        /// <returns>returns true if linked list is empty</returns>
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to find index number of given data
        /// </summary>
        /// <param name="data">data as a parameter</param>
        /// <returns>returns index number of given data</returns>
        public int index(Object data)
        {
            int find = 0;
            Node tempNode = head;
            while(tempNode != null && tempNode.data+"" != data + "")
            {
                tempNode = tempNode.next;
                find++;
            }
            if (tempNode == null)
            {
                return -1;
            }
            return find;
        }
        
        /// <summary>
        /// Function to get the data by index number
        /// </summary>
        /// <param name="index">index number as a parameter</param>
        /// <returns>returns data from given index number</returns>
        public Object get(int index)
        {
            Node tempNode = head;
            if (head == null)
            {
                return null;
            }
            else if (index == 0)
            {
                return tempNode.data;
            }
            else
            {
                if (index >= size())
                {
                    return null;
                }
                for(int i = 0; i < index-1; i++)
                {
                    tempNode = tempNode.next;
                }
                tempNode = tempNode.next;
                return tempNode.data;
            }
        }

        /// <summary>
        /// Function to replace or put data at given index number
        /// </summary>
        /// <param name="index">index number as a parameter</param>
        /// <param name="data">data as a parameter</param>
        public void put(int index, Object data)
        {
            Node node = new Node();
            node.data = data;
            if (head.next == null)
            {
                head = node;
                node.next = null;
            }
            else if(index == 0)
            {
                Node tempNode = head.next;
                head = node;
                node.next = tempNode;
            }else if (index == 1)
            {
                Node tempNode = head.next.next;
                head.next = node;
                node.next = tempNode;                
            } 
            else
            {
                Node tempNodeOne = head;
                for (int i = 0; i < index - 1; i++)
                {
                    tempNodeOne = tempNodeOne.next;
                }
                Node tempNodeTwo = tempNodeOne.next.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }

        /// <summary>
        /// Function to add the data in linked list by ascending order
        /// </summary>
        /// <param name="data">data as a parameter</param>
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
                Node tempNodeOne = head;
                while(tempNodeOne.next != null && Convert.ToInt32(tempNodeOne.next.data) < Convert.ToInt32(data)){
                    tempNodeOne = tempNodeOne.next;
                }
                Node tempNodeTwo = tempNodeOne.next;
                tempNodeOne.next = node;
                node.next = tempNodeTwo;
            }
        }
      
        /// <summary>
        /// Function to arrange linked list in ascending order
        /// </summary>
        public void OrederLinkedList()
        {
            if (this.size() < 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < this.size(); i++)
                {
                    for (int j = 0; j < this.size() - 1; j++)
                    {
                        if (Convert.ToInt32(this.get(j)) > Convert.ToInt32(this.get(j + 1)))
                        {
                            int temp = Convert.ToInt32(this.get(j));
                            this.put(j, this.get(j + 1));
                            this.put(j + 1, temp);
                        }
                    }
                }
            }
        }
    }
}
