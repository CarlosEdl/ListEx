using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado x do triângulo: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado y do triângulo: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado z do triângulo: ");
            double z = double.Parse(Console.ReadLine());

            if (x < y + z && y < x + z && z < x + y)
            {
                if (x == y && y == z)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (x == y || y == z || x == z)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os lados não correspondem a um triângulo válido.");
            }
        }
    }
}