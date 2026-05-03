using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.ChainOfResponsibility
{
	class OperatorSupport : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("Чи хочете зв'язатися з оператором?");
			Console.WriteLine("1 - Так");
			Console.WriteLine("2 - Ні");

			int choice = int.Parse(Console.ReadLine());

			if (choice == 1)
			{
				Console.WriteLine("З'єднання з оператором...");
				return true;
			}

			return false;
		}
	}
}
