using System;
using System.Collections.Generic;

namespace Decomposition
{
    //분해합을 구하라 ;;
    class Program
    {

        //216의 분해합을 198 이다 ...
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            //나머지값 
            int result = 0;
            //나머지값의 합
            int result_sum = 0;
            //증가값 
            int number = 0;

            int sum = 0;
            int answer = 0;
            for (int i = 1; i <= N; i++)
            {
                result = 0;
                result_sum = 0;
                number = i;
                int division = number / 10;
                //나머지의 합 구하는 공식
                while (division > 0)
                {
                    result = number % 10;
                    result_sum += result;

                    number = division;
                    division = (int)number / 10;
                }
                if (division == 0)
                {
                    result = number;
                    result_sum += result;
                }
                sum = i + result_sum;
                if (sum == N)
                {
                    answer = i;
                    Console.WriteLine(answer);
                    return; 
                }
                answer = 0;
            }

            Console.WriteLine(answer);
            
        }



    }
}
