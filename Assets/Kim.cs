using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//�輭�� ã�� 
public class Kim
{
    public string solution(string[] seoul)
    {
        string answer = "";
        
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                answer = "�輭���� " + i + "�� �ִ�";
            }
        }
        return answer;
    }
}
