using System;

namespace Projeto_Sorteio_De_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int palpite;
            int numero;
            int lim_inf;
            int lim_sup;

            Console.Clear();

            Console.Write("Vamos ver como andas sua estimativa? ");

            Console.Write("\n\nlimite inferior: ");
            lim_inf = int.Parse(Console.ReadLine());

            Console.Write("limite superior: ");
            lim_sup = int.Parse(Console.ReadLine());

            Random sn = new Random();
            numero = sn.Next(lim_inf, lim_sup);

            Console.WriteLine("\nO número gerado foi " + numero);

            do
            {
                Console.Write("\n\nAdvinhe o número no intervalo de (" + lim_inf + ";" + lim_sup + "): ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite == numero)
                {
                    Console.WriteLine("\nVocê acertou!!");
                }


                else if (palpite > numero)
                {
                    Console.WriteLine("\nO número informado foi maior que o número secreto");
                }


                else if (palpite < numero)
                {
                    Console.WriteLine("\nO número informado foi menor que o número secreto");
                }

            } while (palpite != numero);
        }
    }
}


