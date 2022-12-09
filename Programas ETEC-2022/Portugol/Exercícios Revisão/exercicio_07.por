programa
{
	inclua biblioteca Matematica --> mat
	
	
	funcao inicio()
	{
				
		

		real nota1, nota2, nota3, mediaexr, medpond
		
		escreva(" Cáculo de Média Ponderada  \n")
		escreva(" **************************  \n")

		escreva("\nInforme o valor da primeira nota : ")
		leia(nota1)

		escreva("Informe o valor da segunda nota : ")
		leia(nota2)

		escreva("Informe o valor da terceira nota : ")
		leia(nota3)

		escreva("Informe o valor da média dos exercícios : ")
		leia(mediaexr)

		limpa()

	
		medpond = ((nota1 + nota2)*2 + (nota3)*3 + mediaexr) / 7

	
		escreva("\nAs Notas digitadas foram : \n\n Nota 1 = "+nota1+"\n Nota 2 = "+nota2+"\n Nota 3 = "+nota3+"\n média dos exercícios = "+mediaexr)

		escreva("\n\nA média de aproveitamento segue a baixo")

	
		escreva("\nA média de aproveitamento é: " +mat.arredondar(medpond, 2)+"\n")

		
		se (medpond >= 9)
		{
			escreva("\nConceito A \n")
		}

		senao se( medpond >= 7.5 e medpond < 9)
		{
			escreva("\nConceito B \n")
		}

		senao se( medpond >= 6 e medpond < 7.5)
		{
			escreva("\nConceito C \n")
		}

		senao
		{
			escreva("\nConceito D \n")
		}
			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 807; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */