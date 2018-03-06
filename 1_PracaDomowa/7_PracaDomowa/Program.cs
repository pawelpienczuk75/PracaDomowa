using System;

namespace _7_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 29;
            int month = 2;
            int year = 2018;
            bool dateCheck;

            Date myDate = new Date();

            dateCheck = myDate.Check(year, month, day);

            Console.WriteLine(dateCheck);

            Console.ReadKey();
        }
    }
}
