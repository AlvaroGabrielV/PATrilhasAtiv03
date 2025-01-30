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
			
			int diferenca = Math.Abs(numero - numero2);
		

			if (diferenca < 10) {
				Console.WriteLine("\r\nA diferença entre eles e menor que 10!", numero);
			}
			else if (diferenca == 10){
				Console.WriteLine("\r\nA diferença entre eles é igual a 10!", numero);
			}
			else {
				Console.WriteLine("\r\nA diferença entre eles é maior que 10!", numero);
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
