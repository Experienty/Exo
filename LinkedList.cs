/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Link
{
    public class Linked
    {         
        static void Main()
        {
        	LinkedList<string> transpor = new LinkedList<string>();
        	
        	transpor.AddFirst("Carro");
        	transpor.AddFirst("Avião");
        	transpor.AddFirst("Navio");
        	transpor.AddFirst("Moto");
        	
        	transpor.AddLast("Bicicleta");
        	
        	LinkedListNode<string>no;
        	no = transpor.FindLast("Navio");// no fim da lista
        	transpor.AddAfter(no,"Patinete");// apos a lista
        	no = transpor.FindLast("Navio");// no fim da lista
        	transpor.AddBefore(no,"Patins");// no inicio da lista
        	 
        	//transpor.Clear();
        	//transpor.Remove("Carro");
        	
        	if(transpor.Find("Carro") == null){
        		Console.WriteLine("Não Encontrado\n");
        	}else{
        		Console.WriteLine("Elemento Encontrado\n");
        	}
        	
        	//transpor.Remove("Navio");
        	
        	foreach(string t in transpor){
        		Console.WriteLine("Transporte: {0}",t);
        	}
        }
    }
}*/