using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View.OpcionesPage.EditarUsuariosPage;

namespace XamPrac.ViewModel
{
    public class MostrarRolesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<RolesModel> ListaRoles { get; set; }
        public RolesModel RolSeleccionado { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command NuevoRolCommand { get; set; }

        public MostrarRolesViewModel()
        {
            ListaRoles = new ObservableCollection<RolesModel>();
            RolSeleccionado = new RolesModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarRol);
            NuevoRolCommand = new Command(IrARolView);
            CargarRoles();
        }

        private void IrARolView()
        {
            var PaginaDeRoles = new EditarRolesView();
            PaginaDeRoles.BindingContext = new EditarRolesViewModel();
            App.Current.MainPage.Navigation.PushAsync(PaginaDeRoles);
        }

        private void AccionAlSeleccionarRol()
        {
            var PaginaDeRoles = new EditarRolesView();
            PaginaDeRoles.BindingContext = new EditarRolesViewModel(RolSeleccionado);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeRoles);
        }

        private void CargarRoles()
        {
            ListaRoles.Add(new RolesModel
            {
                 Id_Rol = 1, Roles = "Administrador"
            });

             ListaRoles.Add(new RolesModel
            {
                 Id_Rol = 2, Roles = "Meseros"
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
