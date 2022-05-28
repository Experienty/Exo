/*using System;
using System.Linq;
using System.Collections.Generic;

namespace Vetor
{
    public class Preenchimento 
    {         
        static void Main()
        {
        	int[] par = new int[5];
        	int[] impar = new int[5];
        	int qp = 0,qi = 0;
        	int x;
        	
        	x = int.Parse(Console.ReadLine());
        	
        	for(int i = 0; i < 15; i++){
        		if(x%2 == 0){
        			par[qp] = x;
        			qp++;
        		if(qp == 5){
        			for(int j = 0; j < 5; j++){
        				Console.WriteLine("Par{0} = {1}\n",j,par[j]);
        				qp = 0;
        			}
        		}else{
        			impar[qi] = x;
        			qi++;
        			if(qi == 5){
        				for(int j = 0; j < 5; j++){
        					Console.WriteLine("O Impar{0} = {1}\n",j,impar[j]);
        					qi = 0;
        				}
        			}
        		}
        		}
        	}
        	for(int j = 0; j < qi; j++){
        		Console.WriteLine("Impar{0} = {1} ",j,impar[5]);
        	}
        	for(int j = 0; j < qp; j++){
        		Console.WriteLine("Par{0} = {1} ",j,par[5]);
        	}
        }
    }
}*/