using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View;

namespace XamPrac.ViewModel
{
    public class LoginPageViewModel
    {
        public UsuarioModel UsuarioActual { get; set; }
        public Command AccederCommand { get; set; }

        public LoginPageViewModel()
        {
            UsuarioActual = new UsuarioModel();
            AccederCommand = new Command(MetodoParaAcceder);
        }

        void MetodoParaAcceder()
        {
            if (UsuarioActual.Usuario == "administrador" && UsuarioActual.Contra == "12345")
            {
                App.Current.MainPage.DisplayAlert("Mensaje", "Acceso correcto", "ok");
                App.Current.MainPage.Navigation.PushAsync(new MichiMDView());
            }
            else if (UsuarioActual.Usuario == "mesero" && UsuarioActual.Contra == "12345")
            {
                App.Current.MainPage.DisplayAlert("Mensaje", "Acceso correcto", "ok");
                App.Current.MainPage.Navigation.PushAsync(new MesasView());
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Mensaje", "Acceso incorrecto", "ok");
            }
        }

    }
}
