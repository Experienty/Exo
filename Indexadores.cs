/*using System;
using System.Linq;
using System.Collections.Generic;

    public class Indexator
    {         
        private int[] val=new int[5]{10,20,30,40,50};
        
        public int this[int i]{
        	get{
        		return val[i];
        	}
        	set{
        		if(val[i] < 0){
        			val[i] = 0;
        		}else if(val[i] > 50){
        			val[i] = 50;
        		}else{
        			val[i] = value;
        		}
        	}
        }
    }
class Tix
{
	static void Main()
	{
		Indexator x = new Indexator();
		//atribuir valor por cima do valor do index 4.
		//Exemplo:-} x[4] = 40; {- Modifique index 4 e o valor 40.
		Console.WriteLine("valoxes: {0}",x[4]);
	}
}*/