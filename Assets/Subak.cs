using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Subak : MonoBehaviour
{
    public string solution(int n)
    {
        string answer = "";
        string a = "¼ö¹Ú";
        char[] ch = a.ToCharArray();
        for (int i = 0; i < n; i++)
        {
            answer += ch[i % 2];
           

        }
        return answer;
    }
}
