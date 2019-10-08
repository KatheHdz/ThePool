using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamPrac.View;
using XamPrac.View.OpcionesPage;
using XamPrac.View.OpcionesPage.EditarUsuariosPage;

namespace XamPrac.ViewModel
{
    public class OpcionesViewModel
    {
        public Command IrUsersCommand { get; set; }
        public Command IrEmpleadosCommand { get; set; }
        public  Command IrRolesCommand { get; set; }
        public Command IrAreasCommand { get; set; }
        public Command IrAreasImpresionCommand { get; set; }

        public OpcionesViewModel()
        {
            IrUsersCommand = new Command(GoToUser);
            IrEmpleadosCommand = new Command(GoToEmpleado);
            IrRolesCommand = new Command(GoToRoles);
            IrAreasCommand = new Command(GoToAreas);
            //IrAreasImpresionCommand = new Command(GoToAreasImpresion);
        }

        //private void GoToAreasImpresion()
        //{
          //  App.Current.MainPage.Navigation.PushAsync(new MostrarAreasImpresionView());
        //}

        private void GoToAreas()
        {
            App.Current.MainPage.Navigation.PushAsync(new MostrarAreasView());
        }

       private void GoToRoles()
        {
            App.Current.MainPage.Navigation.PushAsync(new MostrarRolesView());
        }


        private void GoToEmpleado()
        {
            App.Current.MainPage.Navigation.PushAsync(new MostrarEmpleadoView());

        }

        private void GoToUser()
        {
            App.Current.MainPage.Navigation.PushAsync(new MostrarUsuarioView());
            
        }
    }
}
