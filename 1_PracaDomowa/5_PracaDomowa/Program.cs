using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _5_PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = "";
            string element1 = "";
            string element2 = "";

            int a = 0;
            int b = 0;

            Calc myCalC = new Calc();

            do
            {
                Console.WriteLine("Dostępne polecenia:");
                Console.WriteLine("Dodawanie polecenie: ADD");
                Console.WriteLine("Odejmowanie polecenie: SUB");
                Console.WriteLine("Dzielenie polecenie: MUL");
                Console.WriteLine("Mnożenie polecenie: DIV");
                Console.WriteLine("Wyjście z programu: EXIT");
                Console.WriteLine();
                Console.WriteLine("Czekam na Polecenie:");
                command = Console.ReadLine();


                // Dodawanie

                if (command == "ADD")
                { 

                    Console.WriteLine("Podaj pierwszy składnik sumy:");
                    element1 = Console.ReadLine();
                    Int32.TryParse(element1, out a);

                    Console.WriteLine("Podaj drugi składnik sumy:");
                    element2 = Console.ReadLine();
                    Int32.TryParse(element2, out b);

                    int c = myCalC.Add(a, b);

                    Console.WriteLine("Wynik sumy:{0}",c);

                }


                //odejmowanie

                else if (command == "SUB") 
                {

                  Console.WriteLine("Podaj odjemną:");
                  element1 = Console.ReadLine();
                  Int32.TryParse(element1, out a);

                  Console.WriteLine("Podaj odjemnik:");
                  element2 = Console.ReadLine();
                  Int32.TryParse(element2, out b);

                  int c = myCalC.Sub(a, b);

                  Console.WriteLine("Wynik odejmowania:{0}", c);
                }


                //dzielenie

                else if (command == "MUL") 
                {

                    Console.WriteLine("Podaj dzielną:");
                    element1 = Console.ReadLine();
                    Int32.TryParse(element1, out a);

                    Console.WriteLine("Podaj dzielnik:");
                    element2 = Console.ReadLine();
                    Int32.TryParse(element2, out b);

                    int c = myCalC.Mul(a, b);

                    Console.WriteLine("Wynik dzielenia:{0}", c);
                }


                //mnożnenie

                else if (command == "DIV") 
                {

                    Console.WriteLine("Podaj pierwszy czynnik mnożenia:");
                    element1 = Console.ReadLine();
                    Int32.TryParse(element1, out a);

                    Console.WriteLine("Podaj drugi czynnik mnożenia:");
                    element2 = Console.ReadLine();
                    Int32.TryParse(element2, out b);

                    int c = myCalC.Div(a, b);

                    Console.WriteLine("Wynik mnożenia:{0}", c);
                }
                else
                {
                    Console.WriteLine("Nie znana komenda");
                }

            }

            while (command != "EXIT");
            
        }
    }
}
