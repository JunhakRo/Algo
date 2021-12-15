using System;
using System.Collections;

namespace stack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(7);
            s.Push(5);
            s.Push(4);
            s.Pop();
            s.Push(6);
            s.Pop();
            while(s.Count!=0)
            {
                Console.WriteLine(s.Pop());
            }

        }
    }
}
