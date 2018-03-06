using System;
using System.Collections.Generic;
using System.Text;

namespace _1_PracaDomowa
{
    public class Verify
    {
        private int[] _wagi = new int[]
        {
            1, 3, 7, 9, 1, 3, 7, 9, 1, 3
        };
       public bool Pesel(int[] pesel)
         {
            int p = 0;

            for (int i = 0; i < _wagi.Length; i++)
            {
               p =  _wagi[i] * pesel[i] + p;
            }

            int mod = p % 10;
            if (pesel[10] == 10 - mod)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
