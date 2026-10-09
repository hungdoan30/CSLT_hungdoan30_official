using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session09
{
    internal class stringexercise
    {
        static void Main6(string[] args)
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
        static string SeparateCharacters(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                result += c + " ";
            }
            return result.TrimEnd();
        }

        static string ReverseStringCharacters(string s)
        {
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i] + " ";
            }
            return result.TrimEnd();
        }
        static int CountWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            int count = 0;
            bool inWord = false;

            foreach (char c in s)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            return count;
        }
        static bool CompareStrings(string s1, string s2)
        {
            int len1 = GetStringLength(s1);
            int len2 = GetStringLength(s2);

            if (len1 != len2) return false;

            for (int i = 0; i < len1; i++)
            {
                if (s1[i] != s2[i]) return false;
            }
            return true;
        }
        static (int Alphas, int Digits, int Specials) CountCharacterTypes(string s)
        {
            int a = 0, d = 0, sp = 0;
            foreach (char c in s)
            {
                if (char.IsLetter(c)) a++;
                else if (char.IsDigit(c)) d++;
                else if (!char.IsWhiteSpace(c)) sp++; 
            }
            return (a, d, sp);
        }

        static (int Vowels, int Consonants) CountVowelsAndConsonants(string s)
        {
            int v = 0, c = 0;
            string vowels = "aeiouAEIOU";

            foreach (char ch in s)
            {
                if (char.IsLetter(ch))
                {
                    if (vowels.Contains(ch)) v++;
                    else c++;
                }
            }
            return (v, c);
        }

        static int FindSubstringPosition(string s, string sub)
        {
            if (string.IsNullOrEmpty(sub)) return -1;
            return s.IndexOf(sub);
        }

        static string CheckCharacterCase(char c)
            {
                if (!char.IsLetter(c)) return "Đây không phải là chữ cái (Alphabet).";

                if (char.IsUpper(c)) return "Đây là chữ cái IN HOA.";
                else return "Đây là chữ cái in thường.";
            }
        

        static int CountSubstringOccurrences(string s, string sub)
            {
                if (string.IsNullOrEmpty(sub)) return 0;

                int count = 0;
                int idx = 0;

                while ((idx = s.IndexOf(sub, idx)) != -1)
                {
                    count++;
                    idx += sub.Length;
                }
                return count;
            }

        static string InsertBeforeSubstring(string s, string targetSub, string insertStr)
            {
                int idx = s.IndexOf(targetSub);
                if (idx == -1) return s; 

               
                string leftPart = s.Substring(0, idx);
                string rightPart = s.Substring(idx);

                return leftPart + insertStr + rightPart;
            }




        
    }
}
