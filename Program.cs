using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static double Calculate( double arg1, double arg2)
		{
			Console.WriteLine("Введите бинаруную операцию");
			while (true)
			{
				switch (Console.ReadLine())
				{
					case "*":
						return arg1 * arg2;
					case "/":
						return arg1 / arg2;
					case "+":
						return arg1 + arg2;
					case "-":
						return arg1 - arg2;
					default:
						Console.WriteLine("Введена неизвестная операция. Введите заново.");
						break;
				}
			}
		}

		static double getNumber()
		{
			double number;
			while (true)
			{
				if (double.TryParse(Console.ReadLine(), out number))
					break;
				Console.WriteLine("Введено не число, введите число");
			}
			return number;
		}

		static string nextStep()
		{
			while (true)
			{
				switch (Console.ReadLine())
				{
					case "q":
						return "q";
					case "y":
						return "y";
					default:
						break;
				}
			}
		}

		static void Main(string[] args)
		{
			while (true)
			{
				double num1, num2;
				Console.WriteLine("Введите первое число");
				num1 = getNumber();
				Console.WriteLine("Введите второе число");
				num2 = getNumber();
				Console.WriteLine(Calculate(num1, num2));
				Console.WriteLine("Хотите продолжить ? (y - да/ q - выход)");
				if (nextStep() == "q")
					break;
			}
		}
	}
}
