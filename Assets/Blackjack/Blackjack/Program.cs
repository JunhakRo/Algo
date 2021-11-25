using System;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int[] NM = NMData(num);

            num = Console.ReadLine();
            int[] NData = NMData(num);

            Console.WriteLine(Jack(NM, NData));
        }


        private static int[] NMData(string num)
        {
            string[] temp = num.Split(',');
            int[] numtemp = new int[temp.Length];
            int idx = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                numtemp[idx] = Int32.Parse(temp[i]);
                idx++;
            }
            return numtemp;
        }

        static int Jack(int[] NM, int[] nData)
        {
            int maxSum = NM[1];
            int Sum;
            int minSum = 0;
            for (int i = 0; i < nData.Length - 2; i++)
            {
                for (int j = i + 1; j < nData.Length - 1; j++)
                {
                    for (int k = j + 1; k < nData.Length; k++)
                    {
                        Sum = nData[i] + nData[j] + nData[k];

                        if (Sum == maxSum) return Sum;
                        if (Sum > maxSum) continue;

                        if (maxSum - Sum < maxSum - minSum) minSum = Sum;

                    }
                }
            }
            return minSum;
        }

    }


}
