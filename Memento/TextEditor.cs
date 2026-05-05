using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatternsLab.Memento
{
	class TextEditor
	{
		private TextDocument document = new TextDocument();
		private Stack<DocumentMemento> history = new Stack<DocumentMemento>();

		public void Write(string text)
		{
			history.Push(document.Save());
			document.Content = document.Content + text;
		}

		public void Undo()
		{
			if (history.Count > 0)
			{
				var memento = history.Pop();
				document.Restore(memento);
			}
			else
			{
				Console.WriteLine("Немає змін для скасування");
			}
		}

		public void Show()
		{
			Console.WriteLine($"Поточний текст: {document.Content}");
		}
	}
}
