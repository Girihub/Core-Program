//----------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Queue as a class
    /// </summary>
    public class Queue
    {
        int front, rear, size=0;
        static int limit = 100;
        Object[] queue = new Object[limit];
        public void enqueue(Object data)
        {
            if (!IsFull())
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
            Console.WriteLine();
        }

        public void dequeue()
        {
            if (!IsEmpty())
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

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public bool IsFull()
        {
            return Size() == limit;
        }

        public Object get()
        {
            return queue[(front)%limit];
        }
    }
}
