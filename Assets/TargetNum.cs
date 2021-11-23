using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

//n개의 음이 아닌 정수가 있습니다. 이 수를 적절히 더하거나 빼서 타겟 넘버를 만들려고 합니다.
//예를 들어 [1, 1, 1, 1, 1]로 숫자 3을 만들려면 다음 다섯 방법을 쓸 수 있습니다.
public class TargetNum: MonoBehaviour
{
    public List<int> num = new List<int>();
    private void Start()
    {
        int[] a = { 1, 1, 1, 1, 1 };
        int b = 3;
        solution(a,b);
    }
    public int tar;
    public int answer = 0;
    public int solution(int[] numbers, int target)
    {
        tar = target;
        Calculate(0, 0, numbers);
        return answer;
    }

    private void Calculate(int v1, int v2, int[] numbers)
    {
        if (v2 < numbers.Length)
        {
            Calculate(v1 + numbers[v2], v2 + 1, numbers);
            Calculate(v1 - numbers[v2], v2 + 1, numbers);
        }
        else if (v1 == tar)
        {
            answer++;
            print(answer);
        }

        
    }

    private int Plus(int v1, bool v2)
    {
        if (v2) return v1;
        else return (-1) * v1;
    }
}
