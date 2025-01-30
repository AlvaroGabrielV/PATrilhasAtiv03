using System;

namespace att02
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = float.Parse(Console.ReadLine());
			
			float parimpar = numero % 2;
			
			if (parimpar == 0) {
				Console.WriteLine("O numero {0} é par!", numero);
			}
			else {
				Console.WriteLine("O numero {0} é impar!", numero);
			}

			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
