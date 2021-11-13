using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boo : MonoBehaviour
{
    public long solution(int price, int money, int count)
    {
        List<long> charge = new List<long>();
        long fullMoney = 0;
        for (int i = 1; i <= count; i++)
        {
            charge.Add(price * i);
        }

        for (int j = 0; j < charge.Count; j++)
        {
            fullMoney += charge[j];
        }

        if (money < fullMoney)
        {
            return fullMoney - money;
        }
        else if (money >= fullMoney)
        {
            return 0;
        }

        return fullMoney;
    }
}
