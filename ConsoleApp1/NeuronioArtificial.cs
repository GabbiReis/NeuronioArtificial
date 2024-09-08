using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NeuronioArtificial
    {       
        public Pesos pesos { get; private set; }

        public double o { get; private set; }

        public double taxaAprendizado { get; private set; }

        public NeuronioArtificial(double pTaxaAprendizado)
        {
            o = 0.0;
            taxaAprendizado = pTaxaAprendizado;
            pesos = new Pesos();
            this.taxaAprendizado = taxaAprendizado;

        }

        public void Treinar(List<Entradas> listaEntradas)
        {
            bool erro = true;
            int iteracao = 0;

            while (erro)
            {
                erro = false;
                Console.WriteLine($"Iteração {iteracao}: Pesos -> W1: {pesos.W1}, W2: {pesos.W2}");

                foreach (var entrada in listaEntradas)
                {
                    o = entrada.Entrada1 * pesos.W1 + entrada.Entrada2 * pesos.W2;
                    int saida = FuncaoClassificacao(o);

                    if (saida != entrada.ResultadoEsperado)
                    {
                        erro = true;
                        RecalcularPesos(entrada, saida);
                    }
                }
                iteracao++;
            }
        }

        private int FuncaoClassificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }


        private void RecalcularPesos(Entradas entrada, int saida)
        {
            double erro = entrada.ResultadoEsperado - saida;
            double deltaW1 = taxaAprendizado * erro * entrada.Entrada1;
            double deltaW2 = taxaAprendizado * erro * entrada.Entrada2;
            pesos.AtualizarPesos(deltaW1, deltaW2);

            Console.WriteLine($"Ajustando pesos: W1: {pesos.W1}, W2: {pesos.W2}");
        }

        public int Perguntar(double x1, double x2)
        {
            o = x1 * pesos.W1 + x2 * pesos.W2;
            return FuncaoClassificacao(o);
        }
    }
}
