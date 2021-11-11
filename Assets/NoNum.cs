using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoNum : MonoBehaviour
{
  /*  int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
    int[] b = { 5, 8, 4, 0, 6, 7, 9 };
    public List<int> num = new List<int>();
    public List<int> noNum = new List<int>();
    void Update()
    {
        int answer = 0;
        for (int i = 0; i < c.Length; i++)
        {
            num.Add(c[i]);
        }

        for (int j = 0; j < b.Length; j++)
        {
            noNum.Add(b[j]);
        }

        foreach (var vl in noNum)
        {
            num.Remove(vl);
        }
        for (int k = 0; k < num.Count; k++)
        {
            answer += num[k];
            print(answer);
        }
    }*/

    public int solution(int[] numbers)
    {
        int answer = 0;
        int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        List<int> num = new List<int>();
        List<int> noNum = new List<int>();
        for (int i = 0; i < c.Length; i++)
        {
            num.Add(c[i]);
        }

        for (int j = 0; j < numbers.Length; j++)
        {
            noNum.Add(numbers[j]);
        }

        foreach (var vl in noNum)
        {
            num.Remove(vl);

        }
        for (int k = 0; k < num.Count; k++)
        {
            answer += num[k];
            print(answer);
        }
        return answer;
    }

}
