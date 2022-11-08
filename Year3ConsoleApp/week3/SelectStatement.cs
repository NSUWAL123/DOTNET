using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Year3ConsoleApp.week3
{
    public class SelectStatement
    {
        public static void ElseIfStatement(int num1, int num2) {
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than  {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
        }


        public static void SwitchStatement()
        {
            Console.WriteLine("Press 1 of fruits");
            Console.WriteLine("Press 2 of vegetables");
            Console.WriteLine("Press 3 of meat");


            var a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("Fruits");
                    break;
                case "2":
                    Console.WriteLine("Vegetables");
                    break;
                case "3":
                    Console.WriteLine("Meat");
                    break;
                default:
                    Console.WriteLine("Input value incorrect");
                    break;
            }
        }
    }
}