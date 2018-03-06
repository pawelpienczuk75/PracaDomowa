using System;

namespace _3_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 70;
            double height = 181;

            Util myUtil = new Util();

            double bmi = myUtil.BMI(weight,height);

            Console.WriteLine("{0}", bmi);
            Console.ReadKey();
        }
    }
}
