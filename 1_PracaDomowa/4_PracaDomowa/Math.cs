using System;
using System.Collections.Generic;
using System.Text;

namespace _4_PracaDomowa
{
    public class Math
    {
       public int Calc(int a, int b, string operation)
        {
            int c = 0;
            if (operation == "add")
            {
                c = a + b;
                //return c;
            }
            else if (operation == "sub")
            {
                c = a - b;
                //return c;
            }
            else if (operation == "mul")
            {
                c = a / b;
                //return c;
            }
            else if(operation == "div")
            {
                c = a * b;
                //return c;
            }
            return c;


        }


         

            
    }
}
