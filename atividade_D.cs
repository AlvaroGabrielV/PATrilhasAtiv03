using System;

namespace att02
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			int numero = int.Parse(Console.ReadLine());
			
			Console.Write("Insira um numero: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			Console.Write("Insira um numero: ");
			int numero3 = int.Parse(Console.ReadLine());

			if (numero < numero2 && numero > numero3){
				Console.WriteLine("\r\nO numero {0} e menor que {1} e maior que {2} !", numero, numero2, numero3);
			}
			else if (numero > numero2 && numero < numero3) {
				Console.WriteLine("\r\nO numero {0} e maior que {1} e menor que {2} !", numero, numero2, numero3);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
