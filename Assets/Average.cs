using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Average : MonoBehaviour
{
    private void Update()
    {
        int[] a = { 1, 2, 3, 4 };
        solution(a);
    }
    public double solution(int[] arr)
    {


        double answer = 0;
        int a = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            a += arr[i];
        }
        answer = (double)a / arr.Length;
        return answer;

    }
}
