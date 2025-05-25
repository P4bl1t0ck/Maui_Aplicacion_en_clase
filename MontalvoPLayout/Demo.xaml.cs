namespace MontalvoPLayout;

public partial class Demo : ContentPage
{
	public Demo()
	{
		InitializeComponent();
	}

    private void IrMainPage_Clicked(object sender, EventArgs e)
    {
		//Navigation.PopAsync();
		Navigation.PushAsync(new MainPage());
    }
}