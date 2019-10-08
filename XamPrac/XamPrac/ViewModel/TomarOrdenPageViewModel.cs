using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
   public  class TomarOrdenPageViewModel:INotifyPropertyChanged
    {
        private MesasModel _MesaSeleccionada;

        public MesasModel MesaRecibida
        {
            get { return _MesaSeleccionada; }
            set { _MesaSeleccionada = value;  OnPropertyChanged(); }
        }

        public TomarOrdenPageViewModel()
        {
                
        }
        public TomarOrdenPageViewModel(MesasModel MesaParametro = null):this()
        {
            MesaRecibida = MesaParametro;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
