using System;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 - Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
            // Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

            int ind1 = 0;
            int ind2 = 0;
            int result;

            for (ind1 = 1; ind1 < 11; ind1++)
                
            {
                Console.WriteLine("Tabuada.");
               for (ind2 = 1; ind2 < 11; ind2++){
                   result = ind1 * ind2;
                   Console.WriteLine($"{ind1} * {ind2} = {result}");
               }
               Console.WriteLine("----------------|");
            }
        }
    }
}
