﻿using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 126;
            int n2 = 1000;
            // for bigger number than this you need long type
            int n3 = 2147483647;
            long n4 = 2147483648L;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}
