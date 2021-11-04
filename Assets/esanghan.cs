using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class esanghan : MonoBehaviour
{
    public string solution(string s)
    {
        int gongback = 0;
        string answer = "";

        char[] ch = s.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            if (ch[i] == ' ')
            {
                gongback = 0;
                continue;
            }

            if (gongback % 2 == 0)
            {
                ch[i] = Char.ToUpper(ch[i]);
            }
            else if (gongback % 2 != 0)
            {
                ch[i] = Char.ToLower(ch[i]);
            }

            gongback++;
            answer = new string(ch);

        }
        return answer;
    }
}
