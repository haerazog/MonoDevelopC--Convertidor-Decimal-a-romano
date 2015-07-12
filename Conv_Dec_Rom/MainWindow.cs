using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	int num_dec;
	conversion conv = new conversion();
	string result;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
		
	protected void OnOkClicked (object sender, System.EventArgs e)
	{
		num_dec = Convert.ToInt16(pantalla.Text);
		pantalla2.DeleteText(0,pantalla2.Text.Length);
		result =  conv.romano(num_dec);
		pantalla2.InsertText(result);
	}

	protected void OnOkkClicked (object sender, System.EventArgs e)
	{
		pantalla.DeleteText(0,pantalla.Text.Length);
		pantalla2.DeleteText(0,pantalla2.Text.Length);
	}
}