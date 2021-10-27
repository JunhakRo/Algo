using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Algo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        long num = 626331;
        for (int i = 0; i<500; i++)
        {
            if(num%2==0)
            {
                num = num / 2;
            }
            else if(num%2==1)
            {
                num = num * 3 + 1; 
            }
            i++;
            print(i + ":" + num);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
