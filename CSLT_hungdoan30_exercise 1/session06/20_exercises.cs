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
                    case "6": Bai6(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
                    case "10": Bai10(); break;
                    case "11": Bai11(); break;
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
            Console.WriteLine("6. Bài 6");
            Console.WriteLine("7. Bài 7");
            Console.WriteLine("8. Bài 8");
            Console.WriteLine("9. Bài 9");
            Console.WriteLine("10. Bài 10");
            Console.WriteLine("11. Bài 11");
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

        static void Bai6()
        {
            int n6 = GetIntInput("Nhập số nguyên dương n: ");
            Console.WriteLine($"{KiemTraNguyenTo(n6)}\n");
        }

        static void Bai7()
        {
            Console.Write("Nhập số lượng phần tử n: "); int n = int.Parse(Console.ReadLine());

            Console.Write($"{n} số Fibonacci đầu tiên: ");
            InFibonacci(n);
        }

        static void Bai8()
        {
            Console.Write("Nhập chuỗi bất kỳ: ");
            string s8 = Console.ReadLine();
            Console.WriteLine($"{DemNguyenAm(s8)}\n");
        }

        static void Bai9()
        {
            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine());
            int y = GetIntInput("Nhập số mũ y: ");
            Console.WriteLine($"{TinhLuyThua(x, y)}\n");
        }

        static void Bai10()
        {
            int[] mang = NhapMangSoNguyen();

            double trungBinh = TinhTrungBinh(mang);
            Console.WriteLine($"Điểm trung bình: {trungBinh}");
        }

        static void Bai11()

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
        static int[] NhapMangSoNguyen()
        {
            Console.Write("Nhập các số nguyên, cách nhau bởi khoảng trắng: ");
            string dong = Console.ReadLine();
            string[] cacChuoiSo = dong.Split(
                new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] mang = new int[cacChuoiSo.Length];
            for (int i = 0; i < cacChuoiSo.Length; i++)
                mang[i] = int.Parse(cacChuoiSo[i]);
            return mang;
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

        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        
        static void InFibonacci(int n)
        {
            if (n <= 0) return;
            long soTruoc = 0, soSau = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(soTruoc + " ");
                long soTiepTheo = soTruoc + soSau;
                soTruoc = soSau;
                soSau = soTiepTheo;
            }
            Console.WriteLine();
        }
        
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            const string nguyenAm = "aeoiuAEOIU";
            foreach (char c in s)
            {
                if (nguyenAm.IndexOf(c) >= 0)
                    dem++;
            }
            return dem;
        }
        
        static double TinhLuyThua(double x, int y)
        {
            if (y == 0) return 1;
            double result = 1;
            int absY = Math.Abs(y);

            for (int i = 0; i < absY; i++)
                result *= x;

            return y < 0 ? 1.0 / result : result;
        }

        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;
            foreach (int so in arr)
                tong += so;
            return (double)tong / arr.Length;
        }
    }
}
