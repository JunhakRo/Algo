using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class squareroot : MonoBehaviour
{




    public long solution(long n)
    {
        long answer = 0;

        long x = (long)Math.Sqrt(n);

        if (x * x == n)
        {
            answer = (x + 1) * (x + 1);
        }
        else if (x * x != n)
        {
            answer = -1;
        }
        return answer;
    }
}

