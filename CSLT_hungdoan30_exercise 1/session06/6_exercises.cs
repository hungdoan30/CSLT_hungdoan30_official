using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    internal class _6_exercises
    
        {
            static void Main5(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Bài 1: Số lớn nhất trong các số 5, 10, 3, 8 là: " + FindMax(5, 10, 3, 8));

                Console.WriteLine("Bài 2: Giai thừa của 5 là: " + CalculateFactorial(5));

                Console.WriteLine("\nBài 3: Số 29 có phải số nguyên tố? " + IsPrime(29));

                Console.WriteLine("\nBài 4.1: Các số nguyên tố nhỏ hơn 20:");
                PrintPrimesLessThan(20);

                Console.WriteLine("\nBài 4.2: 5 số nguyên tố đầu tiên là:");
                PrintFirstNPrimes(5);

                Console.WriteLine("\n\nBài 5: Các số hoàn hảo nhỏ hơn 1000:");
                PrintPerfectNumbersLessThan1000();

                string text = "The quick brown fox jumps over the lazy dog";
                Console.WriteLine($"\n\nBài 6: Chuỗi '{text}' có phải Pangram? " + IsPangram(text));

                Console.ReadLine();
            }

            static int FindMax(int first, params int[] others)
            {
                int max = first;
                foreach (int num in others)
                {
                    if (num > max) max = num;
                }
                return max;
            }

            static long CalculateFactorial(int n)
            {
                if (n < 0) throw new ArgumentException("Số phải lớn hơn hoặc bằng 0");

                long result = 1; // Dùng kiểu 'long' vì giai thừa tăng giá trị rất nhanh
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }

            static bool IsPrime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            // 4.1 In các số nguyên tố nhỏ hơn limit
            static void PrintPrimesLessThan(int limit)
            {
                for (int i = 2; i < limit; i++)
                {
                    // Tái sử dụng lại hàm IsPrime ở Bài 3!
                    if (IsPrime(i)) Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            // 4.2 In N số nguyên tố đầu tiên
            static void PrintFirstNPrimes(int n)
            {
                int count = 0;   // Đếm xem đã tìm được bao nhiêu số
                int current = 2; // Bắt đầu kiểm tra từ số 2

                while (count < n)
                {
                    if (IsPrime(current))
                    {
                        Console.Write(current + " ");
                        count++; // Chỉ tăng biến đếm khi thực sự tìm thấy số nguyên tố
                    }
                    current++; // Tiến lên số tiếp theo để kiểm tra
                }
            }

            static bool IsPerfect(int n)
            {
                if (n <= 1) return false;
                int sum = 0;
                for (int i = 1; i <= n / 2; i++)
                {
                    if (n % i == 0) sum += i;
                }
                return sum == n;
            }

            static void PrintPerfectNumbersLessThan1000()
            {
                for (int i = 1; i < 1000; i++)
                {
                    // Tái sử dụng hàm IsPerfect ở trên
                    if (IsPerfect(i)) Console.Write(i + " ");
                }
            }

            static bool IsPangram(string text)
            {
                if (string.IsNullOrEmpty(text)) return false;

                // Chuyển toàn bộ chuỗi về chữ thường để dễ kiểm tra
                string lowerText = text.ToLower();

                // Duyệt qua toàn bộ bảng chữ cái từ 'a' đến 'z'
                for (char c = 'a'; c <= 'z'; c++)
                {
                    // Nếu chuỗi không chứa ký tự c hiện tại -> Không phải Pangram
                    if (!lowerText.Contains(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
