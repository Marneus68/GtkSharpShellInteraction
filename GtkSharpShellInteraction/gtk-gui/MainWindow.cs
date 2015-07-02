
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Entry commandEntry;
	
	private global::Gtk.Button runButton;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.ScrolledWindow scrolledwindow1;
	
	private global::Gtk.TextView outputTextview;
	
	private global::Gtk.Label GtkLabel2;
	
	private global::Gtk.HButtonBox hbuttonbox1;
	
	private global::Gtk.Button closeButton;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Gtk# Shell Interaction Test");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.BorderWidth = ((uint)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.hbox1.BorderWidth = ((uint)(3));
		// Container child hbox1.Gtk.Box+BoxChild
		this.commandEntry = new global::Gtk.Entry ();
		this.commandEntry.CanFocus = true;
		this.commandEntry.Name = "commandEntry";
		this.commandEntry.IsEditable = true;
		this.commandEntry.InvisibleChar = '●';
		this.hbox1.Add (this.commandEntry);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.commandEntry]));
		w1.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.runButton = new global::Gtk.Button ();
		this.runButton.CanFocus = true;
		this.runButton.Name = "runButton";
		this.runButton.UseUnderline = true;
		this.runButton.Label = global::Mono.Unix.Catalog.GetString ("Run");
		this.hbox1.Add (this.runButton);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.runButton]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.outputTextview = new global::Gtk.TextView ();
		this.outputTextview.CanFocus = true;
		this.outputTextview.Name = "outputTextview";
		this.outputTextview.Editable = false;
		this.outputTextview.CursorVisible = false;
		this.outputTextview.WrapMode = ((global::Gtk.WrapMode)(2));
		this.scrolledwindow1.Add (this.outputTextview);
		this.GtkAlignment.Add (this.scrolledwindow1);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Output</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w7.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.closeButton = new global::Gtk.Button ();
		this.closeButton.CanFocus = true;
		this.closeButton.Name = "closeButton";
		this.closeButton.UseUnderline = true;
		this.closeButton.Label = global::Mono.Unix.Catalog.GetString ("Close");
		this.hbuttonbox1.Add (this.closeButton);
		global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.closeButton]));
		w8.Expand = false;
		w8.Fill = false;
		this.vbox1.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 640;
		this.DefaultHeight = 471;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.commandEntry.Activated += new global::System.EventHandler (this.CommandEntryActivated);
		this.runButton.Clicked += new global::System.EventHandler (this.RunButtonClicked);
		this.closeButton.Clicked += new global::System.EventHandler (this.CloseButtonClicked);
	}
}