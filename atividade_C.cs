using System;

namespace att02
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			Console.Write("Insira um numero: ");
			int numero2 = Convert.ToInt32(Console.ReadLine());

			if (numero == numero2){
				Console.WriteLine("\r\nO numero {0} e {1} são iguais!", numero, numero2);
			}
			else {
				Console.WriteLine("\r\nO numero {0} e {1} não sao iguais!", numero, numero2);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
