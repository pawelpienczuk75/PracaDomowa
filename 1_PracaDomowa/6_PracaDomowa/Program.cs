using System;

namespace _6_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = "adb qwe wer stw";

            Counter myString = new Counter();

            int myWords = myString.Words(inputData);
            int myCharacters = myString.Characters(inputData);

            Console.WriteLine("Iość słów w stringu wynosi: {0}",myWords);
            Console.WriteLine("Iość znaków w stringu wynosi: {0}", myCharacters);

            Console.ReadKey();
        }
    }
}
