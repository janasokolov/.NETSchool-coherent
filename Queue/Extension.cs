﻿namespace Queue
{
    public static class Extension
    {
        public static IQueue<T> Tail<T>(this IQueue<T> queue)
        {
            if (queue.IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var newQueue = new Queue<T>(); 

            queue.Dequeue();

            while (!queue.IsEmpty())
            {
                newQueue.Enqueue(queue.Dequeue());
            }

            return newQueue;
        }
    }
}
