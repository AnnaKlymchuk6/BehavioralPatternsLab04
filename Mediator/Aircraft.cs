using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.Mediator
{
	class Aircraft
	{
		public string Name;
		private IMediator mediator;

		public Aircraft(string name, IMediator mediator)
		{
			Name = name;
			this.mediator = mediator;
		}

		public void Land()
		{
			Console.WriteLine($"Aircraft {Name} requests landing.");
			mediator.RequestLanding(this);
		}

		public void TakeOff()
		{
			Console.WriteLine($"Aircraft {Name} requests takeoff.");
			mediator.RequestTakeOff(this);
		}
	}
}
