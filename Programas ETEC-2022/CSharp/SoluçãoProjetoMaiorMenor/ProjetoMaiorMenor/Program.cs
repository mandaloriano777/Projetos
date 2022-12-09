using System;

namespace ProjetoMaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Informe o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            if (a > b && b < a)
            {
                Console.Clear();
                Console.Write("O número " + a + " é maior que o número " + b);
                Console.Write("\n\nE número " + b + " é menor que o número " + a);
            }

            else if(b > a && a < b)
            {
                Console.Clear();
                Console.Write("O número " + b + " é maior que o número " + a);
                Console.Write("\n\nE número " + a + " é menor que o número " + b);
            }

            else
            {
                Console.Clear();
                Console.Write("Esses números são iguais");
            }

        }
    }
}
