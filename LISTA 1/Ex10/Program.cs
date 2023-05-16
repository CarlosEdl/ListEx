using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, aumento, novoSalario;

            Console.WriteLine("Digite o seu salário");
            salarioAtual = float.Parse(Console.ReadLine());

            if (salarioAtual < 700) {
                aumento = salarioAtual * 0.3;
                novoSalario = salarioAtual + aumento;
                Console.WriteLine("Seu novo salário é R$ " + novoSalario);
  
            }else{
                aumento = salarioAtual * 0.1;
                novoSalario = salarioAtual + aumento;
                Console.WriteLine("Seu novo salário é R$ " + novoSalario);

                
            }

            Console.ReadKey();

        }
    }
}
