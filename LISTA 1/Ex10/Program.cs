using System;

namespace ExemploAumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, novoSalario;

            Console.WriteLine("Digite o salário do funcionário:");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual < 700)
            {
                novoSalario = salarioAtual + (salarioAtual * 0.3); // aumento de 30%
            }
            else
            {
                novoSalario = salarioAtual + (salarioAtual * 0.1); // aumento de 10%
            }

            Console.WriteLine("Novo salário: R$ " + novoSalario.ToString("F2"));

            Console.ReadKey();
        }
    }
}