using System;
using System.Collections.Generic;
using System.Linq;

namespace Union_Find
{
    public class KruskalAlgorithm
    {

        public bool FindParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            //동일한 수면 1을 반환
            if (a == b) return true;
            //그렇지 않으면 0 을 반환을 해서 다른 그래프에 있다고 알려준다. 
            return false;
        }

        public void Main(string[] args)
        {
            int[] parent = new int[11];
            for (int i = 1; i <= 10; i++)
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

        public int GetParent(int[] parent, int x)
        {
            //x의 값이 해당 부모의 값고 동일하다면 반환한다.
            if (parent[x] == x) return x;
            //만약 다르다면 
            return parent[x] = GetParent(parent, parent[x]);
        }

        public void UnionParent(int[] parent, int a, int b)
        {
            a = GetParent(parent, a);
            b = GetParent(parent, b);
            //더작은값 쪽으로 부모를 합쳐 준다 .
            if (a < b) parent[b] = a;
            //그렇지 않으면 a 가 더 크면  a의 부모값으로 b를 넣어준다
            else parent[a] = b;
        }

        public KruskalAlgorithm()
        {
            int n = 7;
            int m = 11;
            List<Edge> list = new List<Edge>();
            list.Add(new Edge(1, 7, 12));
            list.Add(new Edge(1, 4, 28));
            list.Add(new Edge(1, 2, 67));
            list.Add(new Edge(1, 5, 17));
            list.Add(new Edge(2, 4, 24));
            list.Add(new Edge(2, 5, 62));
            list.Add(new Edge(3, 5, 20));
            list.Add(new Edge(3, 6, 37));
            list.Add(new Edge(4, 7, 13));
            list.Add(new Edge(5, 6, 45));
            list.Add(new Edge(5, 7, 73));

            //간선의 비용을 기준으로 오름차순 정렬
            list = list.OrderBy(o => o.distance).ToList();

            //각 정점이 포함된 그래프가 어디인지 저장
            int[] parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                //사이클이 발생하지 않는 경우 그래프에 포함
                if (!FindParent(parent, list[i].node[0] - 1, list[i].node[1] - 1))//노드가 연결되이지 않는상태
                {
                    sum += list[i].distance;
                    UnionParent(parent, list[i].node[0] - 1, list[i].node[1] - 1);
                }
            }

            Console.WriteLine(sum);
        }
    }


    //간선 클래스 
   public class Edge
    {
        public int[] node = new int[2];
        public int distance;
        public Edge(int a, int b, int distance)
        {
            node[0] = a;
            node[1] = b;
            this.distance = distance;
        }

      
    }


}
