using System;

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
            this.size = size;
            list = new T[size];
            front = 0;
            rear = -1;
        }

        public virtual void Add(T item)
        {
            if (!IsFull())
                list[++rear] = item;
            else
                throw new Exception("Queue is already full");
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
            if (!IsEmpty())
                return list[front];
            else
                throw new Exception("Queue is empty");
        }

        public virtual T Remove()
        {
            if (!IsEmpty())
                return list[front++];
            else
                throw new Exception("Queue is already empty");
        }
    }

    public class SimpleQueue<T> : BaseQueue<T>
    {
        public SimpleQueue(int size) : base(size)
        {

        }
    }

    public class FixedFrontQueue<T> : BaseQueue<T>
    {
        public FixedFrontQueue(int size) : base(size) { }

        public override T Remove()
        {
            // Remove The Item
            T item = base.Remove();

            // Shift All Items Up
            for (int i = front; i <= rear; i++)
                list[i - 1] = list[i];

            // Update Our Pointers
            front--;
            rear--;

            // Return The Item
            return item;
        }
    }

    public class BulkShiftQueue<T> : BaseQueue<T>
    {
        public BulkShiftQueue(int size) : base(size) { }

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
