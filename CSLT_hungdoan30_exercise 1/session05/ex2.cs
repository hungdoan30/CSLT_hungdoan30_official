using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session05
{
    internal class ex2
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            printStartTriangle();
            BangCuuChuong();
        }

        static void printStartTriangle()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void BangCuuChuong()
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên.");
            }
        }

    }
            



    
}
