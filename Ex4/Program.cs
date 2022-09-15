using System;

namespace POO2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Área do triangulo a partir da base & altura==");

            AreaTriangulo at;
            at = new AreaTriangulo();

            do
            {
                Console.Write("Digite a Base: ");
                at.setBasin(double.Parse(Console.ReadLine()));
            }
            while (at.getBasin() <= 0);

            do
            {
                Console.Write("Digite a Altura: ");
                at.setAltura(double.Parse(Console.ReadLine()));
            }
            while (at.getAltura() <= 0);

            at.calcular();

            Console.WriteLine();
            Console.WriteLine("Base = {0}; Altura = {1}", at.getBasin(), at.getAltura());
            Console.Write("Área = {0}", at.getResultado());
        }
    }
}
