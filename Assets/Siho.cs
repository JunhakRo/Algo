using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siho : MonoBehaviour
{
    public string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string solution(string s, int n)
    {
        string answer = "";
        char[] so = s.ToCharArray();
        for(int i = 0; i<so.Length; i++)
        {
            if (so[i] == ' ')
            {
            answer += so[i].ToString();

                continue;
            }
            for(int j=1; j<=n; j++)
            {
                if(so[i]=='z')
                {
                    so[i] = 'a';
                }
                else if(so[i] == 'Z')
                {
                    so[i] = 'A';
                }
                else
                {
                    so[i] = (char)(so[i] + 1);
                }
            }
            answer += so[i].ToString();
            
        }
        return answer;
    }
}
