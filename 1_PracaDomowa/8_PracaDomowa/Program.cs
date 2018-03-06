using System;

namespace _8_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = "dupa trupa gora";

            Censor myCensor = new Censor();

            int c = myCensor.Check(inputData);
            string outputData = myCensor.Censorship(inputData);


            Console.WriteLine(c);
            Console.WriteLine(outputData);



            Console.ReadKey();
        }
    }
}
