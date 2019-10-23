using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Utility
{
    public class Queue
    {
        int front, rear, size=0;
        static int limit = 100;
        Object[] queue = new Object[limit];
        public void enqueue(Object data)
        {
            if (!isFull())
            {
                queue[rear] = data;
                rear = (rear + 1) % limit;
                size++;
            }            
        }

        public void show()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Write(queue[(i + front)% limit] +" ");
            }
        }

        public void dequeue()
        {
            if (!isEmpty())
            {
            size--;
            Object value = queue[front];
            front=(front+1)% limit;            
            }
        }

        public int Size()
        {
            return size;
        }

        public bool isEmpty()
        {
            return Size() == 0;
        }

        public bool isFull()
        {
            return Size() == limit;
        }
    }
}
