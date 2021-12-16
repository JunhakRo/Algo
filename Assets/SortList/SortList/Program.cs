using System;
using System.Collections.Generic;

namespace SortList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<KeyValuePair<String, int>> listKeyValue = new List<KeyValuePair<String, int>>();
            listKeyValue.Add(new KeyValuePair<string, int>("가나다", 29));
            listKeyValue.Add(new KeyValuePair<string, int>("라마바", 26));
            listKeyValue.Add(new KeyValuePair<string, int>("사아자", 25));
            listKeyValue.Add(new KeyValuePair<string, int>("차카타", 28));
            listKeyValue.Add(new KeyValuePair<string, int>("파하하", 28));
            listKeyValue.Add(new KeyValuePair<string, int>("타아라", 33));

            listKeyValue.Sort((a,b)=>b.Value.CompareTo(a.Value));

            foreach(var list in listKeyValue)
            {
                Console.WriteLine("[{0} : {1}]", list.Key, list.Value);
            }
        }


    }

    class Student
    {
        void Type()
        {
        List<KeyValuePair<string, KeyValuePair<int, int>>> valType = new List<KeyValuePair<string, KeyValuePair<int, int>>>();
            valType.Add(new KeyValuePair<string, KeyValuePair<int,int>>("노준학", new KeyValuePair<int, int>(29, 90)));
            valType.Add(new KeyValuePair<string, KeyValuePair<int, int>>("홍창교", new KeyValuePair<int, int>(24, 95)));
            valType.Add(new KeyValuePair<string, KeyValuePair<int, int>>("홍승민", new KeyValuePair<int, int>(28, 95)));
            valType.Add(new KeyValuePair<string, KeyValuePair<int, int>>("정광훈", new KeyValuePair<int, int>(25, 97)));

            valType.Sort((a,b)=>b.Value.Value.CompareTo(a.Value.Value);

            foreach(var rank in valType)
            {
                Console.WriteLine("[{0} : {1} : {2}]", rank.Key, rank.Value, rank.Value);
            }
        }

        //public bool Compare(KeyValuePair<string, KeyValuePair<int, int>> a, KeyValuePair<string, KeyValuePair<int, int>> b)
        //{
        //    if(a.Value.Key == b.Value.Key)
        //    {
        //        return a.Value.Value > b.Value.Value;
        //    }
        //    else { 
        //        return a.Value.Key > b.Value.Key;
        //    }
        //}
    }
}
