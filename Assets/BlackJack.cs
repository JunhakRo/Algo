using System;

namespace ConsoleApp1
{
    class BlackJack
    {
        public static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int[] setData = GetData(value);

            // setdata[0] count card
            // setdata[1] need value
            value = Console.ReadLine();

            // 입력받은 데이터를 int 배열로 가공
            int[] Data = GetData(value);

            // BlakJack 함수를 사용하여 결과 값 출력
            Console.WriteLine(BlackJack(setData, Data));
        }
    }
}
