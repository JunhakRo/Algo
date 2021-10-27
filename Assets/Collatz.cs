using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collatz : MonoBehaviour
{

    public int solution(long num)
    {
        //°è»ê È½¼ö
        int answer = 0;

        while (num >= 0)
        {
            if (num == 1)
            {
                break;
            }
            else if (answer >= 500)
            {
                answer = -1;
                break;
            }
            else if (num % 2 == 0)
            {
                num = num / 2;
                answer++;
            }
            else if (num % 2 == 1)
            {
                num = num * 3 + 1;
                answer++;
            }
        }


        return answer;
    }

}
