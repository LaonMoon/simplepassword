using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answers = { 1, 2, 3, 4, 5, 6 };
            int count = 6;
            int[] passwords = new int[count];

            for(int index = 0;index<5;index++)
            {
                for(count =0; count<6;count++)
                {
                    Console.Write(count);
                    Console.WriteLine("번째 숫자를 입력하세요.");
                    passwords[count] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                
                    for(count=0;count<6;count++)
                {
                    if(answers[count]!=passwords[count])
                    {
                        Console.WriteLine("틀렸습니다. 다시 입력해주세요.");
                        isPasswordCorrect = false;
                        break;   
                    }
           
                }
                    if(isPasswordCorrect)
                {
                    Console.WriteLine("문이 열립니다.");
                    break;
                }
            }
        }
    }
}
