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
    public class MostrarAreasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<AreasModel> ListaAreas { get; set; }
        public AreasModel AreaSeleccionada { get; set; }
        public Command ItemTappedCommand { get; set; }
        public Command NuevaAreaCommand { get; set; }

        public MostrarAreasViewModel()
        {
            ListaAreas = new ObservableCollection<AreasModel>();
            AreaSeleccionada = new AreasModel();
            ItemTappedCommand = new Command(AccionAlSeleccionarArea);
            NuevaAreaCommand = new Command(IraAreasView);
            CargarAreas();
        }

        private void IraAreasView()
        {
            var PaginaDeAreas = new EditarAreasView();
            PaginaDeAreas.BindingContext = new EditarAreasViewModel();
            App.Current.MainPage.Navigation.PushAsync(PaginaDeAreas);
   
        }     

        private void AccionAlSeleccionarArea()
        {
            var PaginaDeAreas = new EditarAreasView();
            PaginaDeAreas.BindingContext = new EditarAreasViewModel(AreaSeleccionada);
            App.Current.MainPage.Navigation.PushAsync(PaginaDeAreas);
        }

        private void CargarAreas()
        {
            ListaAreas.Add(new AreasModel
            {
                 Id_Area = 1, Area = "Piscina", Descripcion = "Palmeras", Deducible = 15
            });

            ListaAreas.Add(new AreasModel
            {
                 Id_Area = 2, Area = "Glorieta", Descripcion = "Sombrillas", Deducible = 0
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
