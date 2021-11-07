using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonJa : MonoBehaviour
{
    public bool solution(string s)
    {
        bool answer = false;
        int b;

        if (s.Length == 4 || s.Length == 6)
        {
            if (int.TryParse(s, out b))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

        }
        return answer;
    }
}
