using System;

namespace StackSln
{
    public class Stack<T> : IStack<T>
    {
        T[] stack;
        int top = -1;
        int size;

        public Stack(int size)
        {
            this.size = size;
            stack = new T[size];
        }

        public void Clear()
        {
            top = -1;
        }

        public int Count()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == size - 1;
        }

        public T Peek()
        {
            if (top != -1)
                return stack[top];
            else
                throw new Exception("Stack Is empty");

            return (T)default;

        }

        public T Pop()
        {
            if (top >= 0)
                return stack[top--];
            else
                throw new Exception("Stack Is empty");

            return (T)default;
        }

        public void Push(T item)
        {
            if (top != size)
                stack[++top] = item;
            else
                throw new Exception("Stack Is AlreadyFull");
        }
    }

    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsFull();
        bool IsEmpty();
        int Count();
        void Clear();
        T Peek();
    }
}
