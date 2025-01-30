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

			if (numero < numero2){
				Console.WriteLine("\r\nO numero {0} e menor que {1}!", numero, numero2);
			}
			else {
				Console.WriteLine("\r\nO numero {0} não é menor que {1}", numero, numero2);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
