using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Algo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        string[] strings = { "abc", "cde", "efg", "ghi" };
        string[] answer = new string[strings.Length];
        int n = 1;
        for (int i = 0; i < strings.Length; i++)
        {
            answer[i] = strings[i].Substring(n, 1) + strings[i];
            print(i + ":" + answer[i]);
        }
        Array.Sort(answer);
        
        for(int i = 0; i<answer.Length; i++)
        {
            answer[i] = answer[i].Substring(1);
            print(i+ "2:" + answer[i]);


        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
            

    }
}
