using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double a1, a2, result;
			Console.WriteLine("Введите первое число");
			while (true)
			{
				if (double.TryParse(Console.ReadLine(), out a1))
					break;
				Console.WriteLine("Введено не число, введите число");
			}
			Console.WriteLine("Введите второе число");
			while (true)
			{
				if (double.TryParse(Console.ReadLine(), out a2))
					break;
				Console.WriteLine("Введено не число, введите число");
			}
			Console.WriteLine("Введите бинаруную операцию");
			while (true)
			{
				switch (Console.ReadLine())
				{
					case "*":
						result = a1*a2;
						goto End;
					case "/":
						result = a1 / a2;
						goto End;
					case "+":
						result = a1 + a2;
						goto End;
					case "-":
						result = a1 - a2;
						goto End;
					default:
						Console.WriteLine("Введена неизвестная операция. Введите заново.");
						break;
				}
			}

		End:
			Console.WriteLine(result);
			Console.Read();
		}
	}
}
