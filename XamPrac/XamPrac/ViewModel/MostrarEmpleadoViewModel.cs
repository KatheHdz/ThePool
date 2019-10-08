using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View.OpcionesPage.EditarUsuariosPage;

namespace XamPrac.ViewModel
{
    public class MostrarEmpleadoViewModel : BaseModel
    {
        private ObservableCollection<EmpleadoModel> _ListaEmpleado;

        public ObservableCollection<EmpleadoModel> ListaEmpleado
        {
            get { return _ListaEmpleado; }
            set { _ListaEmpleado = value; OnPropertyChanged(); } 
        }

        //public ObservableCollection<EmpleadoModel> ListaEmpleado { get; set;}
        public EmpleadoModel EmpleadoSeleccionado { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command NuevoEmpleadoCommand { get; set; }

        public MostrarEmpleadoViewModel()
        {
            ListaEmpleado = new ObservableCollection<EmpleadoModel>();
            EmpleadoSeleccionado = new EmpleadoModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarEmpleado);
            NuevoEmpleadoCommand = new Command(IrAEmpleadosView);
            CargarEmpleados();
        }

        private void IrAEmpleadosView(object obj)
        {
            var PaginaDeEmpleados = new EditarEmpleadoView();
            PaginaDeEmpleados.BindingContext = new EditarEmpleadoViewModel();
            App.Current.MainPage.Navigation.PushAsync(PaginaDeEmpleados);
        }

        private void AccionAlSeleccionarEmpleado(object obj)
        {
            var PaginaDeEmpleados = new EditarEmpleadoView();
            PaginaDeEmpleados.BindingContext = new EditarEmpleadoViewModel(EmpleadoSeleccionado);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeEmpleados);
        }

        private async void CargarEmpleados()
        {

           

            var ListaTemporal = await App.ApiManager.Empleados.ObtenerLista();
            ListaEmpleado = new ObservableCollection<EmpleadoModel>( ListaTemporal);
        }
    }
}
