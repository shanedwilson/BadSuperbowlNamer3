﻿using System;

namespace BadSuperbowlNamer3
{
    class Program
    {
        static void Main(string[] args)
        {
            startApp();
        }

        static void startApp()
        {
            var convertor = new NumberToRomanConvertor();

            Console.WriteLine("Please enter the number you would like to convert to Roman numerals");
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Your answer is {convertor.ToRoman(input)}");
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("Would you like to convert again? (y/n)");

            var answer = Console.ReadLine().ToLower();
            if (answer != "y")
            {
                Environment.Exit(-1);
            }
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine();
            startApp();
        }
    }
}
