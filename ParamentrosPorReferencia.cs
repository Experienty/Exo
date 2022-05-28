/*using System;
using System.Linq;
using System.Collections.Generic;

namespace ParametrosPorReferencia
{
    public class Reference
    {         
        public static void AlterarRef(ref int numero)//sem ou com "ref"
        {
        	numero += 500;
        }
        public static void AlterarOut(int numero)
        {
        	numero += 50;
        }
        //Exemplo de Parametros Padrão
        public static double Multiplicação(double x = 3.4, double y = 3)
        {
        	return x * y;
        }
        
        public static void Main()
        {
        	int x = 5;
        	AlterarRef(ref x);//sem ou com "ref"
        	Console.WriteLine(x);
        	
        	int y = 8;
        	AlterarOut(y);
        	Console.WriteLine(y);
        	Console.WriteLine(Multiplicação());
        }
    }
}*/