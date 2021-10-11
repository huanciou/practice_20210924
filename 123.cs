// 輸入成績 

using System.Linq;
using System;
namespace HelloCSharpWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j == i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine(" ");
                j = 0;
            }

        }
    }
}



