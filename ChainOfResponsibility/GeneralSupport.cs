using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.ChainOfResponsibility
{
	class GeneralSupport : SupportHandler
	{
		public override bool Handle()
		{
			Console.WriteLine("Чи маєте ви загальні питання?");
			Console.WriteLine("1 - Так");
			Console.WriteLine("2 - Ні");

			int choice = int.Parse(Console.ReadLine());

			if (choice == 1)
			{
				Console.WriteLine("Вас переведено до загальної підтримки");
				return true;
			}
			if (next != null) {
				return next.Handle();
			}
			return false;
		}
	}
}
