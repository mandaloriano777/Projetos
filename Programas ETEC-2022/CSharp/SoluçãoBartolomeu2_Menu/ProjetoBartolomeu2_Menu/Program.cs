using System;

namespace ProjetoBartolomeu2_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {

                //Console.ForegroundColor

                //Mostrar as lista de opções
                Console.SetCursorPosition(50, 0);
                Console.WriteLine("***** Menu Principal *****");
                Console.SetCursorPosition(0, 1);
                Console.WriteLine(new string('=', 120));

                Console.SetCursorPosition(5, 3);
                Console.Write("[1] calculos");

                Console.SetCursorPosition(5, 5);
                Console.Write("[2] Opção 2");

                Console.SetCursorPosition(5, 7);
                Console.Write("[3] Opção 3");

                Console.SetCursorPosition(5, 9);
                Console.Write("[4] FIM");

                Console.SetCursorPosition(0, 11);
                Console.WriteLine(new string('=', 120));

                //receber a escolha 
                Console.Write("\nInforme a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                //Decidir oque fazer perante a escolha

                switch (opcao)
                {
                    case 1:
                        {
                            Calculos();
                            break;
                        }

                    case 2:
                        {
                            Comparacao();
                            break;
                        }

                    case 3:
                        {
                            Par_e_Impar();
                            break;
                        }
     
                    case 4:
                        {
                           
                            break;
                        }

                    /*default:
                        Console.SetCursorPosition(50, 20);
                        Console.Write("[ Opção Invalida ]");
                        Console.ReadKey(); //pausa*/
                }

            } while (opcao <= 4);

        } //fecha o Main()

        static void Calculos()
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
                    Console.WriteLine("\n\nA soma é ", soma);
                    Console.WriteLine($"\n{a} + {b} = {soma}");

                    Console.WriteLine("\n\nA subtração é ", sub);
                    Console.WriteLine($"\n{a} - {b} = {sub}");

                    Console.WriteLine("\n\nA multiplicação é ", mult);
                    Console.WriteLine($"\n{a} X {b} = {mult}");

                    Console.WriteLine("\n\nA divisão é ", div);
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

        static void Comparacao()
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

            else if (b > a && a < b)
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

        static void Par_e_Impar()
        {
            int a, b;

            Console.Write("Informe o número");
            a = int.Parse(Console.ReadLine());

            b = a%2;

            if (b > 0)
            {
                Console.Write("\n"+ a + " É um número Impar");
            }

            else
            {
                Console.Write("\n"+ a + " É um número Par");
            }
        }

    }//fecha a class programa

}//fecha o Namespace
