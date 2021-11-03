using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Nanum : MonoBehaviour
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[] { };
        List<int> num = new List<int>();
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i]%divisor==0)
            {
                num.Add(arr[i]);
            }
        }

        if(num.Count==0)
        {
            num.Add(-1);
        }

        answer = num.ToArray();
        Array.Sort(answer);
        return answer;
    }
}
