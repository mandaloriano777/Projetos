programa
{
	inclua biblioteca Util --> U
	
	funcao inicio()
	{
		inteiro cont = 1

		escreva("\nConto de 1 a 10.\n\n")

		faca{

		se ( cont != 10 )
		{
			escreva( cont + "," )
		}
		cont++
		U.aguarde(500)

		se ( cont ==10)
		{
			escreva(cont + ".")
		}
		
	 	}enquanto( cont <=10)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 181; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */