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

    // Update is called once per frame
    void Update()
    {

        bool sosu = true;
        int a = 0;
        for (int i = 2; i <= 7; i++)
        {
            sosu = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i != j && i % 2 == 0)
                {
                    sosu = false;
                    break;
                }
            }
            if (sosu)
            {
                a++;
            }

        }

    }
}
