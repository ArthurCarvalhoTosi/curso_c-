using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste5
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double p;
        public double raiz;

        public double CalcularArea()
        {
         
            p = (A + B + C) / 2.0;
            raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
            
        }
    }
}
