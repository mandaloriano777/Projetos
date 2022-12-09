programa
{
	
	funcao inicio()
	{
		inteiro num1, num2

		escreva("Te ajudarei a fazer uma divisão, se o segundo valor for diferente de zero")

		escreva("Digite o primeiro valor: ")
		leia(num1)

		escreva("\nDigite o segundo valor: ")
		leia(num2)

		se(num2 == 0)
		{
			escreva("\nO segundo valor inserido é 0, ou seja, mude ele e tente novamente. ")
		}

		senao se(num2 != 0 )
		{
			escreva("\n" + num1 + " / " + num2 + " = " + num1/num2)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 141; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */