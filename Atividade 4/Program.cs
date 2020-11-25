using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor: ");
            int valor = int.Parse(Console.ReadLine());

            int maior = valor;
            int menor = valor;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor > maior)
                {
                    maior = valor;
                }
                else if (valor < menor)
                {
                    menor = valor;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Menor valor: "+ maior);
            Console.WriteLine("Menor valor: "+ menor);
        }
    }
}
