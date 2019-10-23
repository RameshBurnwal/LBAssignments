using System;
using System.Collections.Generic;
using System.Text;

namespace LBAssignments.Queue.CreateQueue
{
    public class LBQueue
    {
        int front;
        int rear;
        int capacity;
        int[] Items = new int[4];
        public LBQueue()
        {
            front = -1;
            rear = -1;
            capacity = Items.Length;
        }

        public bool IsFull()
        {
            if (rear + 1 % capacity == front)
                return true;
            else
                return false;
        }

        public bool IsEmpty()
        {
            if (front == -1)
                return true;
            else return false;
        }

        private int GetSize()
        {
            return (capacity - front + rear + 1) % capacity;
        }

        public void Enqueue(int ele)
        {
            if (IsFull())
                Console.WriteLine("queue is full") ;
            else
            {
                rear = (rear + 1) % capacity;
                Items[rear] = ele;
                if (front == -1)
                    front = rear;

            }

        }

        public int Dequeue()
        {
            int ele = 0;
            if (IsEmpty())
                Console.WriteLine("Queue is empty");
            
            ele = Items[front];
            if(front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            front = front + 1 % capacity;
            
            return ele;
        }
    }
}
