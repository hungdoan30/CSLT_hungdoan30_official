using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session07
{
    internal class matrix
    {
        static void Main8(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 1. Tạo và in ma trận ngẫu nhiên
            int n = GetIntInput("Nhập số dòng (N): ", 1, 100);
            int m = GetIntInput("Nhập số cột (M): ", 1, 100);
            int[,] matrix = GenerateRandomMatrix(n, m, 1, 99);
            Console.WriteLine("\n=> Ma trận vừa tạo:");
            PrintMatrix(matrix);

            // 2. In dòng/cột thứ i
            int rowIndex = GetIntInput($"Nhập chỉ số dòng muốn xem (0 đến {n - 1}): ", 0, n - 1);
            int[] rowData = GetRow(matrix, rowIndex);
            Console.WriteLine($"Dòng thứ {rowIndex}: {string.Join(", ", rowData)}");

            int colIndex = GetIntInput($"Nhập chỉ số cột muốn xem (0 đến {m - 1}): ", 0, m - 1);
            int[] colData = GetColumn(matrix, colIndex);
            Console.WriteLine($"Cột {colIndex}: [{string.Join(", ", colData)}]");

            // 3. Tìm max của ma trận
            Console.WriteLine($"Giá trị lớn nhất trong ma trận là: {FindMaxInMatrix(matrix)}");

            // 4. Tìm min của dòng/cột thứ i
            int minInRow = FindMinInArray(GetRow(matrix, rowIndex));
            Console.WriteLine($"Giá trị nhỏ nhất trên dòng {rowIndex} là: {minInRow}");

            int minInCol = FindMinInArray(GetColumn(matrix, colIndex));
            Console.WriteLine($"Giá trị nhỏ nhất trên cột {colIndex} là: {minInCol}");

            // 5. Chuyển vị ma trận
            int[,] transposedMatrix = TransposeMatrix(matrix);
            PrintMatrix(transposedMatrix);

            // 6. In đường chéo chính/phụ của ma trận vuông
            if (n == m)
            {
                var (mainDiag, secDiag) = GetDiagonals(matrix);
                Console.WriteLine($"Đường chéo chính: [{string.Join(", ", mainDiag)}]");
                Console.WriteLine($"Đường chéo phụ:   [{string.Join(", ", secDiag)}]");
            }
            else
            {
                Console.WriteLine("Đây không phải ma trận vuông (N != M) nên không có đường chéo chuẩn.");
            }
            Console.ReadKey();
        }
        static int GetIntInput(string prompt, int min, int max)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine($"Vui lòng nhập số nguyên từ {min} đến {max}.");
            }
        }
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
        static int[,] GenerateRandomMatrix(int rows, int cols, int minVal, int maxVal)
        {
            int[,] arr = new int[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rnd.Next(minVal, maxVal + 1);
                }
            }
            return arr;
        }
        static int[] GetRow(int[,] matrix, int rowIndex)
        {
            int cols = matrix.GetLength(1);
            int[] row = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                row[j] = matrix[rowIndex, j];
            }
            return row;
        }
        static int[] GetColumn(int[,] matrix, int colIndex)
        {
            int rows = matrix.GetLength(0);
            int[] col = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                col[i] = matrix[i, colIndex];
            }
            return col;
        }
        static int FindMaxInMatrix(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int num in matrix)
            {
                if (num > max) max = num;
            }
            return max;
        }
        static int FindMinInArray(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
            }
            return min;
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }
        static (int[] MainDiag, int[] SecDiag) GetDiagonals(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int[] mainDiag = new int[n];
            int[] secDiag = new int[n];

            for (int i = 0; i < n; i++)
            {
                mainDiag[i] = matrix[i, i];
                secDiag[i] = matrix[i, n - 1 - i];
            }
            return (mainDiag, secDiag);
        }
    }
}
