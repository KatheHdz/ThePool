using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View;

namespace XamPrac.ViewModel
{
   public  class MesasReservadasViewModel
    {
        public ObservableCollection<MesasModel> ListaMesas { get; set; }
        public MesasModel MesaSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }

        public MesasReservadasViewModel()
        {
            ListaMesas = new ObservableCollection<MesasModel>();
            MesaSeleccionada = new MesasModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarMesa);
            CargarMesas();
        }

        private void AccionAlSeleccionarMesa(object obj)
        {
            var PaginaDeMesas = new TomarOrdenPage();
            PaginaDeMesas.BindingContext = new TomarOrdenPageViewModel(MesaSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeMesas);
        }

        private void CargarMesas()
        {
           ListaMesas.Add(new MesasModel
            {
                Area = "Glorieta", Capacidad = 4, NumeroMesa = 17, Users = "Portillo",Cliente = "Nory"
            });

            ListaMesas.Add(new MesasModel
            {
                Area = "Piscina", Capacidad = 2, NumeroMesa = 15, Users = "Ian", Cliente = "Emely"
            });
        }
    }
}

