using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class stringnum : MonoBehaviour
{
    //public string[] solution(string[] strings, int n)
    //{
    //    string[] answer = new string[] { };

    //    answer = strings.OrderBy(name => name).OrderBy(name => name[n]).ToArray();
    //    return answer;
    //}

    public string[] solution()
    {
        string[] strings = { "abc", "cde", "efg", "ghi" };
        string[] answer = new string[strings.Length];
        int n = 1;
       for(int i=0; i<strings.Length; i++)
        {
            answer[i] = strings[i].Substring(n, 1) + strings[i];
            print(i + ":" + answer[i]);
        }
        Array.Sort(answer);

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = answer[i].Substring(1);
            print(i + "2:" + answer[i]);


        }
        return answer;
    }

}
