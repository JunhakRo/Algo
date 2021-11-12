using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Innerproduct : MonoBehaviour
{

    //길이가 같은 두 1차원 정수 배열 a, b가 매개변수로 주어집니다. a와 b의 내적을 return 하도록 solution 함수를 완성해주세요.
    //이때, a와 b의 내적은 a[0]*b[0] + a[1]*b[1] + ... + a[n - 1]*b[n - 1] 입니다. (n은 a, b의 길이)

   /* private void Update()
    {
        int[] i = { 1, 2, 3, 4 };
        int[] j = { -3, -1, 0, 2 };
        solution(i, j);
    }*/
    public int solution(int[] a, int[] b)
    {
        int answer = 0;
        List<int> num = new List<int>();
        List<int> num2 = new List<int>();

        
        for(int i = 1; i<=a.Length; i++)
        {
            num.Add(a[i - 1]);
            for (int j=1; j<=b.Length; j++)
            {
                num2.Add(b[j - 1]);
            }
        }

        for(int k = 0; k<a.Length; k++)
        {
            answer += num[k] * num2[k];
        }
        return answer;
    }
}
