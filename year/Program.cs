using System;

namespace year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            // 讀取使用者輸入的整數 X
            while (true)
            {
                Console.Write("輸入 X: ");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("無效輸入，請重新輸入 X。");
                }
            }

            // 讀取使用者輸入的整數 Y
            while (true)
            {
                Console.Write("輸入 Y: ");
                if (int.TryParse(Console.ReadLine(), out y))
                {
                    if (y >= x)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Y 必須大於或等於 X，請重新輸入 Y。");
                    }
                }
                else
                {
                    Console.WriteLine("無效輸入，請重新輸入 Y。");
                }
            }

            Console.Write("");
            for (int year = x; year <= y; year++)
            {
                if (IsLeapYear(year))
                {
                    Console.Write($"{year},");
                }
            }
        }

        // 判斷是否為閏年的函數
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}