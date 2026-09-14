using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    internal class ex2
    {
        static void swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Trong khi hoán đổi: a = {a}, b = {b}");
        }

        public static void Main123(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 5, y = 10;
            Console.WriteLine($"Trước khi hoán đổi: x = {x}, y = {y}");
            swap(ref x, ref y);
            Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}");
        }
    }
}
