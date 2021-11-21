using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Ngamingonbauu : MonoBehaviour
{
    private void Start()
    {
       
        int[] a = { 14, 6, 8, 2 };
        solution(a);
    }
    public List<int> num = new List<int>();
    public int solution(int[] arr)
    {
        int answer = 1;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==2)
            { num.Add(arr[i]); }
          else if(arr[i]%num[0] == 0)
            {
                num.Add(arr[i]/num[0]);
            }
           else
            {
                num.Add(arr[i]);
            }
        }

        for (int j = 0; j < num.Count; j++)
        {
            answer *= num[j];
            print(answer);
        }
        return answer;
    }
}
