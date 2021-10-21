using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Algo : MonoBehaviour
{
    string s = "Zbcdefg";
    // Start is called before the first frame update
    void Start()
    {
        string answer = s;
        char[] ch = answer.ToCharArray();
        var sort = ch.OrderByDescending(c => c).ToArray();
        
        for(int i = 0; i<sort.Length; i++)
        {
           
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
