using BehavioralPatternsLab.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Завдання 1: Ланцюжок відповідальностей");

			while (true)
			{
				Console.WriteLine("\nВи додзвонились до служби підтримки");
				Console.WriteLine("Натисніть Enter щоб почати або 0 щоб вийти");

				string input = Console.ReadLine();
				if (input == "0") break;

				var tech = new TechnicalSupport();
				var billing = new FinancialSupport();
				var general = new GeneralSupport();
				var operatorSupport = new OperatorSupport();

				tech.SetNext(billing);
				billing.SetNext(general);
				general.SetNext(operatorSupport);

				bool handled = tech.Handle();

				if (!handled)
				{
					Console.WriteLine("\nНе вдалося визначити проблему. Спробуйте ще раз");
				}
			}
		}
	}
}
