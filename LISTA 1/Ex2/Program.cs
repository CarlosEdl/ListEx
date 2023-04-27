using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            // solicita ao usuário que digite um número inteiro
            Console.WriteLine("Digite um número inteiro: ");
            numero = int.Parse(Console.ReadLine());

            // Verifica se o número é par ou ímpar 
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é par!");

            }
            else
            {
                Console.WriteLine("O número " + numero + " é ímpar!");
            }

            
            Console.ReadKey();
        }
    }
}