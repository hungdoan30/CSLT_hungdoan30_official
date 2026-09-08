using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session05
{
    internal class _8_exercises
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool dangChay = true;
            while (dangChay)
            {
                HienThi9Bai();
                string luaChon = Console.ReadLine();
                Console.WriteLine();
                switch (luaChon)
                {
                    case "1": Bai1(); break;
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "6": Bai6(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
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

        static void HienThi9Bai()
        {
            Console.WriteLine("1. Bài 1");
            Console.WriteLine("2. Bài 2");
            Console.WriteLine("3. Bài 3");
            Console.WriteLine("4. Bài 4");
            Console.WriteLine("5. Bài 5");
            Console.WriteLine("6. Bài 6");
            Console.WriteLine("7. Bài 7");
            Console.WriteLine("8. Bài 8");
            Console.WriteLine("9. Bài 9");
            Console.Write("Chọn bài tập: ");
        }
        // Bài 1: Xác định tam giác thường, cân hay đều
        static void Bai1()
        {
            Console.Write("Nhập chiều dài cạnh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều dài cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác đều.");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Đây là tam giác cân.");
                else
                    Console.WriteLine("Đây là tam giác thường.");
            }
            else
            {
                Console.WriteLine("Ba cạnh vừa nhập k thể tạo thành tam giác");
            }
        }

        // Bài 2: Đọc vào 10 số và tính trung bình cộng và tổng

        static void Bai2()
        {
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                double n = double.Parse(Console.ReadLine());
                sum += n;

            }
            double average = sum / 10;
            Console.WriteLine($"Tổng của 10 số là: {sum}");
            Console.WriteLine($"Trung bình cộng của 10 số là: {average}");
        }

        // Bài 3: Viết chương trình viết ra bảng cửu chương của 1 số nguyên

        static void Bai3()
        {
            Console.Write("Nhập một số nguyên: ");
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
        
        // Bài 4: display 1 chuỗi giống như tam giác với 1 số
        
        static void Bai4()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        // Bài 5: tương tự bài 4 nhưng các số tăng dần từ 1-10 từ trên xuống

        static void Bai5()
        {
            int x = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x + " ");
                    x++;
                }
             Console.WriteLine();

            }
        }

        // Bài 6: Tương tự bài 5 nhưng các số tạo thành 1 tam giác cân

        static void Bai6()
        {
            int n = 1;
            int dong = 4;
            for (int i = 1; i <= dong; i++)
            {
                for (int j = 1; j <= dong - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(n + " ");
                    n++;
                }
                Console.WriteLine();
            }
        }

        // Bài 7: Hiển thị n số hạng của chuỗi điều hòa và tính tổng

        static void Bai7()
        {
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            Console.Write("Chuỗi điều hòa: ");

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;

                if (i == 1)
                    Console.Write("1");
                else
                    Console.Write(" + 1/" + i);
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
        }

        // Bài 8: Tìm các số hoàn hảo trong 1 khoảng bất kỳ

        static void Bai8()
        {
            Console.Write("Nhập số đầu tiên của khoảng: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cuối cùng của khoảng: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nCác số hoàn hảo trong khoảng từ {start} đến {end} là:");

            for (int n = start; n <= end; n++)
            {
                if (n <= 0) 
                    continue;
                int tong = 0;
                for (int i = 1; i <= n/2; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                    
                }          

                if (tong == n)
                {
                    Console.WriteLine($"{n}");
                }
            }
        }

        // Bài 9: Tìm số nguyên tố

        static void Bai9()
        {
            Console.Write("Nhập số cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
                return; 
            }

            bool nt = true;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    nt = false;
                    break;
                }
            }
            if (nt == true)
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
                { Console.WriteLine($"{n} không phải là số nguyên tố."); }
            
        }
    }
}
