using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session07
{
    internal class ex1
    {
        // ==========================================
        // 1. ĐIỀU PHỐI CHÍNH (MAIN)
        // ==========================================
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo kích thước mảng 2 chiều
            int n = 2; // Số dòng (Rows)
            int m = 3; // Số cột (Columns)

            Console.WriteLine($"--- KHỞI TẠO MẢNG 2 CHIỀU ({n} dòng, {m} cột) ---");

            // Gọi hàm UI để thu thập dữ liệu. Trả kết quả về cho biến 'mang'
            int[,] mang = NhapMang2D(n, m);

            // Gọi hàm UI để hiển thị kết quả kiểm tra
            Console.WriteLine("\nMảng bạn vừa nhập là:");
            XuatMang2D(mang);

            Console.ReadLine();
        }

        // ==========================================
        // 2. GIAO DIỆN & NHẬP LIỆU (UI METHODS)
        // ==========================================

        // Hàm chịu trách nhiệm tạo mảng và hỏi người dùng nhập từng phần tử
        static int[,] NhapMang2D(int rows, int cols)
        {
            int[,] arr = new int[rows, cols]; // Khởi tạo mảng trống

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Tái sử dụng hàm ép kiểu an toàn thay vì dùng int.Parse dễ gây crash
                    arr[i, j] = GetIntInput($"Nhập giá trị cho a[{i}][{j}] = ");
                }
            }
            return arr; // Trả mảng đã đầy dữ liệu về cho Main
        }

        // Hàm in mảng 2 chiều ra màn hình theo dạng lưới (Grid)
        static void XuatMang2D(int[,] arr)
        {
            // arr.GetLength(0) lấy số lượng phần tử của chiều thứ nhất (Số dòng)
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // arr.GetLength(1) lấy số lượng phần tử của chiều thứ hai (Số cột)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t"); // Dùng \t (Tab) để các cột cách đều nhau
                }
                Console.WriteLine(); // Cứ in hết 1 dòng thì vứt con trỏ chuột xuống dòng mới
            }
        }

        // Hàm tiện ích: Ép kiểu an toàn (đã quen thuộc từ các bài trước)
        static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Lỗi! Vui lòng nhập số nguyên hợp lệ: ");
            }
            return value;
        }
    }

}
