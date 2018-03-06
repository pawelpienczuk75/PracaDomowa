using System;
using System.Collections.Generic;
using System.Text;

namespace _3_PracaDomowa
{
    public class Util
    {
        public double BMI(double weight, double height)
        {
            height = height / 100;
            height = height * height;
            double bmi = weight / height;

            bmi = Math.Round(bmi,2);
            return bmi;


        }
    }
}
