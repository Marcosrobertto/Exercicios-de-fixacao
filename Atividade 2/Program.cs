using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Álcool:
            //  até 20 litros, desconto de 3% por litro Álcool
            //  acima de 20 litros, desconto de 5% por litro

            //Gasolina:
            //  até 20 litros, desconto de 4% por litro Gasolina
            //  acima de 20 litros, desconto de 6% por litro

            //Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
            //da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
            //sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

            Console.WriteLine("Qual o tipo do combustivel? G - Gasolina ou A - Alcool");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de litros que desja abastecer");
            float litros = float.Parse(Console.ReadLine());

            // Declarações de variaveis
                float percentualDesconto;
                float precoAlcool = 4.9f;
                float precoGasolina = 5.3f;
                float totalDoDesconto, valorBruto, valorAPagar;

            switch (tipo.ToLower())
            {
                case "a":
                        if (litros<=20)
                        {
                            percentualDesconto = 0.03f;
                        }else{
                            percentualDesconto = 0.05f;
                        }
                        totalDoDesconto = (litros * precoAlcool) * percentualDesconto;
                        valorBruto = (litros * precoAlcool);
                        valorAPagar = valorBruto - totalDoDesconto;
                        Console.WriteLine($"Valor a ser pago é de : {valorAPagar}");
                    break;
                case "g":
                        if (litros<=20)
                        {
                            percentualDesconto = 0.04f;
                        }else{
                            percentualDesconto = 0.06f;
                        }
                        totalDoDesconto = (litros * precoGasolina) * percentualDesconto;
                        valorBruto = (litros * precoGasolina);
                        valorAPagar = valorBruto - totalDoDesconto;
                        Console.WriteLine($"Valor a ser pago é de : {valorAPagar}");
                    break;

                default:
                    break;
            }
            
        }
    }
}
