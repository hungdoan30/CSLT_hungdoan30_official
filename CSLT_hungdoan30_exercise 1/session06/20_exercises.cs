using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    internal class _20_exercises
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool dangChay = true;
            while (dangChay)
            {
                HienThi20Bai();
                string luaChon = Console.ReadLine();
                Console.WriteLine();
                switch (luaChon)
                {
                    case "1": Bai1(); break;
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "0": dangChay = false; break;
                    default: Console.WriteLine("Chọn lại"); break;

                }

                if (dangChay)
                {
                    Console.WriteLine("\nNhấn enter để quay lại");
                    Console.ReadLine();
                    Console.Clear();
                }


            }

            Console.WriteLine("Kết thúc chương trình");

        }
        static void HienThi20Bai()
        {
            Console.WriteLine("1. Bài 1");
            Console.WriteLine("2. Bài 2");
            Console.WriteLine("3. Bài 3");
            Console.WriteLine("4. Bài 4");
            Console.WriteLine("5. Bài 5");
            Console.Write("Chọn bài tập: ");
        }

        static void Bai1()
        {
            int a1 = GetIntInput("Nhập số a: ");
            int b1 = GetIntInput("Nhập số b: ");
            Console.WriteLine($"Tổng của {a1} và {b1} là: {TinhTong(a1, b1)}\n");
        }

        static void Bai2()
        {
            int n2 = GetIntInput("Nhập số cần kiểm tra: ");
            Console.WriteLine($"Số {n2} là số chẵn? {KiemTraChan(n2)}\n");
        }

        static void Bai3()
        {
            int a3 = GetIntInput("Nhập số thứ nhất: ");
            int b3 = GetIntInput("Nhập số thứ hai: ");
            int c3 = GetIntInput("Nhập số thứ ba: ");
            Console.WriteLine($"Số lớn nhất là: {TimMax(a3, b3, c3)}\n");
        }

        static void Bai4()
        {
            int n4 = GetIntInput("Nhập số nguyên dương n: ");
            try
            {
                Console.WriteLine($"Giai thừa {n4}! = {TinhGiaiThua(n4)}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}\n");
            }
        }

        static void Bai5()
        {
            Console.Write("Nhập chuỗi: ");
            string input5 = Console.ReadLine();
            string ketQua = DaoNguocChuoi(input5);
            Console.WriteLine($"Chuỗi sau khi đảo ngược: {ketQua}");
        }
        

        static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Nhập lại một số nguyên hợp lệ: ");
            }
            return value;
        }

        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }

        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        static long TinhGiaiThua(int n)
        {
            if (n < 0) throw new ArgumentException("Số n phải lớn hơn hoặc bằng 0");
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
