using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.Mediator
{
	class CommandCentre : IMediator
	{
		private List<Runway> runways;

		public CommandCentre(List<Runway> runways)
		{
			this.runways = runways;
		}

		public void RequestLanding(Aircraft aircraft)
		{
			foreach (var runway in runways)
			{
				if (!runway.IsBusy)
				{
					Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {runway.Id}");
					runway.SetBusy();
					return;
				}
			}

			Console.WriteLine("No free runway available for landing.");
		}

		public void RequestTakeOff(Aircraft aircraft)
		{
			foreach (var runway in runways)
			{
				if (runway.IsBusy)
				{
					Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {runway.Id}");
					runway.SetFree();
					return;
				}
			}

			Console.WriteLine("No runway available for takeoff.");
		}
	}
}
