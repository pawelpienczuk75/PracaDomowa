using System;


namespace _1_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Verify myVerify = new Verify();

            int[] pesel = new int[]
            {
                7,5,0,4,2,5,0,7,4,3,9
            };

            bool forVerrify = false;

            forVerrify = myVerify.Pesel(pesel);

            Console.WriteLine(forVerrify);

            Console.ReadKey();
        }
    }
}
