/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Lanche
{
    public class Refeição 
    {         
        static void Main()
        {
        	double preco;
        	string Eat;
        	inicio: 
        	
        	Console.Write("Escolha uma das Opções da Tabela: [1] [2] [3] [4] [5] ");
        	int.TryParse(Console.ReadLine(), out int id);
        	Console.WriteLine($"Pedido: {id}");
        	Console.Write("Escolha a quantidade: ");
        	int.TryParse(Console.ReadLine(), out int q);
        	Console.WriteLine();
        	if(id == 1){
        		preco = 4.00;
        		Eat = "Batatinha";
        	}else if(id == 2){
        		preco = 4.50;
        		Eat = "Refrigerante";
        	}else if(id == 3){
        		preco = 4.00;
        		Eat = "Pastel";
        	}else if(id == 4){
        		preco = 2.00;
        		Eat = "Coxinha";
        	}else if(id == 5){
        		preco = 1.00;
        		Eat = "Agua";
        	}else{
        		Console.Clear();
        	    Console.WriteLine("Option Nonexistenty");
        	    Console.ReadKey();
        	    Console.Clear();
        	    goto inicio;
        	}
        	Console.Clear();
        	Console.WriteLine($"Tipo do Lanche: {Eat}");
        	Console.WriteLine();
        	Console.WriteLine($"Quantidade: {q}");
        	Console.WriteLine();
        	Console.WriteLine($"Total {preco*q:c}");
        	Console.WriteLine();
        	Console.Write("Deseja Continuar Com a Comprar y or no: ");
        	char.TryParse(Console.ReadLine(), out char Escolha);
        	Console.WriteLine();
        	
        	switch(Escolha){
        		case 'y':
        		 Console.Clear();
        		 goto inicio;
        		 break;
        		default:
        		 Console.Clear();
        		 Console.WriteLine("Obg pela sua compra");
        		 break;
        	}
        }
    }
}*/