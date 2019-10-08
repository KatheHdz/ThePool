using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class EditarRolesViewModel
    {
        private RolesModel _RolSeleccionado;

        public RolesModel RolRecibido
        {
            get { return _RolSeleccionado; }
            set { _RolSeleccionado = value; OnPropertyChanged(); }
        }

        public EditarRolesViewModel()
        {

        }

        public EditarRolesViewModel(RolesModel RolParametro = null)
        {
            RolRecibido = RolParametro;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
