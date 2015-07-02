using System;
using Gtk;

public partial class MainWindow: Gtk.Window {

	public MainWindow () : base (Gtk.WindowType.Toplevel) {
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
		Application.Quit ();
		a.RetVal = true;
	}

	protected void RunButtonClicked (object sender, EventArgs e) {
		if (commandEntry.Text.Trim() != "") {
			String command = commandEntry.Text.Trim ();

			String[] splitCommand = command.Split (' ');

			String exname = splitCommand [0];
			String parameters = "";

			foreach (var s in splitCommand) {
				if (s == exname) continue;
				parameters += " " + s;
			}
				
			outputTextview.Buffer.Text += " \ud83d\udd39 " + commandEntry.Text + System.Environment.NewLine;
			commandEntry.Text = "";

			GtkSharpShellInteraction.CliRunner.Run (exname, parameters, 9001, (l) => {
				System.Console.WriteLine(l);
				// This is needed as I am about to do something in the UI thread
				Gtk.Application.Invoke(delegate {outputTextview.Buffer.Text += l + System.Environment.NewLine;});
				return "";
			});
			//ProcessHelpers.ThreadedProcessRunner.RunProcess (exname, parameters);
			/*
			ProcessHelpers.ThreadedProcessRunner.RunProcessWithOutputRedirection (exname, parameters, (l) => {
				System.Console.WriteLine(l);
				// This is needed as I am about to do something in the UI thread
				Gtk.Application.Invoke(delegate {
					outputTextview.Buffer.Text += l + System.Environment.NewLine;
				});
				return "";
			});
			*/
		}
	}

	protected void CloseButtonClicked (object sender, EventArgs e) {
		Application.Quit ();
	}

	protected void CommandEntryActivated (object sender, EventArgs e) {
		RunButtonClicked (sender, e);
	}
}
