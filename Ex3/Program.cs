using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, numero1, numero2, resultado;
            double numero, raizQ;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Somar dois números.");
                Console.WriteLine("2 - Raiz quadrada de um número.");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Digite um número: ");
                    numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    numero2 = int.Parse(Console.ReadLine());

                    resultado = numero1 + numero2;

                    Console.WriteLine("A soma dos números é " + resultado);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Digite um número: ");
                    numero = double.Parse(Console.ReadLine());

                    raizQ = Math.Sqrt(numero);
                    Console.WriteLine("A raiz quadrada de " + numero + " é " + raizQ);
                }
                else
                {
                    Console.WriteLine("Opção incorreta, escolha 1 ou 2");
                }
            } while (opcao != 1 && opcao != 2);

            Console.ReadKey();
        }
    }
}