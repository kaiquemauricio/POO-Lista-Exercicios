using System;

namespace POO2Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==ABC formam triângulo retângulo==");

            TriRetan t;
            t = new TriRetan();

            do
            {
                Console.Write("Digite o valor do lado A: ");
                t.setA(int.Parse(Console.ReadLine()));
            }
            while (t.getA() <= 0);

            do
            {
                Console.Write("Digite o valor do lado B: ");
                t.setB(int.Parse(Console.ReadLine()));
            }
            while (t.getB() <= 0);

            do
            {
                Console.Write("Digite o valor do lado C: ");
                t.setC(int.Parse(Console.ReadLine()));
            }
            while (t.getC() <= 0);

            Console.WriteLine();
            t.trianguloRetangular();
        }
    }
}

