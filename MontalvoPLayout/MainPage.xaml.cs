namespace MontalvoPLayout
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void BotonIrDemo_Clicked(object sender, EventArgs e)
        {
            //Not  tiene dato de retorno por eso no ponemo un await
            Navigation.PushAsync(new Demo());
        }
    }

}
