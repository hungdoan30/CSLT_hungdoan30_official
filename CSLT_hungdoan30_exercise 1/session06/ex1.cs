using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    internal class ex1
    {
        public static void Main1(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 5, y = 10;
            int sum = add(x, y);
            Console.WriteLine($"Tổng của {x} và {y} là: {sum}");
        }
        static int add(int a, int b)
        {
            if (a == 0)
                return b;
            return a + b;
        }
    }
}
