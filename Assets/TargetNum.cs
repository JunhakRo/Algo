using System.Collections;
using System.Collections.Generic;
using System;

//n���� ���� �ƴ� ������ �ֽ��ϴ�. �� ���� ������ ���ϰų� ���� Ÿ�� �ѹ��� ������� �մϴ�.
//���� ��� [1, 1, 1, 1, 1]�� ���� 3�� ������� ���� �ټ� ����� �� �� �ֽ��ϴ�.
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
