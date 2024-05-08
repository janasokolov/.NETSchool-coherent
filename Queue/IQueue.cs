namespace Queue
{
    public interface IQueue<T> 
    {
        void Enqueue(T data);
        T Dequeue();
        bool IsEmpty();
    }
}