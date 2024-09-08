using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Entradas
    {
        public Entradas(double entrada1, double entrada2
            , int resultadoEsperado)
        {
            Entrada1 = entrada1;
            Entrada2 = entrada2;
            ResultadoEsperado = resultadoEsperado;
        }

        public double Entrada1 { get; private set; }
        public double Entrada2 { get; private set; }
        public int ResultadoEsperado { get; private set; }

       
    }
}
