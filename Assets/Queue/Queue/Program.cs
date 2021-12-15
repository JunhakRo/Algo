using System;
using System.Collections;


namespace Queue1
{
    //큐 Dequeue 출력하는 메세지
    //Enqueue 
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(9);
            q.Enqueue(8);
            q.Enqueue(7);
            q.Dequeue();
            q.Enqueue(6);
            q.Dequeue();
            while(q.Count>0)
            {
                Console.WriteLine(q.Dequeue());
                //물어볼거 !!
            }



        }
    }
}
