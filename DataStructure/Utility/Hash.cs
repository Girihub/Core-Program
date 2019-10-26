using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Utility;

namespace DataStructure.Utility
{
    public class Hash
    {         
        private int index;
        private LinkedList linkedList;
        int len = 0;

        public Hash(int index)
        {
            this.index = index;
            this.linkedList = new LinkedList();
            len++;
        }    
        
        public void add(Object data)
        {            
            this.linkedList.append(data);
            this.linkedList.OrederLinkedList();             
        }

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

        public void Remove(Object data)
        {
            this.linkedList.remove(data);
        }

    }
}
