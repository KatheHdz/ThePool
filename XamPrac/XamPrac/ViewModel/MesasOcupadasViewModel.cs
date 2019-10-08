using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View;

namespace XamPrac.ViewModel
{
    public class MesasOcupadasViewModel
    {
        public ObservableCollection<MesasModel> ListaMesas { get; set; }
        public MesasModel MesaSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }

        public MesasOcupadasViewModel()
        {
            ListaMesas = new ObservableCollection<MesasModel>();
            MesaSeleccionada = new MesasModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarMesa);
            CargarMesas();
        }

        private void AccionAlSeleccionarMesa(object obj)
        {
            var PaginaDeMesas = new MostrarOrdenPage();
            PaginaDeMesas.BindingContext = new MostrarOrdenPageViewModel(MesaSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeMesas);
        }

        private void CargarMesas()
        {
           ListaMesas.Add(new MesasModel { Area = "Piscina", Capacidad = 4, NumeroMesa = 1,
                Ocupantes = 3, Users="Portillo", Pasadia="Consumible", Consumible= 45,
                Cliente = "Nory" });

            ListaMesas.Add(new MesasModel { Area = "Piscina", Capacidad = 6, NumeroMesa = 2,
                Ocupantes =  5, Users= "Lopez", Pasadia="No Consumible",
                 Consumible = 0, Cliente = "Stefany" });

            ListaMesas.Add(new MesasModel { Area = "Piscina", Capacidad = 10, NumeroMesa = 3,
                Ocupantes = 9, Users= "Mathew", Pasadia="Hibrida",
                 Consumible = 50, Cliente="Thyron"});

            ListaMesas.Add(new MesasModel { Area = "Piscina", Capacidad = 2, NumeroMesa = 4,
                Ocupantes = 2, Users= "Valentina", Pasadia="No Consumible",
                 Consumible = 0, Cliente="Emma" });
        }
    }
}
