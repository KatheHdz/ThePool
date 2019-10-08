using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View;

namespace XamPrac.ViewModel
{
    public class MesaDisponibleViewViewModel
    {
        public ObservableCollection<MesasModel> ListaMesas { get; set; }
        public MesasModel MesaSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }

        public MesaDisponibleViewViewModel()
        {
            ListaMesas = new ObservableCollection<MesasModel>();
            MesaSeleccionada = new MesasModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarMesa);
            CargarMesas();
        }

        private void AccionAlSeleccionarMesa()
        {
            var PaginaDeMesas = new TomarOrdenPage();
            PaginaDeMesas.BindingContext = new  TomarOrdenPageViewModel(MesaSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeMesas);
        }

        private void CargarMesas()
        {
            ListaMesas.Add(new MesasModel { Capacidad = 4, NumeroMesa = 5 });
            ListaMesas.Add(new MesasModel { Capacidad = 2, NumeroMesa = 6 });
            ListaMesas.Add(new MesasModel { Capacidad = 8, NumeroMesa = 7 });
        }
    }
}
