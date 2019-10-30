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
        /// <summary>
        /// Assume node as a head
        /// </summary>
        private Node head;

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
        public void Append(object data)
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
        /// Function to show or print data in linked list
        /// </summary>
        public void Show()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node node = this.head;
                while (node != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
            }
        }

        /// <summary>
        /// Function to add the data at the front
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void Add(object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
            }
            else
            {
                Node tempNode = this.head;
                this.head = node;
                this.head.next = tempNode;
            }
        }

        /// <summary>
        /// Function to remove data from the front
        /// </summary>
        public void Shift()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                this.head = this.head.next;
            }
        }

        /// <summary>
        /// Function to remove the data from the end
        /// </summary>
        /// <returns>returns the removed data</returns>
        public object Pop()
        {
            Node tempNodeOne = this.head;
            Node tempNodeTwo = this.head;
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (this.head.next == null)
            {
                this.head = null;
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
        /// <returns>returns size of list</returns>
        public int Size()
        {
            int count = 0;
            if (this.head == null)
            {
                return count;
            }
            else
            {
                Node tempNode = this.head;
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
        public void Insert(int index, object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
            }
            else if (index == 0)
            {
                Node tempNodeOne = this.head;
                this.head = node;
                this.head.next = tempNodeOne;
            }
            else
            {
                Node tempNodeOne = this.head;
                for (int i = 0; i < index - 1; i++)
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
        public object Pop(int index)
        {
            Node node = this.head;
            Node tempNodeOne = this.head;
            if (index == 0)
            {
                this.head = this.head.next;
                return node.data;
            }

            if (index >= this.Size())
            {                
                return this.Pop();
            }

            for (int i = 0; i < index - 1; i++)
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
        public void Remove(object data)
        {
            Node tempNode = this.head, prev = null;
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                if (tempNode != null && tempNode.data + string.Empty == data + string.Empty)
                {
                    this.head = tempNode.next;
                    return;
                }

                while (tempNode != null && tempNode.data + string.Empty != data + string.Empty)
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
        public bool Search(object data)
        {
            if (this.head == null)
            {
                return false;
            }

            Node tempNode = this.head;            
            while (tempNode != null)
            {
                if (tempNode.data + string.Empty == data + string.Empty)
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
            if (this.head == null)
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
        public int Index(object data)
        {
            int find = 0;
            Node tempNode = this.head;
            while (tempNode != null && tempNode.data + string.Empty != data + string.Empty)
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
        public object Get(int index)
        {
            Node tempNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            else if (index == 0)
            {
                return tempNode.data;
            }
            else
            {
                if (index >= this.Size())
                {
                    return null;
                }

                for (int i = 0; i < index - 1; i++)
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
        public void Put(int index, object data)
        {
            Node node = new Node();
            node.data = data;
            if (this.head.next == null)
            {
                this.head = node;
                node.next = null;
            }
            else if (index == 0)
            {
                Node tempNode = this.head.next;
                this.head = node;
                node.next = tempNode;
            }
            else if (index == 1)
            {
                Node tempNode = this.head.next.next;
                this.head.next = node;
                node.next = tempNode;                
            } 
            else
            {
                Node tempNodeOne = this.head;
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
        public void AddOrder(object data)
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
                Node tempNodeOne = this.head;
                while (tempNodeOne.next != null && Convert.ToInt32(tempNodeOne.next.data) < Convert.ToInt32(data))
                {
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
            if (this.Size() < 2)
            {
                return;
            }
            else
            {
                for (int i = 0; i < this.Size(); i++)
                {
                    for (int j = 0; j < this.Size() - 1; j++)
                    {
                        if (Convert.ToInt32(this.Get(j)) > Convert.ToInt32(this.Get(j + 1)))
                        {
                            int temp = Convert.ToInt32(this.Get(j));
                            this.Put(j, this.Get(j + 1));
                            this.Put(j + 1, temp);
                        }
                    }
                }
            }
        }
    }
}