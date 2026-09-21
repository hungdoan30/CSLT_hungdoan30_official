using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    internal class _20_exercises
    {
        static void Main9(string[] args)
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
                    case "12": Bai12(); break;
                    case "13": Bai13(); break;
                    case "14": Bai14(); break;
                    case "15": Bai15(); break;
                    case "16": Bai16(); break;
                    case "17": Bai17(); break;
                    case "18": Bai18(); break;
                    case "19": Bai19(); break;
                    case "20": Bai20(); break;
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
            Console.WriteLine("12. Bài 12");
            Console.WriteLine("13. Bài 13");
            Console.WriteLine("14. Bài 14");
            Console.WriteLine("15. Bài 15");
            Console.WriteLine("16. Bài 16");
            Console.WriteLine("17. Bài 17");
            Console.WriteLine("18. Bài 18");
            Console.WriteLine("19. Bài 19");
            Console.WriteLine("20. Bài 20");
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
        {
            Console.Write("Nhập chuỗi cần kiểm tra: ");
            string s11 = Console.ReadLine();
            Console.WriteLine($"{KiemTraDoiXung(s11)}\n");
        }

        static void Bai12()
        {
            double c = GetDoubleInput("Nhập nhiệt độ (C): ");
            Console.WriteLine($"Từ độ C sang độ F: {CelsiusToFahrenheit(c)}\n");
        }

        static void Bai13()
        {
            int[] mang = NhapMangSoNguyen();

            int min = TimMin(mang);
            Console.WriteLine($"Giá trị nhỏ nhất: {min}");
        }

        static void Bai14()
        {
            int n14 = GetIntInput("Nhập số nguyên dương n: ");
            Console.WriteLine($"{TongCacChuSo(n14)}\n");
        }

        static void Bai15()
        {
            int[] mang = NhapMangSoNguyen();
            Console.Write("Mảng sau khi sắp xếp tăng dần: ");
            SapXepMang(mang);
                
        }

        static void Bai16()
        {
            Console.Write("Nhập chuỗi bất kỳ: ");
            string s16 = Console.ReadLine();
            Console.WriteLine($"{XoaTrungLap(s16)}\n");
        }
        
        static void Bai17()
        {
            int a = GetIntInput("Nhập số a: ");
            int b = GetIntInput("Nhập số b: ");
            Console.WriteLine($"UCLN: {UCLN(a, b)}\n");
        }

        static void Bai18()
        {
            int n18 = GetIntInput("Nhập số thập phân: ");
            Console.WriteLine($"{DecimalToBinary(n18)}\n");
        }

        static void Bai19()
        {
            int year = GetIntInput("Nhập năm: ");
            Console.WriteLine($"{KiemTraNamNhuan(year)}\n");
        }

        static void Bai20()
        {
            Console.Write("Nhập câu: ");
            string s20 = Console.ReadLine();
            Console.WriteLine($"{DemSoTu(s20)}\n");
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

        static double GetDoubleInput(string prompt)
        {
            Console.Write(prompt);
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Nhập lại số thực: ");
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
        
        static bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            
            string cleanS = s.Replace(" ", "").ToLower();
            int length = cleanS.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (cleanS[i] != cleanS[length - 1 - i])
                    return false;
            }
            return true;
        }

        static double CelsiusToFahrenheit(double c)
        { 
            return (c * 9.0 / 5.0) + 32;
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        static int TongCacChuSo(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n>0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            foreach (int so in arr)
                Console.Write(so + " ");
            Console.WriteLine();
        }

        static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c.ToString()))
                    result += c;
            }
            return result;

        }
        
        static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
        static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";
            string result = "";
            int tempN = Math.Abs(n);

            while (tempN > 0)
            {
                result = (tempN % 2) + result;
                tempN /= 2;
            }
            return n < 0 ? "-" + result : result;
        }

        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static int DemSoTu (string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
