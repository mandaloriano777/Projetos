programa
{
	
	funcao inicio()
	{

		inteiro ladoa,ladob,ladoc


		faca {
			
			escreva("Analisa Triângulo\n")
			escreva("******************")
	
			escreva("\nInforme o valor do primeiro lado do triangulo :")
			leia(ladoa)
	
			escreva("\nInforme o valor do segundo lado do triangulo :")
			leia(ladob)
			
			escreva("\nInforme o valor do terceiro lado do triangulo :")
			leia(ladoc)
	
			se (ladoa >= ladob + ladoc){
	
				escreva("\nOs lados informados não formam um triangulo !!!")
				pare
			}
		}				
		enquanto	(ladoa >= ladob + ladoc)
			 
		se ((ladoa*ladoa) == (ladob*ladob + ladoc*ladoc)){

			escreva("\nTriangulo Retangulo \n")			
		

		}senao se ((ladoa*ladoa) >= (ladob*ladob + ladoc*ladoc)){

			escreva("\nTriangulo Obtusangulo \n")			
		

		}senao se ((ladoa*ladoa) <= (ladob*ladob + ladoc*ladoc)){

			escreva("\nTriangulo Acutangulo \n")			
		}

	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 560; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */