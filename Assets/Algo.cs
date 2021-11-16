using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Algo : MonoBehaviour
{
    private void Update()
    {
        int[] a = { 1, 1, 1, 1, 1 };
        solution(a,3);
    }
    public int solution(int[] numbers, int target)
    {
        int answer = 0;
        List<int> num = new List<int>();
        List<int> count = new List<int>();


        for (int i = 0; i < numbers.Length; i++)
        {
            num.Add(i);

            int a = Random.Range(0, 2);
            if (a == 0)
            {
                num[i] = -num[i];
            }
            else if (a == 1)
            {
                num[i] = num[i];
            }
            answer += num[i];

            print(answer);
        if (answer == target)
        {
            count.Add(answer);
            print(count.Count);
        }

        }

        return answer;
    }

}
