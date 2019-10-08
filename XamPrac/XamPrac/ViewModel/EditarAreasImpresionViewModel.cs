using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class EditarAreasImpresionViewModel
    {
        private AreasImpresionModel _AreaSelecionada;

        public AreasImpresionModel AreaRecibida
        {
            get { return _AreaSelecionada; }
            set { _AreaSelecionada = value; OnPropertyChanged(); }
        }

        public EditarAreasImpresionViewModel()
        {

        }

        public EditarAreasImpresionViewModel(AreasImpresionModel AreaParametro = null)
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
