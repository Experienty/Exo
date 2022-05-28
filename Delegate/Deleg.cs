/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Delegate
{
    public class Deleg 
    {         
        delegate int Op(int x1, int x2);
        
        public static int soma(int x1, int x2)
        {
        	return x1 + x2;
        }
        public static int mult(int x1, int x2)
        {
        	return x1 * x2;
        }
        static void Main()
        {
        	int res;
        	
            Op ox = new Op(Deleg.soma);
            
            res = ox(1984,1916);
            
            Console.WriteLine("A soma é:{0}",res);
            
            ox = new Op(Deleg.mult);
            
            res = ox(10,10);
            
            Console.WriteLine("multplicação é:{0}",res);
        }
    }
}*/