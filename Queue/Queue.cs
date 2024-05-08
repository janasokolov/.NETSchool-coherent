namespace Queue
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public Queue()
        {
            _head = null;
            _tail = null;
        }
        
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
        }
        public T Dequeue()
        {
            if(IsEmpty())
            {
                _tail = null;
                throw new InvalidOperationException("Queue is empty");
            }
            T dequeuedData = _head.Data;
            _head = _head.Next;
            
            return dequeuedData;
        }
        public bool IsEmpty()
        {
            return _head == null;
        }
    }
}
