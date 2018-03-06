using System;
using System.Collections.Generic;
using System.Text;

namespace _5_PracaDomowa
{
    public class Calc
    {
        int c = 0;

        public int Add(int a, int b)
        {
            c = a + b;
            return c;
        }
        public int Sub(int a, int b)
        {
            c = a - b;
            return c;
        }

        public int Mul(int a, int b)
        {
            c = a / b;
            return c;
        }

        public int Div(int a, int b)
        {
            c = a * b;
            return c;
        }

    }
}
