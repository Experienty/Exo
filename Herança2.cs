/*using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Herança2
{
    public class Professor
    {         
        protected readonly float salarioMaximo;
        
        float salarioAtual;
        
        public Professor(float salariomaximo)
        {
        	salarioMaximo = salariomaximo;
        }
        protected float Modificar(float modf)
        {
        	float novoSalario = salarioAtual + modf;
        	
        	if(novoSalario < 0){
        		salarioAtual = 0;
        	}else if(novoSalario > salarioMaximo){
        		salarioAtual = salarioMaximo;
        	}else{
        		salarioAtual = novoSalario;
        	}
        	return salarioAtual;
        }
        public float AumentaSalario()
        {
        	return Modificar(+500);
        }
        public float DiminuirSalario()
        {
        	return Modificar(-500);
        }
    }
    public class Prof : Professor
    {
    	public Prof() : base(1400)
    	{
    	 
    	}
    }
    
    public class Program
    {
    	static void Main()
    	{
    		Console.Write("Professor 1: ");
    		Prof prof1 = new Prof();
    		//Professor p = new Professor();
    		Console.WriteLine(prof1.AumentaSalario());
    		Console.WriteLine("");
    		Console.Write("Salario Atual: ");
    		Console.WriteLine(prof1.AumentaSalario());
    	}
    }
}*/