using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			double numero = double.Parse(Console.ReadLine());


			if (numero == 0) {
				Console.WriteLine("\r\nO numero é igual a 0!", numero);
			}
			else {
				Console.WriteLine("\r\nO numero não é igual a 0!", numero);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
