using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session09
{
    internal class stringexercise
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Nhập và in chuỗi
            Console.Write("Nhập một chuỗi bất kỳ: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Chuỗi bạn vừa nhập: {input}\n");

            // 2. Tìm độ dài không dùng hàm thư viện
            int length = GetStringLength(input);
            Console.WriteLine($"Độ dài chuỗi: {length} ký tự\n");

            // 3 & 4. Tách ký tự và In ngược
            Console.WriteLine($"Các ký tự rời rạc: {SeparateCharacters(input)}");
            Console.WriteLine($"In ngược ký tự:    {ReverseStringCharacters(input)}\n");

            // 5. Đếm số từ
            Console.WriteLine($"Tổng số từ trong chuỗi: {CountWords(input)}\n");

            // 6. So sánh 2 chuỗi không dùng hàm thư viện
            Console.Write("Nhập chuỗi thứ 2 để so sánh: ");
            string string2 = Console.ReadLine();
            bool isEqual = CompareStrings(input, string2);
            Console.WriteLine(isEqual ? "=> Hai chuỗi GIỐNG HỆT nhau.\n" : "=> Hai chuỗi KHÁC nhau.\n");

            // 7. Đếm chữ cái, chữ số, ký tự đặc biệt
            var (alphas, digits, specials) = CountCharacterTypes(input);
            Console.WriteLine($"Chữ cái: {alphas} | Chữ số: {digits} | Ký tự đặc biệt: {specials}\n");

            // 8. Đếm Nguyên âm, Phụ âm
            var (vowels, consonants) = CountVowelsAndConsonants(input);
            Console.WriteLine($"Nguyên âm (A,E,I,O,U): {vowels} | Phụ âm: {consonants}\n");

            // 9, 10, 12, 13. Xử lý Substring (Chuỗi con)
            Console.Write("Nhập một chuỗi con cần tìm kiếm: ");
            string sub = Console.ReadLine();

            int position = FindSubstringPosition(input, sub);
            if (position != -1)
            {
                Console.WriteLine($"9 & 10. Tìm thấy chuỗi '{sub}' bắt đầu tại vị trí index: {position}");
                Console.WriteLine($"12. Số lần xuất hiện của '{sub}': {CountSubstringOccurrences(input, sub)}");

                Console.Write("13. Nhập từ muốn chèn vào TRƯỚC chuỗi con này: ");
                string insertStr = Console.ReadLine();
                Console.WriteLine($"=> Chuỗi mới: {InsertBeforeSubstring(input, sub, insertStr)}\n");
            }
            else
            {
                Console.WriteLine($"=> Không tìm thấy chuỗi '{sub}' trong chuỗi gốc.\n");
            }

            // 11. Kiểm tra tính chất 1 ký tự
            Console.Write("Nhập 1 ký tự bất kỳ: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine($"\n=> Kết quả: {CheckCharacterCase(c)}\n");

            Console.WriteLine();
            Console.ReadKey();
        }
        static int GetStringLength(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }


    }
}
