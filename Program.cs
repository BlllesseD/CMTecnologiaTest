using System;

namespace CMTecnologiaTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma das opção:");
            Console.WriteLine("1 - Questão 1 - Calcular Quadrado e a raiz:");
            Console.WriteLine("2 - Questão 2 - Verificar se o ano é bissexto:");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Por favor, digite o primeiro número:");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Agora, digite o segundo número:");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double menorNumero = Math.Min(numero1, numero2);
                double maiorNumero = Math.Max(numero1, numero2);

                double quadradoMenorNumero = Math.Pow(menorNumero, 2);
                double raizQuadradaMaiorNumero = Math.Sqrt(maiorNumero);

                Console.WriteLine($"O quadrado do menor número ({menorNumero}) é: {quadradoMenorNumero}");

                if (maiorNumero >= 0)
                {
                    Console.WriteLine($"A raiz quadrada do maior número ({maiorNumero}) é: {raizQuadradaMaiorNumero}");
                }
                else
                {
                    Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o ano de nascimento desejado, para verificar se é um ano Bissexto ou não:");
                int ano = Convert.ToInt32(Console.ReadLine());

                if (DateTime.IsLeapYear(ano))
                {
                    Console.WriteLine($"{ano} é um ano bissexto.");
                }
                else
                {
                    Console.WriteLine($"{ano} não é um ano bissexto.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
            }
        }
    }
}
