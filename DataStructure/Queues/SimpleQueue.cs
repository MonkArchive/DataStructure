using System;

namespace Queues
{
    abstract public class BaseCircularQueue<T> : IQueue<T>
    {
        protected T[] list;
        protected int front;
        protected int rear;
        protected int size;

        public BaseCircularQueue(int size)
        {
            this.size = size;
            list = new T[size];
            front = 0;
            rear = -1;
        }

        public virtual void Add(T item)
        {
            if (!IsFull())
            {
                rear = (rear + 1) % size;

                list[rear] = item;
            }
            else
                throw new Exception("Queue is already full");
        }

        public virtual void Clear()
        {
            front = 0;
            rear = -1;
        }

        public abstract int Count();
        public abstract bool IsEmpty();
        public abstract bool IsFull();

        public virtual T Peek()
        {
            if (!IsEmpty())
                return list[front];
            else
                throw new Exception("Queue is empty");
        }

        public virtual T Remove()
        {
            if (!IsEmpty())
            {
                T item = list[front];

                front = (front + 1) % size;

                return item;
            }
            else
                throw new Exception("Queue is already empty");
        }
    }

    public class EmptyLocationQueue<T> : BaseCircularQueue<T>
    {
        public EmptyLocationQueue(int size) : base(size) {}

        public override int Count()
        {
            if (front <= rear)
                return rear - front + 1;
            else
                return (size - front) + rear + 1;
        }

        public override bool IsEmpty()
        {
            return front == (rear + 1) % size;
        }

        public override bool IsFull()
        {
            return (front == rear + 2) ||
                (front == 0 && rear == size - 2) ||
                (front == 1 && rear == size - 1);
        }
    }

    public class CircularSpecialValueQueue<T> : BaseCircularQueue<T>
    {
        public CircularSpecialValueQueue(int size) : base (size) {}

        public override int Count()
        {
            if (front <= rear)
                return rear - front + 1;
            else
                return (size - front) + rear + 1;
        }

        public override bool IsEmpty()
        {
            return (rear == -1); // (front == 0) && (rear == -1);
        }

        public override bool IsFull()
        {
            return (front == (rear + 1) % size) && (rear != -1);

            // return ((front == rear + 1) && (rear != -1)) || ((rear == size - 1 && front == 0));
        }

        public override T Remove()
        {
            // Check If It Is The Last Item In The Queue
            if (front == rear)
            {
                var item = base.Remove();
                Clear();
                return item;
            }
            else
                return base.Remove();
        }
    }

    public class CircularCountQueue<T> : BaseCircularQueue<T>
    {
        protected int count;

        public CircularCountQueue(int size) : base (size)
        {
            count = 0;
        }

        public override int Count()
        {
            return count;
        }

        public override bool IsEmpty()
        {
            return count == 0;
        }

        public override bool IsFull()
        {
            return count == size;
        }

        public override void Add(T item)
        {
            base.Add(item);

            count++;
        }

        public override T Remove()
        {
            T item = base.Remove();

            count--;

            return item;
        }

        public override void Clear()
        {
            base.Clear();
            count = 0;
        }
    }

    abstract public class BaseLinearQueue<T> : IQueue<T>
    {
        protected T[] list;
        protected int front;
        protected int rear;
        protected int size;

        public BaseLinearQueue(int size)
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

    public class SimpleQueue<T> : BaseLinearQueue<T>
    {
        public SimpleQueue(int size) : base(size)
        {

        }
    }

    public class FixedFrontQueue<T> : BaseLinearQueue<T>
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

    public class BulkShiftQueue<T> : BaseLinearQueue<T>
    {
        public BulkShiftQueue(int size) : base(size) { }

        public override void Add(T item)
        {
            // I am going to shift elements when (Rear == Size-1 && Front != 0)
            if (rear == size-1 && front != 0)
            {
                for (int i = front; i <= rear; i++)
                    list[i - front] = list[i];
                rear = rear - front;
                front = 0;
            }

            // If Queue Is Not Full, Add The Element
            base.Add(item);
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
