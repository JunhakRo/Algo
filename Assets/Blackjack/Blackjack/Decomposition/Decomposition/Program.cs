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
            List<int> sumList = new List<int>();
            string N_num = Console.ReadLine();
            int N = int.Parse(N_num);
            //나머지값 
            int result = 0;
            //나머지값의 합
            int result_sum = 0;
            //증가값 
            int number = AddNum(N);

            if (number < N)
            {

                number++;

                int division = (int)number / 10;


                //나머지의 합 구하는 공식
                while (division > 0)
                {

                    result = N % 10;
                    result_sum += result;


                    N = division;
                    division = (int)N / 10;


                }
                if (division == 0)
                {
                    result = N;
                    result_sum += result;
                }

                if (result_sum + number == N)
                {
                    sumList.Add(number);
                    Console.WriteLine(sumList[0]);
                }

            }
        }



    }
}
