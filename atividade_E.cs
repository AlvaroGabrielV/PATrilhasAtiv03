using System;

namespace att02
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Insira um numero: ");
			float numero = float.Parse(Console.ReadLine());
			
			Console.Write("Insira um numero: ");
			float numero2 = float.Parse(Console.ReadLine());

			if (numero < numero2){
				Console.WriteLine("\r\nO numero {0} é menor que {1}!", numero, numero2);
			}
			else if (numero > numero2) {
				Console.WriteLine("\r\nO numero {0} é maior que {1}!", numero, numero2);
			}
			else {
				Console.WriteLine("\r\nO numero {0} é igual que {1}!", numero, numero2);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
