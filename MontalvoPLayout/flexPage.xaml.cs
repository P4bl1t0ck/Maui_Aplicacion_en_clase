namespace MontalvoPLayout;

public partial class flexPage : ContentPage
{
	public flexPage()
	{
		InitializeComponent();
	}

    private void Boton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StaticLayout());
    }
}