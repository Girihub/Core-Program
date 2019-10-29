//----------------------------------------------------
// <copyright file="Hash.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DataStructure.Utility;

    /// <summary>
    /// Hash as a class implemented by linked list
    /// </summary>
    public class Hash
    {         
        private int index;
        private LinkedList linkedList;
        int len = 0;

        /// <summary>
        /// Hash constructor
        /// </summary>
        /// <param name="index">index as a parameter</param>
        public Hash(int index)
        {
            this.index = index;
            this.linkedList = new LinkedList();
            len++;
        }    
        
        /// <summary>
        /// Function to add the data
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void add(Object data)
        {            
            this.linkedList.append(data);
            this.linkedList.OrederLinkedList();             
        }

        /// <summary>
        /// Function to show or print the data
        /// </summary>
        public void show()
        {
            for(int i = 0; i < this.len; i++)
            {
                if (this.linkedList.get(i) != null)
                {
                    Console.Write(this.index + " : ");
                    this.linkedList.show();
                    Console.WriteLine();
                }
            }            
        }

        /// <summary>
        /// Function to search given data
        /// </summary>
        /// <param name="input">data, to be searched, as a parameter</param>
        /// <returns>returns true if data if present</returns>
        public bool Search(Object input)
        {
            for(int j = 0; j < this.linkedList.size(); j++)
                {
                    if (this.linkedList.search(input)==true)
                    {
                        return true;
                    }
                }
            return false;
        }

        /// <summary>
        /// Function to remove data
        /// </summary>
        /// <param name="data"></param>
        public void Remove(Object data)
        {
            this.linkedList.remove(data);
        }

    }
}