using System;

namespace POO2Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Dolar para Real==");

            CotaDolar cd;
            cd = new CotaDolar();

            do
            {
                Console.Write("Digite a Cotação do dolar atual: ");
                cd.setCotacao(double.Parse(Console.ReadLine()));
            }
            while (cd.getCotacao() <= 0);

            do
            {
                Console.Write("Digite o valor em dolar (00,00): ");
                cd.setQuantia(double.Parse(Console.ReadLine()));
            }
            while (cd.getQuantia() <= 0);

            cd.calcular();

            Console.WriteLine();
            Console.WriteLine("Cotação: {0}; Quantia: ${1}", cd.getCotacao(), cd.getQuantia().ToString("##00.00"));
            Console.Write("Quantia em Real = R${0}", cd.getResultado().ToString("##00.00"));
        }
    }
}
