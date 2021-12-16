using System;

namespace Union_Find
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parent = new int[11];
            for(int i=1; i<=10; i++)
            {
                parent[i] = i;
            }

            UnionParent(parent, 1, 2);
            UnionParent(parent, 2, 3);
            UnionParent(parent, 3, 4);
            UnionParent(parent, 5, 6);
            UnionParent(parent, 6, 7);
            UnionParent(parent, 7, 8);
            Console.WriteLine("1과 5는 연결되어 있나요?" + FindParent(parent, 1, 5));

        }

        static int GetParent(int[] parent, int x)
        {
            //x의 값이 해당 부모의 값고 동일하다면 반환한다.
            if (parent[x] == x) return x;
            //만약 다르다면 
            return parent[x] = GetParent(parent, parent[x]);
        }

        static void UnionParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            //더작은값 쪽으로 부모를 합쳐 준다 .
            if (a < b) parent[b] = a;
            //그렇지 않으면 a 가 더 크면  a의 부모값으로 b를 넣어준다
            else parent[a] = b;
        }

        //같은 부모를 가지는지 확ㅇ니
        static int FindParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            //동일한 수면 1을 반환
            if (a == b) return 1;
            //그렇지 않으면 0 을 반환을 해서 다른 그래프에 있다고 알려준다. 
            return 0;
        }
    }
}
