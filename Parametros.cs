/*using System;

namespace Entr
{
    class Parametros 
    {         
        *static void Main(string[] args)
        {
        	int res = 0;
        	
        	if(args.Length > 0){
        		Console.WriteLine("qtds de argumentos: {0}", args.Length);
        		for(int i = 0; i < args.Length; i++){
        			res += int.Parse(args[i]);
        		}
        		Console.WriteLine("A soma: ",res);
        	}else{
        		Console.WriteLine("Não Foram Passados Nenhum Argumentos");
        	}
        }*
        //Exemplo de paramentro "Params" vc pode colocar quantos parametros voce quiser
        public static void Despedida(params string [] alunos)
        {
        	foreach(var aluno in alunos){
        		Console.WriteLine($"tchau {aluno} ate a proxima aula");
        	}
        }
        static void Main()
        {
        	Despedida("João", "Thiago", "Vanessa","Adriana","Alexa","Pedro","Leticia","Denilo","Violleta");
        }
    }
}*/