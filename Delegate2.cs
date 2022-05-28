/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Delly
{
    class Program
    {         
        delegate double BinaryNumaricOperation(double x1, double x2);
        
        class Calculadora
        {
        	public static double Max(double x, double y)
        	{
        		if(x > y){
        			return x;
        		}else{
        			return y;
        		}
        	}
        	public static double soma(double x, double y)
        	{
        		return y;
        	}
        	
        	static void Main()
        	{
        		double a = 10;
        		double b = 30;
        		
        		BinaryNumaricOperation operacoes = Calculadora.soma;
        		
        		Console.WriteLine(operacoes(a,b));
        	}
        }
    }
}*/