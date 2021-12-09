using System;

namespace HeapSort
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int number = 9;
            int[] heap = { 7, 6, 5, 8, 3, 5, 9, 1, 6 };
            //최대 힙구조로 바꾸는 과정 
            for (int i= 1; i<number; i++)
            {
                int c = i;
                do
                {
                    int root = (c - 1) / 2;
                    if (heap[root] < heap[c])
                    {
                        int temp = heap[root];
                        heap[root] = heap[c];
                        heap[c] = temp;
                    }
                    c = root;
                }
                while (c != 0);
            }

            for(int i = number-1; i>=0; i--)
            {
                int temp = heap[0];
                heap[0] = heap[i];
                heap[i] = temp;
                int root = 0;
                int c = 1;
                do
                {
                    c = 2 * root + 1;
                    if (c<i-1 &&heap[c] < heap[c + 1])
                    {
                        c++;
                    }
                    //heap[root] <heap[c] 루트보다 자식이 더크다면 교환
                    if (c<i &&heap[root] < heap[c])
                    {
                        temp= heap[root];
                        heap[root] = heap[c];
                        heap[c] = temp;
                    }
                    root = c;
                } while (c < i);
            }
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(heap[i]);
            }
        }
       
    }
}
