using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            // Solicita ao usuário que digite os dois números
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            // Compara os números e exibe o maior
            if (num1 > num2)
            {
                Console.WriteLine("O maior número é: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O maior número é: " + num2);
            }
            else
            {
                Console.WriteLine("Os números são iguais!");
            }

            // Aguarda o usuário pressionar uma tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}