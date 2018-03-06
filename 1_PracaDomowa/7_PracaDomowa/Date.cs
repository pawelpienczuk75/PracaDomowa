using System;
using System.Collections.Generic;
using System.Text;

namespace _7_PracaDomowa
{
    public class Date
    {
        public bool Check(int year, int month, int day)
        {
            bool c;

            if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
            {
                if ((day <= 31) && (day > 0))
                {
                    c = true;
                    return c;
                }
                else
                {
                    c = false;
                    return c;
                }

            }
            else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
            {
                if ((day <= 30) && (day > 0))
                {
                    c = true;
                    return c;
                }
                else
                {
                    c = false;
                    return c;
                }
            }
            else if (month == 2)
            {
                if ((day <= 28) && (day > 0))
                {
                    c = true;
                    return c;
                }
                else
                {
                    c = false;
                    return c;
                }
            }
            else
            {
                c = false;
                return c;
            }

        }
    }
}