using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bae : MonoBehaviour
{
    string[] num = { "zero", "one", "two", "four", "five", "six", "eight", "nine" };
    public int solution(string s)
    {
        int answer = 0;
        int a = Random.Range(s.Length, s.Length);
        int c = int.Parse(s);
        char[] b = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (c == 0) return 0;

            if (c > 0)
            {
                if (Random.Range(s.Length, s.Length) >= 0)
                {
                   
                }

            }


        }
        return answer;
    }
}
