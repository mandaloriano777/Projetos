

/*Efetuar a leitura de uma temperatura medida em graus Celsius e apresentá-la convertida em graus Fahrenheit.
A fórmula para conversão das temperaturas é F = (9 * C + 160) / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.
Se F for maior que 45 e menor que 90, então escrever a seguinte mensagem: “Temperatura ideal para o experimento.”
Caso contrário, apresentar a seguinte mensagem: “Temperatura inapropriada para o experimento”.*/

programa
{
	
	funcao inicio()
	{
		real grauC, grauF
		caracter resp = 's'
		
		enquanto(resp == 'S' ou resp == 's'){
			
		limpa()

		escreva("*** Em busca de novas aventuras, não? *** \n")
		escreva("\nEsse progama vai te ajudar a realizar a coversão de temperatura para você ter a melhor exeperiência possivel!\n\n ")

		escreva("Informe a temperatura em Graus celsiu:")
		leia(grauC)

		grauF = (9 * grauC + 160) / 5

		se(grauF > 45 e grauF < 90){
			escreva("\n\nA temperatura " + grauF + " é ideal para experiência! ")
			escreva("\n\n< 45ºF e > 90ºF")
		}
		senao{
			escreva("\nA temperatura " + grauF + " é inapropriada para o experimento!\n")
			escreva("\nEla é menor que 45ºF e maior que 90ºF")
		}
		escreva("\n\nDeseja continuar (S / N): ")
		leia(resp)

		}	
		
		

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1231; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */