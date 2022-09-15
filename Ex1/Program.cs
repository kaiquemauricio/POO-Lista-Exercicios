using System;

namespace POO2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Area a;
            a = new Area();

            Console.WriteLine("==Calcular área do retângulo (base e altura)==");

            do
            {
                Console.Write("Digite a Base: ");
                a.setB1(int.Parse(Console.ReadLine()));
            }
            while (a.getB1() <= 0);

            do
            {
                Console.Write("Digite a Altura: ");
                a.setAltura(int.Parse(Console.ReadLine()));
            }
            while (a.getAltura() <= 0);

            a.calcular();

            Console.WriteLine();
            Console.WriteLine("Base = {0}; Altura = {1}", a.getB1(), a.getAltura());
            Console.Write("Área do retângulo = {0}", a.getResultado());
        }
    }
}

