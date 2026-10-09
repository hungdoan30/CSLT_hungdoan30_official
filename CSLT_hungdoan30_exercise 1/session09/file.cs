using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session09
{
    internal class file_ex
    {
        static readonly string basePath = @"C:\Temp\CSharpFiles";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            string testFile = Path.Combine(basePath, "test_file.txt");
            string copyFile = Path.Combine(basePath, "copy_file.txt");
            string renameFile = Path.Combine(basePath, "renamed_file.txt");

            //  1. Tạo tệp trống 
            CreateBlankFile(testFile);

            //  2. Xóa tệp 
            RemoveFile(testFile);

            //  3. Tạo và ghi chuỗi vào tệp
            string initialText = "Day la dong dau tien.\nDay la dong thu hai.";
            CreateAndWriteText(testFile, initialText);

            //  4. Đọc tệp văn bản
            Console.WriteLine(ReadFileContext(testFile));

            //  5. Ghi mảng chuỗi vào tệp 
            string[] linesArray = { "Mang dong 1", "Mang dong 2", "Mang dong 3" };
            WriteArrayToFile(testFile, linesArray);
            Console.WriteLine("Đã ghi đè mảng chuỗi vào tệp.");

            //  6. Ghi nối (Append) vào tệp 
            AppendTextToFile(testFile, "Day la dong duoc them vao cuoi.");
            Console.WriteLine(ReadFileContext(testFile)); 

            //  7. Copy tệp và đọc 
            CopyFileAndRead(testFile, copyFile);

            //  8. Di chuyển/Đổi tên tệp 
            if (!File.Exists(copyFile)) File.Copy(testFile, copyFile);
            MoveOrRenameFile(copyFile, renameFile);

            string[] multiLines = { "Line 1", "Line 2", "Line 3", "Line 4", "Line 5" };
            File.WriteAllLines(testFile, multiLines);

            //  9. Đọc dòng đầu tiên 
            Console.WriteLine(ReadFirstLine(testFile));

            //  10. Đọc dòng cuối cùng 
            Console.WriteLine(ReadLastLine(testFile));

            //  11. Đọc N dòng cuối 
            int nLines = 3;
            Console.WriteLine($"Đọc {nLines} dòng cuối:");
            string[] lastN = ReadLastNLines(testFile, nLines);
            foreach (var line in lastN) Console.WriteLine(line);

            //  12. Đọc 1 dòng cụ thể 
            int lineNumber = 3;
            Console.WriteLine($"Dòng thứ {lineNumber}: {ReadSpecificLine(testFile, lineNumber)}");

            //  13. Đếm số dòng 
            Console.WriteLine($"Tổng số dòng: {CountLinesInFile(testFile)}");

            //  14. In cấu trúc thư mục 
            PrintDirectoryStructure(basePath);

            //  15. Thống kê ký tự 
            string statFile = Path.Combine(basePath, "stats.txt");
            File.WriteAllText(statFile, "Hello World 123!\nTesting 456...");
            CalculateStatistics(statFile);

            Console.WriteLine();
            Console.ReadKey();
        }

        // 1. Tạo tệp trống
        static void CreateBlankFile(string path)
        {
            using (FileStream fs = File.Create(path))
            {
                Console.WriteLine($"Đã tạo tệp trống: {path}");
            }
        }

        // 2. Xóa tệp
        static void RemoveFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine($"Đã xóa tệp: {path}");
            }
            else
            {
                Console.WriteLine("Tệp không tồn tại để xóa.");
            }
        }

        // 3. Tạo tệp và ghi chữ
        static void CreateAndWriteText(string path, string text)
        {
            File.WriteAllText(path, text);
            Console.WriteLine("Đã ghi chữ vào tệp.");
        }

        // 4. Đọc toàn bộ nội dung tệp
        static string ReadFileContext(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);
            return "Không tìm thấy tệp.";
        }

        // 5. Ghi mảng chuỗi vào tệp
        static void WriteArrayToFile(string path, string[] lines)
        {
            File.WriteAllLines(path, lines);
        }

        // 6. Ghi nối (append) văn bản
        static void AppendTextToFile(string path, string text)
        {
            File.AppendAllText(path, Environment.NewLine + text);
        }

        // 7. Copy tệp và đọc
        static void CopyFileAndRead(string source, string dest)
        {
            File.Copy(source, dest, true);
            Console.WriteLine($"Đã copy sang {dest}. Nội dung tệp mới:");
            Console.WriteLine(File.ReadAllText(dest));
        }
        // 8. Di chuyển / Đổi tên tệp (Move file)
        static void MoveOrRenameFile(string source, string dest)
        {
            if (File.Exists(source))
            {
                if (File.Exists(dest)) File.Delete(dest); 
                File.Move(source, dest);
                Console.WriteLine($"Đã đổi tên tệp thành: {dest}");
            }
            else
            {
                Console.WriteLine("Tệp nguồn không tồn tại.");
            }
        }

        // 9. Đọc dòng đầu tiên
        static string ReadFirstLine(string path)
        {
            if (!File.Exists(path)) return "Tệp không tồn tại.";

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadLine() ?? "Tệp rỗng.";
            }
        }

        // 10. Đọc dòng cuối cùng
        static string ReadLastLine(string path)
        {
            if (!File.Exists(path)) return "Tệp không tồn tại.";
            string[] lines = File.ReadAllLines(path);
            if (lines.Length == 0) return "Tệp rỗng.";
            return lines[lines.Length - 1];
        }
        // 11. Đọc n dòng cuối
        static string[] ReadLastNLines(string path, int n)
        {
            if (!File.Exists(path)) return new string[0];
            string[] lines = File.ReadAllLines(path);

            int start = Math.Max(0, lines.Length - n);
            int count = Math.Min(n, lines.Length);

            string[] result = new string[count];
            Array.Copy(lines, start, result, 0, count);
            return result;
        }

        // 12. Đọc 1 dòng cụ thể (index bắt đầu từ 1)
        static string ReadSpecificLine(string path, int lineNumber)
        {
            if (!File.Exists(path)) return "Tệp không tồn tại.";
            string[] lines = File.ReadAllLines(path);

            if (lineNumber > 0 && lineNumber <= lines.Length)
                return lines[lineNumber - 1];
            return "Số dòng vượt quá giới hạn.";
        }

        // 13. Đếm số lượng dòng
        static int CountLinesInFile(string path)
        {
            if (!File.Exists(path)) return 0;
            return File.ReadAllLines(path).Length;
        }

        // 14. In cấu trúc thư mục (Lấy toàn bộ thư mục và tệp con)
        static void PrintDirectoryStructure(string dirPath)
        {
            if (!Directory.Exists(dirPath))
            {
                Console.WriteLine("Thư mục không tồn tại.");
                return;
            }

            Console.WriteLine($"Thư mục gốc: {dirPath}");

            string[] entries = Directory.GetFileSystemEntries(dirPath);
            foreach (string entry in entries)
            {
                Console.WriteLine("  |-- " + Path.GetFileName(entry));
            }

        }
        // 15. Thống kê ký tự chữ và số (Dùng mảng 2 chiều theo Hint)
        static void CalculateStatistics(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Tệp không tồn tại.");
                return;
            }

            string content = File.ReadAllText(path);

            int[,] stats = new int[1, 2];

            foreach (char c in content)
            {
                if (char.IsLetter(c))
                    stats[0, 0]++; 
                else if (char.IsDigit(c))
                {
                    stats[0, 1]++;
                }
            }

            Console.WriteLine($"Tổng số Chữ cái (Alphabets): {stats[0, 0]}");
            Console.WriteLine($"Tổng số Chữ số (Numbers):   {stats[0, 1]}");
        }
    }
    
}
