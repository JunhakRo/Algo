using System;

namespace Tree
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = 15;

            Node[] nodes = new Node[number + 1];

            for (int i = 1; i < number; i++)
            {
                nodes[i].data = i;
                nodes[i].left = null;
                nodes[i].right = null;
            }

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    nodes[i / 2].left = nodes[i];
                }
                else
                {
                    nodes[i / 2].right = nodes[i];
                }
            }

            Preorder(nodes[1]);
        }

        private static void Preorder(Node node1)
        {
            if (node1 != null)
            {
                Console.WriteLine("{0}", node1.data);
                Preorder(node1.left);
                Preorder(node1.right);

            }
        }
    }

    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public void Set (int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }

    class Tree
    {
        Node root;
        public Tree()
        {
            root = new Node();

            root.Set(0, null, null);
        }
            
           
       
    }

}


