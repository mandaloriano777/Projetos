using System;

namespace Projeto_Dia_Mes
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();

                Console.Write("MENU DE VETORES\n");
                Console.Write("\n[1] Consulta Dia - Mês");
                Console.Write("\n[2] Consulta Siglas e Estados");
                Console.Write("\n[3] Extenso 0 --- 1000");
                Console.Write("\n[4] Finalizar");

                Console.Write("\n\nEscolha a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            menu();
                            break;
                        }

                        case 2:
                        {
                            matrix();
                            break;
                        }

                        case 3:
                        {
                            extenso();
                            break;
                        }

                        // case 4:
                        {

                        }

                }
            } while (opcao <= 3);

        }

        static void menu()
        {
            int opcao;
            do {

                Console.Clear();


                Console.Write("\n=====\n");
                Console.Write("MENU");
                Console.Write("\n=====\n\n");
                Console.Write("[1] Dia da semana\n");
                Console.Write("[2] Mês do ano");


                Console.Write("\n\nQual a opção dsejada: ");

                opcao = int.Parse(Console.ReadLine());


                switch (opcao)

                {
                    case 1:
                        {
                            Vetor();

                            break;

                        }
                    case 2:
                        {
                            Mes_Do_Ano();

                            break;

                        }

                }

            }
            while (opcao <=2);
        }

        static void Vetor()
        {

            string[] dia = { " ", "Domingo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" };
            string resp;
            int n;


            do {

                Console.Clear();


                Console.Write("Me informe um número e eu digo qual o dia da semana correspondente!");
                Console.Write("\n===================================================================\n\n");


                Console.Write("Digite um número: ");

                n = int.Parse(Console.ReadLine());


                if (n<1  ||  n>7)
                {
                    Console.Write("\n\nDia inválido\n\n");

                }
                else
                {
                    Console.Write("\n\n" + n + " corresponde a " + dia[n] + "\n\n");

                }

                Console.Write("Deseja continuar a trasformar os números em dias? Sim ou não: ");
                resp = (Console.ReadLine());



            } while (resp == "Sim" || resp == "sim");

        }

        static void Mes_Do_Ano()
        {

            string[] mes = { "", "Janeiro", "Fevereiro", "março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string resp;

            int n;


            do {

                Console.Clear();


                Console.Write("Me informe um número e eu digo qual o mês do ano correspondente!");

                Console.Write("\n================================================================\n\n");

                Console.Write("Informe o número desejado para conversão: ");

                n = int.Parse(Console.ReadLine());


                if (n<1 || n>12)
                {
                    Console.Write("O número informado é XX invalido XX");

                }
                else
                {
                    Console.Write("\n\n" + n + " corresponde a " + mes[n] + "\n\n");

                }

                Console.Write("Deseja continuar realizando a conversão? Sim ou não: ");

                resp = (Console.ReadLine());


            } while (resp == "Sim" || resp == "sim");

        }

        static void matrix()
        {

            int i, opcao;
            bool achou;
            string[,] estado = new string[27, 2];
            string sig, est, resp;

            estado[0, 0]="SP"; estado[0, 1]="Sao Paulo";
            estado[1, 0]="RJ"; estado[1, 1]="Rio de Janeiro";
            estado[2, 0]="MG"; estado[2, 1]="Minas Gerais";
            estado[3, 0]="PE"; estado[3, 1]="Pernambuco";
            estado[4, 0]="ES"; estado[4, 1]="Espirito Santo";
            estado[5, 0]="AC"; estado[5, 1]="Acre";
            estado[6, 0]="AL"; estado[6, 1]="Alagoas";
            estado[7, 0]="AP"; estado[7, 1]="Amapa";
            estado[8, 0]="AM"; estado[8, 1]="Amazonas";
            estado[9, 0]="BA"; estado[9, 1]="Bahia";
            estado[10, 0]="CE"; estado[10, 1]="Ceara";
            estado[11, 0]="DF"; estado[11, 1]="Distrito Federal";
            estado[12, 0]="GO"; estado[12, 1]="Goias";
            estado[13, 0]="MA"; estado[13, 1]="Maranhao";
            estado[14, 0]="MT"; estado[14, 1]="Mato Grosso";
            estado[15, 0]="MS"; estado[15, 1]="Mato Grosso do Sul";
            estado[16, 0]="PA"; estado[16, 1]="Para";
            estado[17, 0]="PB"; estado[17, 1]="Paraiba";
            estado[18, 0]="PR"; estado[18, 1]="Parana";
            estado[19, 0]="PI"; estado[19, 1]="Piaui";
            estado[20, 0]="RN"; estado[20, 1]="Rio Grande do Norte";
            estado[21, 0]="RS"; estado[21, 1]="Rio Grande do Sul";
            estado[22, 0]="RO"; estado[22, 1]="Rondonia";
            estado[23, 0]="RR"; estado[23, 1]="Roraima";
            estado[24, 0]="SC"; estado[24, 1]="Santa Catarina";
            estado[25, 0]="TO"; estado[25, 1]="Tocantins";
            estado[26, 0]="SE"; estado[26, 1]="Sergipe";

            do
            {

                Console.Clear();

                Console.Write("[1] Siglas [2] Estado");


                Console.Write("\n\nEscolha uma opcão: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();


                if (opcao==1)
                {

                    Console.Write("Informe a sigla do Estado desejado: ");
                    sig = (Console.ReadLine());

                    achou = false;
                    for (i=0; i<27; i++)
                    {
                        if ((sig) == estado[i, 0])
                        {
                            Console.Write("\n" + sig + " corrresponde ao Estado " + estado[i, 1]);

                            achou = true;
                            break;

                        }
                    }
                    if (achou == false)
                    {
                        Console.Write("\nSigla não cadastrada");

                    }

                }

                else if (opcao == 2)
                {
                    Console.Write("Exemplo: Amazonas = AM, não esqueça da letra maiuscula no inicio. ");


                    Console.Write("\n\nInforme o Estado da sigla desejada: ");
                    est = (Console.ReadLine());

                    achou = false;
                    for (i=0; i<27; i++)
                    {
                        if (est == estado[i, 1])

                        {
                            Console.Write("\n" + est + " corresponde a sigla " + estado[i, 0]);

                            achou = true;
                            break;

                        }
                    }
                    if (achou == false)

                    {
                        Console.Write("\nEstado não cadastrado");

                    }

                }
                Console.Write("\n\nDeseja continuar a pesquisar Estados e Siglas? Sim ou Não: ");

                resp = (Console.ReadLine());


            } while(resp == "Sim" || resp == "sim");
        }

        static void extenso()
        {
            string[] unidade = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezeseis ", "dezesete", "dezoito", "dezenove" };
            string[] dezena = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centena = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            int n, ne, nd, nc;
            string resp;

            Console.Clear();

            do
            {

                Console.Clear();


                Console.Write("\nQualquer valor informado em forma de número ente [ 0 - 1000 ], será devolvido na forma extensa!\n\n");

                Console.Write("Informe um número: ");

                n = int.Parse(Console.ReadLine());


                if (n< 0 || n> 1000)

                {
                    Console.Write("\nNúmero fora da faixa \n\n");

                }

                else if (n<20)
                {
                    Console.Write("\nEsse número corresponde a " + unidade[n] + "\n\n");

                }

                else if (n<100)
                {
                    ne = n/10;

                    nd = n%10;


                    Console.Write("\nEsse número corresponde a " + dezena[ne]);

            if (nd > 0)

                    {
                        Console.Write(" e " + unidade[nd] + "\n\n");

                    }
                }
                else if (n ==100)
                {
                    Console.Write("\nEsse número corresponde a cem\n\n");

                 }

                else if (n< 1000)
                {
                    nc = n/100;


                    if (n%100 <20) {

                        nd = (n%100);

                        Console.Write("\nEsse número corresponde a " + centena[nc] + " e " + unidade[nd] + "\n\n");


                    }
                    else {

                        ne = (n%100)/10;

                        nd = (n%100)%10;


                        Console.Write("\nEsse número corresponde a " + centena[nc]);

                        if (ne > 0) {
                            Console.Write(" e " + dezena[ne]);


                        }
                        if (nd > 0) {

                            Console.Write(" e " + unidade[nd] + "\n\n");

                        }
                    }

                }

                else if (n == 1000)
                {
                    Console.Write("\nEsse número corresponde a mil \n\n");

                }

                Console.Write("\nDeseja continuar consultando números? Sim ou Não: ");
                resp = (Console.ReadLine());

            } while (resp == "Sim" || resp == "sim");

        }
            
    }
}
