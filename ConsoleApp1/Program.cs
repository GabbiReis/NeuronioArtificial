
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        NeuronioArtificial neuronioArtificial = new NeuronioArtificial(0.5);

        List<Entradas> entradas = new List<Entradas>
        {
            new Entradas(113, 6.8, 1), 
            new Entradas(122, 4.7, 0), 
            new Entradas(107, 5.2, 1), 
            new Entradas(98, 3.5, 1),
            new Entradas(115, 2.9, 0),
            new Entradas(120, 4.2, 0)
        };

        neuronioArtificial.Treinar(entradas);

        Console.WriteLine("\nTestando novos casos:");

        List<Entradas> novosCasos = new List<Entradas>
        {
            new Entradas(110, 5.5, 1), 
            new Entradas(125, 3.0, 0), 
            new Entradas(105, 6.0, 1),
            new Entradas(116, 3.7, 0),
            new Entradas(102, 5.8, 1)
        };

        foreach (var novoCaso in novosCasos)
        {
            int resultado = neuronioArtificial.Perguntar(novoCaso.Entrada1, novoCaso.Entrada2);
            Console.WriteLine($"Entrada: Peso = {novoCaso.Entrada1}, pH = {novoCaso.Entrada2} -> Resultado: {(resultado == 1 ? "Maçã" : "Laranja")}");
        }
    }
}
