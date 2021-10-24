using System;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections.Generic;

public class Nums
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[] { };
        List<int> numList = new List<int>();
        int num1 = 0;
        int num2 = 0;

       
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                num1 = numbers[i];
                num2 = numbers[j];
                numList.Add(num1 + num2);
            }
        }


        numList = numList.Distinct().ToList();

       
        answer = numList.ToArray();
        Array.Sort(answer);

        return answer;
    }
}
