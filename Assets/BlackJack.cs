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

            // �Է¹��� �����͸� int �迭�� ����
            int[] Data = GetData(value);

            // BlakJack �Լ��� ����Ͽ� ��� �� ���
            Console.WriteLine(BlackJack(setData, Data));
        }
    }
}
