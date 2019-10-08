using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPrac.Datos;
using XamPrac.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamPrac
{
    public partial class App : Application
    {
        public static Manager ApiManager { get; set; } 
        public App()
        {
            InitializeComponent();
            ApiManager = new Manager();
            MainPage = new NavigationPage( new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
