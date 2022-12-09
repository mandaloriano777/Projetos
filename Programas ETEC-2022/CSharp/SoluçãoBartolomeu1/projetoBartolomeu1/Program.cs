using System;

namespace projetoBartolomeu1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            string vResp; // no portugol é cadeia

            double a, b, soma, sub, mult, div, num, expoente, pot;
           

            Console.ForegroundColor = ConsoleColor.Yellow; //cor das letras
            Console.BackgroundColor = ConsoleColor.Black;  //cor do fundo da console

            do  //faça
            {
                Console.Clear(); //Limpa tela
               // Console.SetCursorPosition(30,0);
                Console.WriteLine("Boa Tarde..!");
                //Console.SetCursorPosition(25, 5);
                Console.WriteLine("\nVamos calcular operações?");
                vResp = Console.ReadLine(); // leia (vResp)

                if (vResp == "sim" || vResp == "Sim" || vResp == "SIM" || vResp == "s") // se(vResp == "sim")
                {

                    //entrada
                    //Console.SetCursorPosition(25, 7);

                    Console.Write("\nInforme o primeiro número das operações: ");  //escreve com quebra de linha
                    a = double.Parse(Console.ReadLine()); //leia (a)
                    //Console.SetCursorPosition(25, 7);

                    Console.Write("\nDigite o segundo número das operções: ");  //escreve sem quebra de linha 
                    b = double.Parse(Console.ReadLine()); //leia (b)

                    Console.Write("\nInforme a base da potência: ");
                    num = double.Parse(Console.ReadLine());  //leia a base da potência

                    Console.Write("\nInforme o expoente da potência: ");
                    expoente = double.Parse(Console.ReadLine()); //leia o expoente da potência


                    //Processamento
                    soma = a + b;
                    sub = a - b;
                    mult= a * b;
                    div = a / b;

                    pot = Math.Pow(num, expoente);
                    
                    

                    //saidas 
                    // Console.SetCursorPosition(25, 12);
                    Console.WriteLine("\n\nA soma é " , soma);
                    Console.WriteLine($"\n{a} + {b} = {soma}");

                    Console.WriteLine("\n\nA subtração é " , sub);
                    Console.WriteLine($"\n{a} - {b} = {sub}");

                    Console.WriteLine("\n\nA multiplicação é " , mult);
                    Console.WriteLine($"\n{a} X {b} = {mult}");

                    Console.WriteLine("\n\nA divisão é " , div);
                    Console.WriteLine($"\n{a} / {b} = {div}");

                    Console.WriteLine("\n\nA potência é ", pot);
                    Console.WriteLine($"\n{pot}");


                    //Console.SetCursorPosition(25, 15);

                }

                else // senao 
                {
                   // Console.SetCursorPosition(25, 15);
                    Console.WriteLine("\nOK! Obrigado até a próxima");
                }

               // Console.SetCursorPosition(25, 18);
                Console.WriteLine("\n\nDeseja Continuar?");
                vResp = Console.ReadLine();
            } while (vResp == "sim" || vResp == "s"); //enquanto
        }
    }
}
