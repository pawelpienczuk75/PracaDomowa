using System;
using System.Collections.Generic;
using System.Text;

namespace _6_PracaDomowa
{
    public class Counter
    {
        public int Words(string text)
        {
            string[] tab = text.Split(' ');
            int c = tab.Length;
            return c;
        }

        public int Characters(string text)
        {
         int length = text.Length;
         return length;
        }

    }
}
