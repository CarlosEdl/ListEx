using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o coeficiente a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o coeficiente b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o coeficiente c:");
            double c = double.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("A equação possui uma raiz real: " + raiz);
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("A equação possui duas raízes reais:");
                Console.WriteLine("Raiz 1: " + raiz1);
                Console.WriteLine("Raiz 2: " + raiz2);
            }

            Console.ReadKey();
        }
    }
}
