using System;

namespace _2_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Math myMath = new Math();

            int bb = 5;
            int aa = 4;
            int cc;

            cc = myMath.Add(aa, bb);
            
            Console.WriteLine(cc);
            Console.ReadKey();
        }
    }
}
