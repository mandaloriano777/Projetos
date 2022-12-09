using System;

namespace Projeto_Palavra_Aleatória
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            String palavra;

            int H, V;


            Console.Write("Qual a palavra desejada: ");
            palavra = Console.ReadLine();

            Console.Clear();

            do
            {
                Random horizontal = new Random(), vertical = new Random(), cor = new Random();

                H = horizontal.Next(0, 79); V = vertical.Next(0, 24);

                Console.ForegroundColor = (ConsoleColor)cor.Next(1, 16);

                Console.SetCursorPosition(H, V);

                Console.Write(palavra);

                System.Threading.Thread.Sleep(300);

            } while (true);
        }
    }
}

