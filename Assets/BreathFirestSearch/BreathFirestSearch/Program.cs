using System;
using System.Collections;
using System.Collections.Generic;


namespace BreathFirestSearch
{
    class Program
    {
      static bool[] c = new bool[8];
      static  List<int>[] a = new List<int>[8];

        static void Main()
        {
           for(int i =0; i<a.Length; i++)
            {
                a[i] = new List<int>();
            }
            a[1].Add(2);
            a[2].Add(1);

            a[1].Add(3);
            a[3].Add(1);

            a[2].Add(3);
            a[3].Add(2);

            a[2].Add(4);
            a[4].Add(2);

            a[2].Add(5);
            a[5].Add(2);

            a[3].Add(6);
            a[6].Add(3);

            a[3].Add(7);
            a[7].Add(3);

            a[4].Add(5);
            a[5].Add(4);

            a[6].Add(7);
            a[7].Add(6);

            BFS(1);
        }
        static void BFS(int start)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            c[start] = true;
            while(q.Count>0)
            {
                int x = q.Dequeue();
                Console.WriteLine($"{x}");
                for(int i = 0; i<a[x].Count; i++)
                {
                    int y = a[x][i];
                    if(!c[y])
                    {
                        q.Enqueue(y);
                        c[y] = true;
                    }
                }
            }
        }
    }
}
