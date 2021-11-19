using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GymCloth : MonoBehaviour
{

    private void Update()
    {
        int[] a = { 2, 4 };
        int[] b = {  };
        solution(5, a, b);
    }
    //ÇÐ»ý¼ö =  n;
    //µµ³­´çÇÑ Ã¼À°¸ñ = lost;
    //¿©À¯ºÐ =  reserve;
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;

        //ÃÑ Ã¼À°º¹ °¹¼ö
        List<int> num = new List<int>(n);
        List<int> Lostnum = new List<int>(lost);
        List<int> ReserveNum = new List<int>(reserve);

        //¿©¹úÀÖ´Âµ¥ ÀÒ¾î¹ö¸²
        foreach(var a in ReserveNum)
        {
            foreach(var b in Lostnum)
            {
                if(a==b)
                {
                    num.Add(a);
                    break;
                }
            }
        }

        

        foreach(var c in num)
        {
            Lostnum.Remove(c);
            ReserveNum.Remove(c);
        }

        
        for(int i = 0; i<Lostnum.Count; i++)
        {
            int z = Lostnum[i]-1;
            int x = Lostnum[i];
            int v = Lostnum[i] + 1;
            foreach (var d in ReserveNum)
            {
                if(z==d||x==d||v== d)
                {
                    ReserveNum.Remove(d);
                    answer++;
                    break;
                }
            }
        }

       
        return n - (Lostnum.Count - answer);
    }
}
