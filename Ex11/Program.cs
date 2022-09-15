using System;

namespace POO2Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==IMC==");
            Console.WriteLine();

            IMC i;
            i = new IMC();

            do
            {
                Console.Write("Digite sua altura(0,00): ");
                i.setAltura(double.Parse(Console.ReadLine()));
            }
            while (i.getAltura() > 2.7 || i.getAltura() < 0.6);

            do
            {
                Console.Write("Digite seu peso(kg): ");
                i.setPeso(double.Parse(Console.ReadLine()));
            }
            while (i.getPeso() > 600 || i.getPeso() < 27);

            i.calcular();

            Console.WriteLine();
            Console.Write("IMC = {0} |", i.getImc());

            if (i.getImc() < 20)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else
            {
                if (i.getImc() >= 25)
                {
                    Console.WriteLine("Você está acima do peso");
                }
                else
                {
                    Console.WriteLine("Você está no seu peso ideal");
                }
            }
        }
    }
}
