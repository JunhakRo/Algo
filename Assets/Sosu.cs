using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sosu : MonoBehaviour
{
    private void Update()
    {
        solution(10);
        
    }
        public List<int> num = new List<int>();
    public int solution(int n)
    {
        int answer = 0;
        bool sosu = true;
        for (int i = 2; i <= n; i++)
        {
            sosu = true;
            
            for (int j = 2; j * j <= i; j++)
            {
                if (i != j && i % j == 0)
                {
                    sosu = false;
                    break;
                }
            }
            if (sosu)
            {
                answer++;
            }

        }
        return answer;
    }
}
