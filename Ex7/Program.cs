using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;


            Console.WriteLine("Digte sua idade: ");
            idade = int.Parse(Console.ReadLine());


            if (idade >= 5 && idade <= 7 )
            {
                Console.WriteLine("Categoria Infantil");
            }

            else if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Categoria juvenil");
            }

            else if (idade >= 11 && idade <= 15)
            {
                Console.WriteLine("Categoria adolescente");
            }

            else if (idade >= 16 && idade <= 30)
            {
                Console.WriteLine("Categoria Adulto");
            }

            else if (idade > 30)
            {
                Console.WriteLine("Sênior");
            }

            else
            {
                Console.WriteLine("Não está apto");
            }


            Console.ReadKey();
        }
    }
}
