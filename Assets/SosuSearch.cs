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
        //���ڸ� �迭�Ͽ� ���ü� �ִ� �� ;
        for(int i = 0; i<a.Length; i++)
        {
            num.Add(a[i]);
        }


        //����Ʈ�� ��� ���� ���� ���� �����;
        for (int i = 0; i < 0; i++)
        {
            if(i<10)
            {
                
            }
        }
        // ���� ���� �Ҽ����� �Ǵ�..
        for (int i = 2; i <=maxNum; i++)
        {
            //���� ���μ��ڰ� �Ҽ��̸� true;

            sosu = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i != j && i % j == 0)
                {
                    sosu = false;
                    break;
                }
            }
            //���� �Ҽ��� ����
            if (sosu)
            {
                answer++;
            }
        }


       

    }

   

}
