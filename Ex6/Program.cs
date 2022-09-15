using System;

namespace POO2Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Milhas marítmas para quilômetros==");

            MilhaQuilo mq;
            mq = new MilhaQuilo();

            do
            {
                Console.Write("Digite a quantia em Milhas Marítmas: ");
                mq.setMilhas(double.Parse(Console.ReadLine()));
            }
            while (mq.getMilhas() <= 0);

            mq.calcular();

            Console.WriteLine();
            Console.WriteLine("{0} Milhas Marítmas = {1} Km", mq.getMilhas(), mq.getResultado());
        }
    }
}
