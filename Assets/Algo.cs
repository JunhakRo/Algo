using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Algo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        string answer = "";
        string a = "¼ö¹Ú";
        
        int n =4;
        char[] ch = a.ToCharArray();
        
        for (int i = 0; i < n; i++)
        {
            answer+=ch[i % 2];
            print(answer);
           
        }

    }

    // Update is called once per frame
    void Update()
    {
        
            

    }
}
