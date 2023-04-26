using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Calculo da média semestral:");
            Console.Write("Digite a nota da primeira avaliação:");
            a = float.Parse(Console.ReadLine());

            b = (5 * 3 - a) / 2;

            Console.WriteLine($"O aluno precisar tirar ao menos {b} em sua segunda avaliação para ser aprovado");

        }
    }
}
