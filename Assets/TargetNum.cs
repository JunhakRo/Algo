using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

//n���� ���� �ƴ� ������ �ֽ��ϴ�. �� ���� ������ ���ϰų� ���� Ÿ�� �ѹ��� ������� �մϴ�.
//���� ��� [1, 1, 1, 1, 1]�� ���� 3�� ������� ���� �ټ� ����� �� �� �ֽ��ϴ�.
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
