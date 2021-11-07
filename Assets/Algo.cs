using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Algo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {




    }

   
        public bool solution(string s)
        {
            bool answer =false;
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
