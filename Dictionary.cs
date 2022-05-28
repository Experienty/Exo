/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Dicty
{
    class Dictionay
    {         
       static void Main()
       {
       	 Dictionary <int,string> veiculos = new Dictionary <int,string>();
       	 
       	 veiculos.Add(10,"Carro");
       	 veiculos.Add(20,"Avião");
       	 veiculos.Add(0,"Navio");
       	 veiculos.Add(5,"Moto");
       	 veiculos.Add(15,"Patinete");
       	 //veiculos.Remove(20);
       	 //veiculos.Add(20,"Avião");
       	 Console.WriteLine("O tamanho do Dictionary: {0}",veiculos.Count);
       	 Console.WriteLine("\n");
       	 int chave = 20;
       	 if(veiculos.ContainsKey(chave)){
       	 	Console.WriteLine("A chave {0} esta na coleção", chave);
       	 }else{
       	 	Console.WriteLine("A chave {0} Não esta na Coleção", chave);
       	 }
       	 Console.WriteLine("\n");
       	 
       	 veiculos[15] = "Bicicleta";
       	 
       	 string valor = "Bicicleta";
       	 
       	 if(veiculos.ContainsValue(valor)){
       	 	Console.WriteLine("A chave {0} esta na Coleção",valor);
       	 }else{
       	 	Console.WriteLine("A chave {0} Não esta na Coleção",valor);
       	 }
       	 
       	 Dictionary<int,String>.ValueCollection valores = veiculos.Values;
       	 
       	 foreach(/*KeyValuePair<int,string>/string v in valores/*veiculos*){
       	 	Console.WriteLine(v/*.key/);
       	 }
       }
    }
}*/