using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Solution
{
    public string solution(string s)
    {
        string answer = s;
        char[] ch = answer.ToCharArray();
        var sort = ch.OrderByDescending(c => c).ToArray();

        answer = new string(sort);

        return answer;
    }
}