using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using Mono.TextEditor;

namespace MonoDevelop.Samples.DateInserter
{
	class InsertDateHandler : CommandHandler
	{
		protected override void Run ()
		{
			var editor = IdeApp.Workbench.ActiveDocument.GetContent<ITextEditorDataProvider> ().GetTextEditorData ();
			editor.InsertAtCaret (DateTime.Now.ToString ());
		}
		
		protected override void Update (CommandInfo info)
		{
			var doc = IdeApp.Workbench.ActiveDocument;
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider> () != null;
		}
	}

	public enum DateInserterCommands
	{
		InsertDate,
	}
}