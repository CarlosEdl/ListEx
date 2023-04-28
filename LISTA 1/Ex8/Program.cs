using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            float altura;

            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digte sua altura: ");
            altura = float.Parse(Console.ReadLine());


            if (idade >= 6 && idade <= 10 && altura >= 1.00)
            {
                Console.WriteLine("Categoria Infantil");
            }

            else if (idade >= 11 && idade <= 17 && altura >= 1.40)
            {
                Console.WriteLine("Categoria Júnior");
            }

            else if (idade >= 18 && idade <= 35 && altura >= 1.70)
            {
                Console.WriteLine("Categoria Profissional");
            }

            else if (idade > 35 && altura >= 1.60)
            {
                Console.WriteLine("Categoria Sênior");
            }

            else
            {
                Console.WriteLine("Não apto");
            }

            Console.ReadKey();
        }
    }
}
