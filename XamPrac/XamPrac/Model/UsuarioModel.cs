using System;
using System.Collections.Generic;
using System.Text;

namespace XamPrac.Model
{
    public class UsuarioModel
    {
        public int Id_Usuario { get; set; }
        public int Id_Empleado { get; set; }
        public int Id_Rol { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }     
    }
}
