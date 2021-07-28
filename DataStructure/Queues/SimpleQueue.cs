namespace Queues
{
    abstract public class BaseQueue<T> : IQueue<T>
    {
        protected T[] list;
        protected int front;
        protected int rear;
        protected int size;

        public BaseQueue(int size)
        {
            list = new T[size];
            front = 0;
            rear = -1;
        }

        public virtual void Add(T item)
        {
            list[++rear] = item;
        }

        public virtual void Clear()
        {
            front = 0;
            rear = -1;
        }

        public virtual int Count()
        {
            return rear - front + 1;
        }

        public virtual bool IsEmpty()
        {
            return front == rear + 1;
        }

        public virtual bool IsFull()
        {
            return rear == size - 1;
        }

        public T Peek()
        {
            return list[front];
        }

        public virtual T Remove()
        {
            return list[front++];
        }
    }

    public class SimpleQueue<T> : BaseQueue<T>
    {
        public SimpleQueue(int size) : base (size)
        {

        }
    }

    public interface IQueue<T>
    {
        void Add(T item);
        T Remove();
        void Clear();
        bool IsEmpty();
        bool IsFull();
        int Count();
        T Peek();
    }
}
