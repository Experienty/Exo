/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Recursividade_Fatorial
{
    public class Recur 
    {         
        public int fat(int x){
        	int res;
        	if(x <= 1){
        		res = 1;
        	}else{
        		res = x * fat(x - 1);
        	}
        	return res;
        }
       static void Main()
       {
    	Recur r = new Recur();
    	var res = r.fat(7);
    	Console.WriteLine(res);
       }
    }
}*/