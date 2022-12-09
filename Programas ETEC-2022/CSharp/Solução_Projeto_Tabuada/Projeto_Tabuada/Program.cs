using System;

namespace Projeto_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int resultado, i, n;

            Console.Write("=== Vamos aprender a tabuada ===");
            Console.Write("Digite o Número desejado para realização da Taboada:");
            n = int.Parse(Console.ReadLine());

            
            for (i = 1; i <= 10; i++)
            {
                resultado = n * i;
                Console.WriteLine(n + " X " + i + " = " + resultado);

            }

        }
    }
}
