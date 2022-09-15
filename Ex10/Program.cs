using System;

namespace POO2Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Área de um retângulo, terreno grande-pequeno==");

            Terreno t;
            t = new Terreno();

            do
            {
                Console.Write("Digite a base do retângulo: ");
                t.setBasin(double.Parse(Console.ReadLine()));
            }
            while (t.getBasin() <= 0);

            do
            {
                Console.Write("Digite a altura do retângulo: ");
                t.setAltura(double.Parse(Console.ReadLine()));
            }
            while (t.getAltura() <= 0);

            t.calcular();

            Console.WriteLine();
            Console.Write("Area = {0} ", t.getArea());
            if (t.getArea() > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }

        }
    }
}
