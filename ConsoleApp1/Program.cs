using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passwords = { 1, 2, 3, 4, 5, 6 };
            int[] userinputs = new int[6];
            int number = 0;

            while (number<6)
            {
                Console.WriteLine("비밀번호를 입력해주세요.");
                userinputs[number] = int.Parse(Console.ReadLine());
                number = number + 1;

                if (number ==6&&!(passwords[0] == userinputs[0] && passwords[1] == userinputs[1] && passwords[2] == userinputs[2] && passwords[3] == userinputs[3] && passwords[4] == userinputs[4] && passwords[5] == userinputs[5]))
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                    number = 0;
                    continue;
                }

                else if(number == 6)
                {
                    Console.WriteLine("문이 열립니다.");
                    break;
                }
            }
        }
    }
}
