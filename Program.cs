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
					case "n":
						return "n";
					default:
						Console.WriteLine("Введена неизвестная команда.\n" +
							"Доступные команды для ввода: \n" +
							"y - Продолжить с использованием текущего результата в качестве аргумента\n" +
							"n - Продолжить с новыми аргументами\n" +
							"q - Выход \nПовторите ввод.");
						break;
				}
			}
		}

		static string numOfNextArg()
		{
			while (true)
			{
				switch (Console.ReadLine())
				{
					case "1":
						return "1";
					case "2":
						return "2";
					default:
						Console.WriteLine("Введен неизвестный агрумент\nДоступные аргументы - '1, 2'\nПовторите ввод.");
						break;
				}
			}
		}

		static void Main(string[] args)
		{
			double num1 = 0, num2 = 0, nextArg = 0;
			while (true)
			{
				double result = 0;
				string next;
				if (nextArg != 1)
				{
					Console.WriteLine("Введите первое число");
					num1 = getNumber();
				}
				if(nextArg != 2)
				{
					Console.WriteLine("Введите второе число");
					num2 = getNumber();
				}
				result = Calculate(num1, num2);
				Console.WriteLine(result);
				Console.WriteLine("Хотите продолжить с использованием результата в качестве аргумента?\n(y - да/ n - продолжить с новыми аргументами/ q - выход)");
				next = nextStep();
				if (next == "y")
				{ 
					Console.WriteLine("В качестве какого аргумента хотите использовать результат?");
					next = numOfNextArg();
					if (next == "1")
					{
						nextArg = 1;
						num1 = result;
						continue;
					}
					if (next == "2")
					{
						nextArg = 2;
						num2 = result;
						continue;
					}
				}
				else if (next == "n")
				{
					nextArg = 0;
					continue;
				}
				else if (next == "q")
					break;
			}
		}
	}
}
