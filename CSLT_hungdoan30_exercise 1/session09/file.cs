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



    }
    
}
