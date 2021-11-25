using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int answer = 1 ;
            if (N == 0)
            {
                answer = 1;
            }
            else if (N != 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    answer *= i;
                    
                }

            }
            Console.WriteLine(answer);
        }
    }
}
