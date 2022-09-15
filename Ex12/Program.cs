using System;

namespace POO2Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-ABC Formação de triangulo==");
            Console.WriteLine();

            FTriangulo ft;
            ft = new FTriangulo();

            do
            {
                Console.Write("Digite o valor do lado A: ");
                ft.setA(int.Parse(Console.ReadLine()));
            }
            while (ft.getA() <= 0);

            do
            {
                Console.Write("Digite o valor do lado B: ");
                ft.setB(int.Parse(Console.ReadLine()));
            }
            while (ft.getB() <= 0);

            do
            {
                Console.Write("Digite o valor do lado C: ");
                ft.setC(int.Parse(Console.ReadLine()));
            }
            while (ft.getC() <= 0);

            Console.WriteLine();
            ft.triangular();
        }
    }
}
