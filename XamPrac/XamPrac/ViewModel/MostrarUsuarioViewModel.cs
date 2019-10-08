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
    public class MostrarUsuarioViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<UsuarioModel> ListaUsuario { get; set; }
        public UsuarioModel UsuarioSeleccionado { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command NuevoUsuarioCommand { get; set; }

        public MostrarUsuarioViewModel()
        {
            ListaUsuario = new ObservableCollection<UsuarioModel>();
            UsuarioSeleccionado = new UsuarioModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarUsuario);
            NuevoUsuarioCommand = new Command(IrAUsuariosView);
            CargarUsuarios();
        }

        private void IrAUsuariosView()
        {
            var PaginaDeUsuarios = new EditarUsuarioView();
            PaginaDeUsuarios.BindingContext = new EditarUsuarioViewModel();
            App.Current.MainPage.Navigation.PushAsync(PaginaDeUsuarios);
        }

        private void AccionAlSeleccionarUsuario()
        {
            var PaginaDeUsuarios = new EditarUsuarioView();
            PaginaDeUsuarios.BindingContext = new EditarUsuarioViewModel(UsuarioSeleccionado);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeUsuarios);
        }

        private void CargarUsuarios()
        {
            ListaUsuario.Add(new UsuarioModel{
                Id_Usuario = 1, Usuario = " @LuisContreras ", Contra = "12345",
                Id_Empleado = 1, Id_Rol=1
            });

             ListaUsuario.Add(new UsuarioModel{
                Id_Usuario = 2, Usuario = " @AbelLopez ", Contra = "12345",
                Id_Empleado = 2, Id_Rol = 2
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
