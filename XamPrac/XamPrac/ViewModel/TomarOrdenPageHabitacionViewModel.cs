using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class TomarOrdenPageHabitacionViewModel
    {
        private HabitacionesModel _HabitacionSeleccionada;

        public HabitacionesModel HabitacionRecibida
        {
            get { return _HabitacionSeleccionada; }
            set { _HabitacionSeleccionada = value; OnPropertyChanged(); }
        }

        public TomarOrdenPageHabitacionViewModel(HabitacionesModel HabitacionParametro = null)
        {
            HabitacionRecibida = HabitacionParametro;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
