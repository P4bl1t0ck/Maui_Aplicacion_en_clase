namespace MontalvoPLayout;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void BotonFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new flexPage());
    }
}