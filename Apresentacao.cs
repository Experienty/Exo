/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Actiom
{
    public class Apresentacao 
    {         
        static void Main()
        {
            Action apresentaConsole = () =>
            {
            	Console.Write("Função & Metodo: ");
            };
            
            apresentaConsole();
            
            Func<int> sorteio = () => 
            {
            	Random random = new Random();
            	return random.Next(1, 101);
            };
            
            Console.WriteLine(sorteio());
        }
    }
}*/