using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class MostrarOrdenHabitacionPageViewModel : INotifyPropertyChanged
    {
        private HabitacionesModel _HabitacionSeleccionada;

        public HabitacionesModel HabitacionRecibida
        {

            get { return _HabitacionSeleccionada; }
            set { _HabitacionSeleccionada = value; OnPropertyChanged(); }
        }
        public MostrarOrdenHabitacionPageViewModel(HabitacionesModel HabitacionParametro = null)
        {
            HabitacionRecibida = HabitacionParametro;
        }

        public MostrarOrdenHabitacionPageViewModel()
        {
                
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
