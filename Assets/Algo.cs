using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Algo : MonoBehaviour
{
    int[] numbers= { 1, 2, 3, 4, 5, 6, 7 };
    // Start is called before the first frame update
    void Start()
    {
        int[] answer = new int[numbers.Length];

        int num1 = 0;
        int num2 = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; i++)
            {
                num1 = numbers[i];
                num2 = numbers[j];
                int num3 = num1 + num2;
                print(num3);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
