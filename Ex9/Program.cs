using System;

namespace POO2Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Maior de 2 números==");

            MaiorIgual m;
            m = new MaiorIgual();

            Console.Write("Digite o primeiro número: ");
            m.setn1(int.Parse(Console.ReadLine()));

            Console.Write("Digite o segundo número: ");
            m.setn2(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            if (m.indicarMaior() == 0)
            {
                Console.WriteLine("Os numeros são idênticos");
            }
            else
            {
                if (m.indicarMaior() == 1)
                {
                    Console.WriteLine("Maior: {0} (primeiro número)", m.getn1());
                }
                else
                {
                    Console.WriteLine("Maior: {0} (segundo número)", m.getn2());
                }
            }
        }
    }
}
