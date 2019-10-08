using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View.OpcionesPage.EditarUsuariosPage;

namespace XamPrac.ViewModel
{
    public class EditarEmpleadoViewModel
    {
        private EmpleadoModel _EmpleadoSeleccionado;
        public Command GuardarCommand { get; set; }
        public Command BorrarCommand { get; set; }
        private bool EsNuevo { get; set; }

        public EmpleadoModel EmpleadoRecibido
        {
            get { return _EmpleadoSeleccionado; }
            set { _EmpleadoSeleccionado = value; OnPropertyChanged(); }
        }

        public EditarEmpleadoViewModel()
        {
            EmpleadoRecibido = new EmpleadoModel();
            EsNuevo = true;
            GuardarCommand = new Command( guardar);

            BorrarCommand = new Command(borrar);
        }

        private async void  guardar()
        {
            if (this.EsNuevo)
            {
                await App.ApiManager.Empleados.Guardar(EmpleadoRecibido, true);
            }
            else
            {
                await App.ApiManager.Empleados.Guardar(EmpleadoRecibido, false);
            }
        }

        private async void borrar()
        {
          await  App.ApiManager.Empleados.Borrar(EmpleadoRecibido.Id_Empleado);
           await App.Current.MainPage.Navigation.PushAsync(new MostrarEmpleadoView());
        }

      /*  private async void guardar2(bool v = false)
        {
            if (v)
            {
                await App.ApiManager.Empleados.Guardar(EmpleadoRecibido, true);
            }
            else
            {
                await App.ApiManager.Empleados.Guardar(EmpleadoRecibido, false);
            }
        }*/

        public EditarEmpleadoViewModel(EmpleadoModel EmpleadoParametro = null)
        {
            EmpleadoRecibido = EmpleadoParametro;
            EsNuevo = false;
            GuardarCommand = new Command(guardar);

            BorrarCommand = new Command(borrar);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
