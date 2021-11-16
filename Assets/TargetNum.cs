using System.Collections;
using System.Collections.Generic;
using System;

//n개의 음이 아닌 정수가 있습니다. 이 수를 적절히 더하거나 빼서 타겟 넘버를 만들려고 합니다.
//예를 들어 [1, 1, 1, 1, 1]로 숫자 3을 만들려면 다음 다섯 방법을 쓸 수 있습니다.
public class TargetNum 
{
    public int solution(int[] numbers, int target)
    {
        int answer = 0;
        List<int> num = new List<int>();
        List<int> count = new List<int>();

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            num.Add(i);


            
           

        }

        if (answer == target)
        {
            count.Add(answer);
            return count.Count;
        }
        return answer;
    }
}
