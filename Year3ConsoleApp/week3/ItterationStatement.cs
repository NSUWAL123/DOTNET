using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.week3
{
    public class ItterationStatement
    {
        public static void whileLoop(int num1)
        {
            while (num1 < 10)
            {
                Console.WriteLine(num1);
                num1++;
            }
        }

        public static void doWhileLoop(int num1)
        {
            do
            {
                Console.WriteLine(num1);
                num1++;
            }
            while (num1 < 10);
        }

        public static void forLoop(int num1)
        {
            for (int i = num1; i < 20; i++) 
            {
                Console.WriteLine(i);
            }
        }

        public static void forEachLoop(int num1)
        {
            var nums = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
            foreach (int ele in nums)
            {
                Console.Write($"{ele} \n");
            }
        }
    }
}