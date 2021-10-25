using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//김서방 찾기 
public class Kim
{
    public string solution(string[] seoul)
    {
        string answer = "";
        
        for (int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
                answer = "김서방은 " + i + "에 있다";
            }
        }
        return answer;
    }
}
