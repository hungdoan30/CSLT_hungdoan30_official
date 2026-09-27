using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session07
{
    internal class _8ex_array
    {
        static void Main7 (string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int size = GetIntInput("Nhập số lượng phần tử của mảng: ");
            int[] arr = GenerateRandomArray(size, 1, 20);
            PrintArray("Mảng gốc được tạo ngẫu nhiên:", arr);
            Console.WriteLine();

            // BÀI 1: TÍNH TRUNG BÌNH
            Console.WriteLine($"Kết quả: {CalculateAverage(arr):F2}\n");

            // BÀI 2 & 3: KIỂM TRA TỒN TẠI VÀ TÌM VỊ TRÍ
            int targetFind = GetIntInput("Nhập giá trị cần tìm: ");
            bool isExist = ContainsValue(arr, targetFind);
            Console.WriteLine($"Mảng có chứa số {targetFind} không? {isExist}");
            if (isExist)
            {
                Console.WriteLine($"Vị trí (Index) đầu tiên của {targetFind} là: {FindIndex(arr, targetFind)}");
            }
            Console.WriteLine();

            // BÀI 4: XÓA PHẦN TỬ
            int targetRemove = GetIntInput("Nhập giá trị muốn xóa khỏi mảng: ");
            int[] arrayAfterRemoval = RemoveElement(arr, targetRemove);
            PrintArray("Mảng sau khi xóa:", arrayAfterRemoval);
            Console.WriteLine();

            // BÀI 5: TÌM MIN & MAX
            var (min, max) = FindMinMax(arr);
            Console.WriteLine($"Giá trị nhỏ nhất (Min): {min}");
            Console.WriteLine($"Giá trị lớn nhất (Max): {max}\n");

            // BÀI 6: ĐẢO NGƯỢC MẢNG
            int[] reversedArray = ReverseArray(arr);
            PrintArray("Mảng sau khi đảo ngược:", reversedArray);
            Console.WriteLine();

            // BÀI 7: TÌM PHẦN TỬ TRÙNG LẶP
            int[] duplicates = FindDuplicates(arr);
            PrintArray("Các giá trị bị trùng lặp trong mảng:", duplicates);
            Console.WriteLine();

            // BÀI 8: XÓA PHẦN TỬ TRÙNG LẶP
            int[] uniqueArray = RemoveDuplicates(arr);
            PrintArray("Mảng sau khi lọc trùng:", uniqueArray);
            Console.WriteLine();

            Console.WriteLine("Hoàn tất! Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Nhập lại số nguyên: ");
            }
            return value;
        }

        static void PrintArray(string message, int[] arr)
        {
            Console.WriteLine(message);
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("[Mảng rỗng]");
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", arr) + "]");
            }
        }

        // Hàm phụ: Sinh mảng ngẫu nhiên
        static int[] GenerateRandomArray(int size, int minVal, int maxVal)
        {
            if (size <= 0) return new int[0];
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(minVal, maxVal + 1);
            }
            return arr;
        }

        // Bài 1: Tính trung bình
        static double CalculateAverage(int[] arr)
        {
            if (arr.Length == 0) return 0;
            double sum = 0;
            foreach (int num in arr) sum += num;
            return sum / arr.Length;
        }

        // Bài 2: Kiểm tra tồn tại
        static bool ContainsValue(int[] arr, int target)
        {
            foreach (int num in arr)
            {
                if (num == target) return true;
            }
            return false;
        }

        // Bài 3: Tìm index
        static int FindIndex(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }

        // Bài 4: Xóa phần tử cụ thể (trả về mảng mới)
        static int[] RemoveElement(int[] arr, int target)
        {
            List<int> tempList = new List<int>();
            foreach (int num in arr)
            {
                if (num != target) 
                {
                    tempList.Add(num);
                }
            }
            return tempList.ToArray();
        }

        // Bài 5: Tìm Min và Max
        
        static (int Min, int Max) FindMinMax(int[] arr)
        {
            if (arr.Length == 0) throw new ArgumentException("Mảng rỗng");

            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            return (min, max);
        }

        // Bài 6: Đảo ngược mảng
        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        // Bài 7: Tìm giá trị trùng lặp
        static int[] FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }
            return new List<int>(duplicates).ToArray();
        }

        // Bài 8: Xóa phần tử trùng lặp (Chỉ giữ lại 1 bản duy nhất cho mỗi số)
        static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqueList = new List<int>();
            foreach (int num in arr)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
            }
            return uniqueList.ToArray();

        }
    }
}
