using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class EditarAreasViewModel
    {
        private AreasModel _AreaSelecionada;

        public AreasModel AreaRecibida
        {
            get { return _AreaSelecionada; }
            set { _AreaSelecionada = value; OnPropertyChanged(); }
        }

        public EditarAreasViewModel()
        {

        }

        public EditarAreasViewModel(AreasModel AreaParametro = null)
        {
            AreaRecibida = AreaParametro;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
