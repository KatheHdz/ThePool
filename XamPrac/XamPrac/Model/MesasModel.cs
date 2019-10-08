using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamPrac.Model
{
    public class MesasModel : INotifyPropertyChanged
    {
        public int NumeroMesa { get; set; }
        public int Capacidad { get; set; }
        public string Area { get; set; }
        //public bool Estado { get; set; }
        private int _Ocupantes;

        public int Ocupantes
        {
            get {
                _consumible = 10 * _Ocupantes;
                return _Ocupantes; }
            set { _Ocupantes = value;  OnPropertyChanged(); }
        }

        //public int Relacion { get; set; }
        public string Pasadia { get; set; }
        private int _consumible;
        public int Consumible {
            get {
                return _consumible;
            }
            set
            {
                _consumible = value; OnPropertyChanged();
            }
                }
        public string Users { get; set; }
        public string Cliente { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
