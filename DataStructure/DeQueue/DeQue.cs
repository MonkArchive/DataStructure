using System;

namespace DeQueue
{
    public class DeQue<T> : IDeQue<T>
    {
        protected T[] list;
        protected int front;
        protected int rear;
        protected int size;
        protected int count;

        public DeQue( int size )
        {
            this.size = size;
            list = new T[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void AddAtFront( T item )
        {
            if (!IsFull())
            {
                front = front == 0 ? size - 1 : front - 1;

                list[front] = item;

                if (rear == -1)
                    rear = front;

                ++count;
            }
            else
                throw new Exception( "Queue is already full" );
        }

        public void AddAtRear( T item )
        {
            if (!IsFull())
            {
                rear = (rear + 1) % size;

                list[rear] = item;

                ++count;
            }
            else
                throw new Exception( "Queue is already full" );
        }

        public void Clear()
        {
            front = 0;
            rear = -1;
            count = 0;
        }

        public int Count()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == size - 1;
        }

        public T PeekFront()
        {
            if (!IsEmpty())
                return list[front];
            else
                throw new Exception( "Queue is empty" );
        }

        public T PeekRear()
        {
            if (!IsEmpty())
                return list[rear];
            else
                throw new Exception( "Queue is empty" );
        }

        public T RemoveFromFront()
        {
            if (!IsEmpty())
            {
                T item = list[front];

                front = (front + 1) % size;

                --count;

                return item;
            }
            else
                throw new Exception( "Queue is already empty" );
        }

        public T RemoveFromRear()
        {
            if (!IsEmpty())
            {
                T item = list[rear];

                rear = rear == 0 ? size - 1 : rear - 1;

                --count;

                return item;
            }
            else
                throw new Exception( "Queue is already empty" );
        }
    }

    public interface IDeQue<T>
    {
        void AddAtFront( T item );
        T RemoveFromFront();
        void AddAtRear( T item );
        T RemoveFromRear();
        void Clear();
        bool IsEmpty();
        bool IsFull();
        int Count();
        T PeekFront();
        T PeekRear();
    }
}