using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Algo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string s = "try hello world";
        int gongback = 0;
        string answer = "";
        
        char[] ch = s.ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            if(ch[i]==' ')
            {
                gongback = 0;
                continue;
            }

            if (gongback % 2 == 0)
            {
                ch[i] = Char.ToUpper(ch[i]);
                print(i + ":" + s[i]);
            }
            else if (gongback % 2 != 0)
            {
                ch[i] = Char.ToLower(ch[i]);
                print(i + ":" + s[i]);
            }

            gongback++;
            answer = new string(ch);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
            

    }
}
