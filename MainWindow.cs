using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnTerminarClicked (object sender, EventArgs e)
	{
		int puntos = 0;
			if (this.radiobtnC.Active)
				puntos++;

		if(this.spinbtn1.Text=="6")
				puntos++;

		if (this.checkbtnA.Active)
				puntos++;

		if (this.checkbtnC.Active)
				puntos++;

		DateTime fecha = this.calIndependencia.GetDate();
		string fechaSeleccionada = fecha.ToShortDateString();
		if (fechaSeleccionada == "16/09/1810"){
				puntos++;
		}

		MessageDialog md = new MessageDialog (null, 
		       DialogFlags.Modal,
		       MessageType.Info, 
		       ButtonsType.None, "Estos son los puntos obtenidos: \n" +
		                                      "Puntos: " + puntos + "\n");
		md.Show();

	}
}
