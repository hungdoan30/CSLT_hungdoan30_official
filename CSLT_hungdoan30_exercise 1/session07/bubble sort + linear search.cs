using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session07
{
    internal class bubble_sort___linear_search
    {
        static void Main4(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // BÀI 1: BUBBLE SORT
            int[] numbers = new int[10];
            Console.WriteLine("Vui lòng nhập 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = GetIntInput($"Nhập số thứ {i + 1}: ");
            }
            BubbleSort(numbers);
            Console.WriteLine($"\nMảng sau khi sắp xếp tăng dần: {string.Join(", ", numbers)}\n");

            // BÀI 2: LINEAR SEARCH
            Console.Write("Nhập một câu bất kỳ: ");
            string sentence = Console.ReadLine();
            Console.Write("Nhập từ cần tìm: ");
            string target = Console.ReadLine();
            bool isFound = LinearSearchWord(sentence, target);

            if (isFound)
            {
                Console.WriteLine($"Từ '{target}' có xuất hiện trong câu.");
            }
            else
            {
                Console.WriteLine($"Từ '{target}' không xuất hiện trong câu.");
            }
            Console.ReadKey();
        }

        static int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Vui lòng nhập một số nguyên hợp lệ: ");

            }

            return value;

        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped = false; ; 
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    swapped = false;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) 
                    break;
            }
        }

        static bool LinearSearchWord(string sentence, string target)
        {
            if (string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(target))
                return false;
            char [] separators = { ' ', '.', ',', '!', '?', ';' };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Length; i++)
            {
                if (string.Equals(words[i], target, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
