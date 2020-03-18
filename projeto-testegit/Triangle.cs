using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_testegit
{
    class Triangle
    {
        public double A;
        public double B;
        public double C; 

        public double Area() //esta função não leva parametros pk está dentro da class
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }
}
