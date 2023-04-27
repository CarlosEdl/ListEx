using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double salario, aumento;
            string cargo = "";

            Console.WriteLine("Digite numero correspondente ao seu cargo: ");
            Console.WriteLine(" 1 - Escrituário");
            Console.WriteLine(" 2 - Secretário");
            Console.WriteLine(" 3 - Caixa");
            Console.WriteLine(" 4 - Gerente");
            Console.WriteLine(" 5 - Diretor");
            codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o seu salário: ");
            salario = float.Parse(Console.ReadLine());

            double Aumento = 0, novoSalario = 0;


            if (codigo == 1)
            {
                aumento = salario * 0.5;
                novoSalario = salario + aumento;
                cargo = "Escrituario";
            }

            else if (codigo == 2)
            {
                aumento = salario * 0.35;
                novoSalario = salario + aumento;
                cargo = "Secretário";
            }

            else if (codigo == 3)
            {
                aumento = salario * 0.2;
                novoSalario = salario + aumento;
                cargo = "Caixa";
            }

            else if (codigo == 4)
            {
                aumento = salario * 0.1;
                novoSalario = salario + aumento;
                cargo = "Gerente";
            }

            else if (codigo == 5)
            {
                aumento = 0;
                novoSalario = salario + aumento;
                cargo = "Diretor";
            }

            else
            {
                Console.WriteLine("Código inválido!");
                return;
            }

            Console.WriteLine("Seu cargo é " + cargo + " o valor do aumento é R$ " + aumento + " Seu novo salário é R$ " +novoSalario+ ".");

            Console.ReadKey();

        }
    }
}
