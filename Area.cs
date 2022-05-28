/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Quadrado
{
    public class Area
    {         
        static void Main()
        {
        	/*int x = 4;
        	double y = 3.3;
        	//const double frequencia = 60;
        	
        	double area = x * y;
        	
        	Console.WriteLine("A Multiplicação de X & Y é: {0}\n", area);
        	//Exemplo de Converção de variaveis
        	Console.WriteLine("Qual o numero da sua casa:");
        	string casa = Console.ReadLine();
        	int numero = int.Parse(casa);
        	Console.WriteLine("O numero da casa é: {0}",numero);
        	numero = Convert.ToInt32(numero);
        	Console.WriteLine(numero);*/
        	
        	/*//Exemplos de Formatos de Saida
        	double x = 20.141556;
        	Console.WriteLine(x.ToString("F4"));
        	Console.WriteLine(x.ToString("C"));
        	Console.WriteLine(x.ToString("P"));
        	//Console.WriteLine(x.ToString("P"));*/
        	
        	/*//Exemplos de Operadores Relacionais
        	Console.WriteLine("digite sua nota: ");
        	double.TryParse(Console.ReadLine(), out double nota);
        	
        	Console.WriteLine("A nota é maior que 7: {0}",nota > 7.0);
        	Console.WriteLine("Tirou 10: {0}", nota == 10.0);*/
        	
        	/*//Exemplos de Operadores Logicos
        	var atividade1 = true;
        	var atividade2 = false;
        	
        	var todas = atividade1 && atividade2;
        	
        	Console.WriteLine("Fez todas as atividade: {0}\n", todas);
        	
        	var justOne = atividade1 ||atividade2;
        	
        	if(atividade1 || atividade2){
        		Console.WriteLine("Fez pelo menos uma das atividades: {0}", justOne);
        	}else{
        	    Console.WriteLine("Não Fez Nenhuma das atividades: {0}", justOne);
        	}*/
        	
        	/*//Exemplo de Operador Unario
        	var x = false;
        	var n1 = 6;
        	var n2 = 5;
        	var n3 = 7;
        	var n4 = 9;
        	Console.WriteLine(!x);
        	n3++;
        	Console.WriteLine(n3);
        	n4++;
        	Console.WriteLine(n4);
        	
        	Console.WriteLine(n2 == --n1);
        	Console.WriteLine(n2-- == ++n1);*/
        	
        	/*Console.WriteLine("Qual é a nota que você daria pelo prato: 0,5 ou 10");
        	int.TryParse(Console.ReadLine(), out int nota);
        	
        	switch(nota)
        	{
        		case 0:
        		   Console.WriteLine("Comida muito Ruim!");
        		   break;
        		case 5: 
        		   Console.WriteLine("Comida Razoavel");
        		   break;
        		case 10: 
        		   Console.WriteLine("Comida muito Boa!");
        		   break;
        		default:
        		   Console.WriteLine("Comida Inexistente!");
        		   break;
             }*/
             //Exemplo da condição "while" abaixo
        	 /*var x1 = 1;
        	 while(x1 <= 15){
        	 	Console.WriteLine(x1);
        	    x1++;
        	}*/ 
        	//Exemple do loop "for" abaixo
        	/*for(int x1 = 0; x1 < 100; x1++){
        		Console.WriteLine(x1);
        	}*/
        	/*Console.WriteLine("irei auxiliar você a calcular a media do seu aluno\n");
        	Console.Write("digite a primeira nota: ");
        	int.TryParse(Console.ReadLine(), out int nota1);
        	Console.WriteLine("\n");
        	Console.Write("digite a segunda nota: ");
        	int.TryParse(Console.ReadLine(), out int nota2);
        	Console.WriteLine("\n");
        	Console.Write("digite a terceira nota: ");
        	int.TryParse(Console.ReadLine(), out int nota3);
        	Console.WriteLine("\n");
        	
        	var media = (nota1 + nota2 + nota3)/3;
        	
        	Console.WriteLine("A media do seu aluno é: {0}",media);
        	Console.WriteLine("\n");
        	if(media >= 7){
        		Console.WriteLine("Status do Aluno: Aprovado");
        	}else if(media == 5 || media == 6){
        		Console.WriteLine("Status do Aluno: Recuperação");
        	}else{
        		Console.WriteLine("Status do Aluno: Reprovado");
        	}*
        	
        	bool opção = true;
        	Console.WriteLine("irea realizar a soma dos numeros que voce desejar ate você desejar parar\n");
        	Console.Write("digite o valor inicial: ");
        	float.TryParse(Console.ReadLine(), out float inicio);
        	Console.WriteLine("\n");
        	while(opção == true){
        		Console.Write("digite o numero que desejar somar ao valor inicial: ");
        		float.TryParse(Console.ReadLine(), out float x1);
        		Console.WriteLine("\n");
        		inicio += x1;
        		Console.WriteLine("a soma ate o momento ê: {0}",inicio);
        		Console.WriteLine("\n");
        		Console.Write("desejar sair do programa 1 - yes or 2 - no: ");
        		int.TryParse(Console.ReadLine(), out int sair);
        		Console.WriteLine("\n");
        		switch(sair)
        		{
        			case 1:
        			  Console.WriteLine("Saindo do Programa.");
        			  Console.WriteLine("\n");
        			  opção = false;
        			  break;
        			case 2:
        			  Console.WriteLine("Continuir a Soma.");
        			  Console.WriteLine("\n");
        			  break;
        			default:
        			  Console.WriteLine("Opção Invalida, Retornando Para o Soma");
        			  Console.WriteLine("\n");
        			  break;
        		}
        	}
        }
    }
}*/