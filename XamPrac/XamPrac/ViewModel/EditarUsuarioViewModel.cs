using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamPrac.Model;

namespace XamPrac.ViewModel
{
    public class EditarUsuarioViewModel
    {
        private UsuarioModel _UsuarioSeleccionado;

        public UsuarioModel UsuarioRecibido
        {
            get { return _UsuarioSeleccionado; }
            set { _UsuarioSeleccionado = value; OnPropertyChanged(); }
        }

        public EditarUsuarioViewModel()
        {
            
        }

        public EditarUsuarioViewModel(UsuarioModel UsuarioParametro = null)
        {
            UsuarioRecibido = UsuarioParametro;
        }
       

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
