//----------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace DataStructure.Utility
{
    using System;

    /// <summary>
    /// Queue as a class
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// limit of queue
        /// </summary>
        private static int limit = 1000;

        /// <summary>
        /// front, rear and size are fields
        /// </summary>
        private int front, rear, size = 0;        

        /// <summary>
        /// create array
        /// </summary>
        private object[] queue = new object[limit];

        /// <summary>
        /// Function to add the data in queue
        /// </summary>
        /// <param name="data">data, to be added, as a parameter</param>
        public void Enqueue(object data)
        {
            if (!this.IsFull())
            {
                this.queue[this.rear] = data;
                this.rear = (this.rear + 1) % limit;
                this.size++;
            }            
        }

        /// <summary>
        /// Function to show or print the data in queue
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < this.size; i++)
            {
                Console.Write(this.queue[(i + this.front) % limit] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Function to remove the data from queue
        /// </summary>
        public void Dequeue()
        {
            if (!this.IsEmpty())
            {
            this.size--;
            object value = this.queue[this.front];
            this.front = (this.front + 1) % limit;            
            }
        }

        /// <summary>
        /// Function to get the size of queue
        /// </summary>
        /// <returns>returns the size of queue</returns>
        public int Size()
        {
            return this.size;
        }

        /// <summary>
        /// Function to check if queue is empty
        /// </summary>
        /// <returns>returns true if queue is empty</returns>
        public bool IsEmpty()
        {
            return this.Size() == 0;
        }

        /// <summary>
        /// Function to check if queue is full
        /// </summary>
        /// <returns>returns true if the queue is full</returns>
        public bool IsFull()
        {
            return this.Size() == limit;
        }

        /// <summary>
        /// Function to get the data at front
        /// </summary>
        /// <returns>returns data ta the front</returns>
        public object Get()
        {
            return this.queue[this.front % limit];
        }
    }
}
