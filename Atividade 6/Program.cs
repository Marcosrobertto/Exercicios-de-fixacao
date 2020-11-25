using System;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
            // lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
            // pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
            // entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

            string[] list = new string [10];

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Digite os nomes da lista: ");
                list[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Digite um nome para ser verificado na lista: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < list.Length; i++)
            {
                if(nome == list[i]){
                    Console.WriteLine($"ACHEI O NOME NA LISTA");
                }else{
                    Console.WriteLine($"NÃO ACHEI O NOME NA LISTA");
                }
            }
        }
    }
}
