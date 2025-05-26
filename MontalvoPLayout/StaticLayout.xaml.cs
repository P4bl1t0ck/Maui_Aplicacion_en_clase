namespace MontalvoPLayout;

public partial class StaticLayout : ContentPage
{
	public StaticLayout()
	{
		InitializeComponent();
	}

    private void BotonStack_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}