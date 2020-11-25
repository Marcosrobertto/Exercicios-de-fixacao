using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            // preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            // desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            // - Se quantidade <= 5 o desconto será de 2%
            // - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            // - Se quantidade > 10 o desconto será de 5%

            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade do produto: ");
            float quantidade = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite preço unitario do produto: ");
            float preco = float.Parse(Console.ReadLine());

            float total = quantidade * preco;

            if (quantidade <=5)

            // 2%

            {
                float desconto = total * 0.02f;
                float totalAPagar = total - desconto;
                Console.WriteLine("O valor a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Produto com o desconto fica: " + totalAPagar);
            }

            // 3%

            else if (quantidade >5 && quantidade <=10){
                float desconto = total * 0.03f;
                float totalAPagar = total - desconto;
                Console.WriteLine("O valor a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Produto com o desconto fica: " + totalAPagar);
            }

            // 5%

            else if (quantidade >10){
                float desconto = total * 0.05f;
                float totalAPagar = total - desconto;
                Console.WriteLine("O valor a pagar é de: " + total);
                Console.WriteLine("Seu desconto é de: " + desconto);
                Console.WriteLine("Produto com o desconto fica: " + totalAPagar);
            }else{
                Console.WriteLine("Digite um valor valido");
            }
            
        }
    }
}
