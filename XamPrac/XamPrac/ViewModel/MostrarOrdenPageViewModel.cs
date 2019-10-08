using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class MostrarOrdenPageViewModel : INotifyPropertyChanged
    {
    
        private MesasModel _MesaSeleccionada;
        public MesasModel MesaRecibida
        {
            get { return _MesaSeleccionada; }
            set {
                _MesaSeleccionada = value;
                OnPropertyChanged();
            }
        }



        public MostrarOrdenPageViewModel()
        {

        }

        public MostrarOrdenPageViewModel(MesasModel MesaParametro = null): this()
        {
            MesaRecibida = MesaParametro;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
