using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.Memento
{
	class TextDocument
	{
		public string Content { get; set; } = "";

		public DocumentMemento Save()
		{
			return new DocumentMemento(Content);
		}

		public void Restore(DocumentMemento memento)
		{
			Content = memento.Content;
		}
	}
}
