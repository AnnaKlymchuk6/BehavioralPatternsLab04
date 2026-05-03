using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.Mediator
{
	class Runway
	{
		public readonly Guid Id = Guid.NewGuid();
		public bool IsBusy;

		public void SetBusy()
		{
			IsBusy = true;
			Console.WriteLine($"Runway {Id} is busy!");
		}

		public void SetFree()
		{
			IsBusy = false;
			Console.WriteLine($"Runway {Id} is free!");
		}
	}
}
