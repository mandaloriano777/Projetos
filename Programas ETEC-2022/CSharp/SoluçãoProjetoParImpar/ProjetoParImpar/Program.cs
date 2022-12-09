using System;

namespace ProjetoParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Informe o número");
            a = int.Parse(Console.ReadLine());

            b = a%2;

            if(b > 0)
            {
                Console.Write("\n"+ a + " É um número Impar");
            }

            else
            {
                Console.Write("\n"+ a + " É um número Par");
            }
        }
    }
}
