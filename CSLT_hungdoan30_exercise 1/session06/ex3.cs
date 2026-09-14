using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_hungdoan30_exercise_1.session06
{
    class sinhvien
    {
        public string Mssv { get; set; }
        public string Hoten { get; set; }
    }
    internal class ex3
    {
        static void DoitenSV(sinhvien sv)
        {
            sv.Hoten = "Doan Duy Hung";
        }


        public static void Main123(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            sinhvien s = new sinhvien();
            {
                s.Mssv = "31251027956";
                s.Hoten = "Hung Doan";

                DoitenSV(s);
                Console.WriteLine($"MSSV: {s.Mssv}, Họ tên: {s.Hoten}");
            }
        }
    }
}
