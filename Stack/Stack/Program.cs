using System;

namespace StackSln
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> s = new Stack<int>(100);

            try
            {
                s.Push(1);
                s.Push(0);
                s.Push(1);

                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
                Console.WriteLine(s.Pop());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
