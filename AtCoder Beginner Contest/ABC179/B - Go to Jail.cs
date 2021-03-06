using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;
using static System.Math;

namespace AtCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = ReadInt();
            var zorome_count = 0;
            var Ans = "No";
            for (int i = 0; i < N; i++)
            {
                var D = ReadInts();
                if (D[0] == D[1]) zorome_count++;
                else zorome_count = 0;

                if (zorome_count >= 3)
                {
                    Ans = "Yes";
                }
            }
            WriteLine(Ans);
        }

        private static string Read() { return ReadLine(); }
        private static string[] Reads() { return (Read().Split()); }
        private static int ReadInt() { return int.Parse(Read()); }
        private static long ReadLong() { return long.Parse(Read()); }
        private static double ReadDouble() { return double.Parse(Read()); }
        private static int[] ReadInts() { return Array.ConvertAll(Read().Split(), int.Parse); }
        private static long[] ReadLongs() { return Array.ConvertAll(Read().Split(), long.Parse); }
        private static double[] ReadDoubles() { return Array.ConvertAll(Read().Split(), double.Parse); }
    }
}
