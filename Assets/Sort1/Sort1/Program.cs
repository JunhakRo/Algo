using System;
using System.Linq;
namespace Sort1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            

            for(int i= 0; i<n; i++)
            {
                a[i] = Console.ReadLine();
            }

           var b =  a.OrderBy(x => x.Length).ThenBy(x => x) ;

            foreach(var data in b)
            {
                Console.WriteLine(data);
            }
        }

        int compare(string a, string b)
        {
            if(a.Length<b.Length)
            {
                return 1;
            }
            else if(a.Length>b.Length)
            {
                return 0;
            }
            else
            {
                int aSum = GetSum(a);
                int bSum = GetSum(b);
            }
        }
        int GetSum(string a)
        {
            int legnth = a.Length, sum = 0;
            for(int i = 0; i<legnth; i++)
            {
                if(a[i] -'0' <=9 && a[i]-'0'>=0)
                {
                    sum += a[i] - '0';
                }
            }
            return sum;
        }
    }
}
