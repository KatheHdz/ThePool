using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;
using XamPrac.View;

namespace XamPrac.ViewModel
{
    public class HabitacionesViewModel
    {
        public ObservableCollection<HabitacionesModel> ListaHabitacion { get; set; }
        public HabitacionesModel HabitacionSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }

        public HabitacionesViewModel()
        {
            ListaHabitacion = new ObservableCollection<HabitacionesModel>();
            HabitacionSeleccionada = new HabitacionesModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarHabitacion);
            CargarHabitaciones();
        }

        private void AccionAlSeleccionarHabitacion(object obj)
        {
            var PaginaDeHabitaciones = new TomarOrdenHabitacionPageView();
            PaginaDeHabitaciones.BindingContext = 
                new TomarOrdenPageHabitacionViewModel(HabitacionSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeHabitaciones);
        }

        private void CargarHabitaciones()
        {
            ListaHabitacion.Add(new HabitacionesModel
            { NumeroHabitacion = 1, Cliente ="Mathew",
                Users = "Hernandez" });
            ListaHabitacion.Add(new HabitacionesModel
            { NumeroHabitacion = 2,Cliente = "Axel",
                Users = "Lopez" });
        }
    }
}
