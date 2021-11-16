using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SosuSearch : MonoBehaviour
{
   
    public List<int> num = new List<int>();
    public List<int> suffleNum = new List<int>();
    public void Solution()
    {
        int answer = 0;
        string numbers = "17";
        char[] a = numbers.ToCharArray();

      
        int minNum = 0 ;
        int maxNum = 0 ;
        bool sosu;
        //숫자를 배열하여 나올수 있는 수 ;
        for(int i = 0; i<a.Length; i++)
        {
            num.Add(a[i]);
        }


        //리스트에 담긴 숫자 섞어 숫자 만들기;
        for (int i = 0; i < 0; i++)
        {
            if(i<10)
            {
                
            }
        }
        // 섞인 숫자 소수인지 판단..
        for (int i = 2; i <=maxNum; i++)
        {
            //만약 섞인숫자가 소수이면 true;

            sosu = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i != j && i % j == 0)
                {
                    sosu = false;
                    break;
                }
            }
            //참인 소수의 개수
            if (sosu)
            {
                answer++;
            }
        }


       

    }

   

}
