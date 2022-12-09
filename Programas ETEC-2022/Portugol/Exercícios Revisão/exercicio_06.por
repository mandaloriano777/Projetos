programa
{
	inclua biblioteca Util --> U
	
	funcao inicio()
	{
		inteiro cont = 10

		escreva("\nVou de 10 a 1.\n\n")

		para(cont = 10; cont >=1; cont--)
		{
			se(cont != 1)
			{
				escreva(cont + ",")
			}
			U.aguarde(500)
			
			se(cont == 1)
			{
				escreva(cont + ".")
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 273; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */