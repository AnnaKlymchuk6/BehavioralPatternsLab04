using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.ChainOfResponsibility
{
	abstract class SupportHandler
	{
		protected SupportHandler next;

		public void SetNext(SupportHandler nextHandler)
		{
			next = nextHandler;
		}
		public abstract bool Handle();
	}
}
