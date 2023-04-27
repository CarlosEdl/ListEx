using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float notaTrabalho, notaAvaliacao, notaExame, media;

            Console.WriteLine("Digite a nota do trabalho de laboratório: ");
            notaTrabalho = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação semestral: ");
            notaAvaliacao = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do exame final: ");
            notaExame = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso do trabalho de laboratório : ");
            float pesoTrabalho = float.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Digite o peso da avaliação semestral : ");
            float pesoAvaliacao = float.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Digite o peso do exame final : ");
            float pesoExame = float.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Digite a média necessária para aprovação: ");
            float mediaAprovacao = float.Parse(Console.ReadLine());

            media = notaTrabalho * pesoTrabalho + notaAvaliacao * pesoAvaliacao + notaExame * pesoExame;

            Console.WriteLine("Média final: " + media.ToString("F2"));

            if (media >= mediaAprovacao)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media >= 4)
            {
                Console.WriteLine("Exame especial");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.ReadKey();
        }
    }
}