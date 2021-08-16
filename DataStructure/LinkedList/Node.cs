﻿using System;

namespace LinkedList
{
    public class Node<T> : INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }

        public Node()
        {
            Data = default;
            Next = null;
        }

        public Node( T element )
        {
            Data = element;
            Next = null;
        }

        public INode<T> Create( T element )
        {
            try
            {
                return new Node<T>
                {
                    Data = element,
                    Next = null
                };

            }
            catch (Exception)
            {
                throw new Exception( "There seems to be not enough memory" );
            }
        }

        public void Display()
        {
            Console.Write( Data );

            Console.Write( Next != null ? " -> " : "\n" );

            //if (Next != null)
            //    Console.Write( " -> " );
            //else
            //    Console.WriteLine();
        }
    }

    public interface INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }

        INode<T> Create( T element );

        void Display();
    }
}
