using System;

namespace att02
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			int numero = int.Parse(Console.ReadLine());

			if (numero >= 0){
				Console.WriteLine("\r\nO numero {0} é POSITIVO!", numero);
			}
			else {
				Console.WriteLine("\r\nO numero {0} é NEGATIVO!", numero);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
