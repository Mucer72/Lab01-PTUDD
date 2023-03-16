using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm2
{
    internal class Bai3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }
        public static long GiaThua(int n)
        {
            if(n==0) return 1;
            return n * GiaThua(n - 1);
        }
    }
}
