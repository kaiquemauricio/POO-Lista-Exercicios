using System;

namespace POO2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Área do quadrado a partir da diagonal==");
            Console.WriteLine();

            AreaDiagonal ad;
            ad = new AreaDiagonal();

            do
            {
                Console.Write("Digite o valor da diagonal: ");
                ad.setDiagonal(double.Parse(Console.ReadLine()));
            }
            while (ad.getDiagonal() < 0);

            ad.calcular();

            Console.WriteLine();
            Console.WriteLine("Diagonal = {0}", ad.getDiagonal());
            Console.Write("Área = {0}", ad.getResultado());
        }
    }
}
