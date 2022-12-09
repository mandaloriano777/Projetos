programa
{
	inclua biblioteca Matematica-->mat
	
	
	funcao inicio()
	{
	// Nome: Felipe Ferreira de Souza
	// Discplina: TPA 
	// Professores: Anderson/Neusa
	// Atividade de cálculos
	
	
	//Declaração das variavéis.
	real x, y

		//Introdução do programa.
		escreva(" *** Vou falar para você o resultado de dois algarismos,efetuando as 4 operações básicas *** ")

		//Nessa lacuna o usuário deve digitar o 1° valor desejado. 	
		escreva("\n\nInforme o 1° número: ")
		leia(x)

		//Nessa lacuna o usúario deve digitar o 2° valor desejado.
		escreva("\nInforme o 2° número: ")
		leia(y)

		//Comando para limpar a tela.
		limpa()

		//Mensagem destinada ao usúario
		escreva("Ótima escolha,segue abaixo os resultados dos cálculos ")

		//Realiza a soma dos dois números escolhidos.
		escreva("\n\nA soma de " + x + " + " + y + " é          : " )
		escreva( x + y,"\n")

		//Realiza a subtração dos dois números escolhidos.
		escreva("\nA subtração de " + x + " - " + y + " é     : " )
		escreva( x - y,"\n")

 		//Realiza a multiplicação dos dois números escolhidos.
		escreva("\nA multiplicação de " + x + " * " + y + " é : " )
		escreva( x * y,"\n")

		//Realiza a divisão dos dois números escolhidos.
		escreva("\nA divisão de " + x + " / " + y + " é       : " )
		escreva( mat.arredondar(x / y, 2),"\n")
		


		

		






		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 728; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */