using System;

/** <remark>
 * Write a method ReadNumber(int start, int end) that enters an integer number in given range[start..end].
 * If invalid number or non-number text is entered, the method should throw an exception.
 * Base on this method write a program that enters 10 numbers:
 * a1, a2, ... a10 such that 1 < a1 < ... < a10 < 100.
 *
 * Напишите метод ReadNumber(int start, int end), который вводит целочисленное число в заданном диапазоне [start..end].
 * Если введен неверный номер или текст без номера, метод должен выдать исключение.
 * Основываясь на этом методе, напишите программу, которая вводит 10 чисел:
 * a1, a2, ... a10 таким образом, что 1 < a1 < ... < a10 < 100.
 </remark> */

namespace _20180306_Task2_Exception
{
    internal class Program
    {
        /// <summary>
        /// Temporary variable.
        /// </summary>
        private static int oldNumber;

        /// <summary>
        /// Method ReadNumber() that enters an integer number in given range[start..end].
        /// </summary>
        /// <param name="input">The value entered by the user.</param>
        /// <param name="start">Value of the beginning of the range.</param>
        /// <param name="end">Value of the end of the range.</param>
        private static void ReadNumber(string input, int start = 1, int end = 100)
        {
            bool isInt = int.TryParse(input, out int number);

            try
            {
                if (isInt == false || number <= oldNumber || number <= start || number >= end)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("Violation of the range [1 < a1 < ... < a10 < 100]");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Super!");
                oldNumber = number;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter 10 numbers [a1...a10] in the range [1 < a1 < ... < a10 < 100]\n");

            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Enter {0,-2} number: ", i + 1);
                ReadNumber(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThe End :)");

            Console.ReadKey();
        }
    }
}