using System;

namespace POO2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Área do quadrado (aresta)==");

            AreaQuadrado aq;
            aq = new AreaQuadrado();

            do
            {
                Console.Write("Digite o valor da Aresta: ");
                aq.setAresta(double.Parse(Console.ReadLine()));
            }
            while (aq.getAresta() <= 0);

            aq.calcular();

            Console.WriteLine();
            Console.WriteLine("Aresta: {0}", aq.getAresta());
            Console.Write("Área do Quadrado = {0}", aq.getResultado());
        }
    }
}
