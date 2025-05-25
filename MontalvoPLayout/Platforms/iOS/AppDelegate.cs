using Foundation;

namespace MontalvoPLayout
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => Stack.CreateMauiApp();
    }
}
