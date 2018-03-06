using System;

namespace _4_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 4;
            int result = 0;

            string myOperation = "div";

            Math myMath = new Math();

            if( myOperation == "add")
            {
                result = myMath.Calc(a, b, myOperation);
                Console.WriteLine("Wynik dodawania liczb {0} do liczby {1} rówana się {2}.",a,b,result);
            }
            else if (myOperation == "sub")
            {
                result = myMath.Calc(a, b, myOperation);
                Console.WriteLine("Wynik odejmowania liczby {0} od liczby {1} rówana się {2}.", b, a, result);
            }
            else if (myOperation == "mul")
            {
                result = myMath.Calc(a, b, myOperation);
                Console.WriteLine("Wynik dzielenia liczb {0} przez liczbę {1} rówana się {2}.", a, b, result);
            }
            else if (myOperation == "div")
            {
                result = myMath.Calc(a, b, myOperation);
                Console.WriteLine("Wynik mnożenia liczb {0} przez liczbę {1} rówana się {2}.", a, b, result);
            }


            Console.ReadKey();
        }
    }
}
