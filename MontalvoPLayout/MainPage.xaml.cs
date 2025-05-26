namespace MontalvoPLayout
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Este contador se agrego aki 


        public MainPage()
        {
            InitializeComponent();

        }

        //Boton ir a demo 
        private void BotonIrDemo_Clicked(object sender, EventArgs e)
        {
            //Not  tiene dato de retorno por eso no ponemo un await
            Navigation.PushAsync(new Demo());
        }


        private void BotonStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage1());
        }
        
    }

}
