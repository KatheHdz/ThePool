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
    public class MostrarAreasImpresorViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AreasImpresionModel> ListaAreas { get; set; }
        public AreasImpresionModel AreaSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command NuevaAreaCommand { get; set; }

        public MostrarAreasImpresorViewModel()
        {
            ListaAreas = new ObservableCollection<AreasImpresionModel>();
            AreaSeleccionada = new AreasImpresionModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarArea);
            NuevaAreaCommand = new Command(IraAreasView);
            CargarAreas();

        }

        private void IraAreasView(object obj)
        {
            var PaginaDeAreas = new EditarAreasImpresionView();
            PaginaDeAreas.BindingContext = new EditarAreasImpresionViewModel();
            App.Current.MainPage.Navigation.PushAsync(PaginaDeAreas);
        }

        private void AccionAlSeleccionarArea(object obj)
        {
            var PaginaDeAreas = new EditarAreasImpresionView();
            PaginaDeAreas.BindingContext = new EditarAreasImpresionViewModel(AreaSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeAreas);
        }

        private void CargarAreas()
        {
            ListaAreas.Add(new AreasImpresionModel
            {
                 Id_AreaImpresion = 1, Nombre_Area = "Cocina",
                Ruta_Impresor = "10.0.0.0 a 10.255.255.255"
            });

            ListaAreas.Add(new AreasImpresionModel
            {
                Id_AreaImpresion = 2, Nombre_Area = "Bebidas",
                Ruta_Impresor = "172.16.0.0 a 172.31.255.255"
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
