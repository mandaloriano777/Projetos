using System;

namespace Projeto_Analisa_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Analisa números ETEC - Fernando Prestes";

            double numqtd, soma = 0, media, maior = 0, menor = 0;

            int par = 0, impar = 0, cont, posMaior = 0, posMenor = 0;

            double[] armnum = new double[10];

            Console.Clear();

            do
            {

                Console.Write("Informe a quantia de números desejada:");
                numqtd = double.Parse(Console.ReadLine());

                for (cont = 0; cont < numqtd; cont++)
                {
                    Console.Write($"\nInforme o {cont + 1}° número: ");
                    armnum[cont] = double.Parse(Console.ReadLine());



                }




                for (cont = 0; cont < numqtd; cont++)
                {
                    if (armnum[cont] % 2 == 0)
                    {
                        par++;
                    }

                    else
                    {
                        impar++;
                    }

                    soma = soma + armnum[cont];

                    if (cont == 0)
                    {
                        maior = armnum[cont];
                        posMaior = cont + 1;

                    }

                    else if (maior < armnum[cont])
                    {
                        maior = armnum[cont];
                        posMaior = cont + 1;
                    }

                    if (cont == 0)
                    {
                        menor = armnum[cont];
                        posMenor = cont + 1;

                    }

                    else if (armnum[cont] < menor)
                    {
                        menor = armnum[cont];
                        posMenor = cont + 1;
                    }


                }

                media = soma / numqtd;

                for (cont = 0; cont < numqtd; cont++)
                {
                    Console.Write("\nNúmero na " +(cont + 1) + "ª posição : " + armnum[cont]);
                }

                Console.Write($"\n\nOs números pares informados foram {par}");
                Console.Write($"\n\nOs números impares informados foram {impar}");
                Console.Write($"\n\nA soma dos números informados é {soma}");
                Console.Write($"\n\nA média dos números informados é {media}");
                Console.Write($"\n\nO maior dos números informados é {maior} na posição {posMaior}");
                Console.Write($"\n\nO menor dos números informados é {menor} na posição {posMenor}");

            } while (false);

        }
    }
}
