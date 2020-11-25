using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano que você nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if(idade >=16){
                Console.WriteLine();
                Console.WriteLine("Você já pode votar =) ");
                Console.WriteLine();
            }else{
                Console.WriteLine();
                Console.WriteLine("Você não tem idade para votar =( idade minima é 16 anos");
                Console.WriteLine();
            }
        }
    }
}
