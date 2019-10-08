using System;
using System.Collections.Generic;
using System.Text;

namespace XamPrac.Model
{
    public class EmpleadoModel
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo_Electronico { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int DUI { get; set; }
        public int NIT { get; set; }
        public int AFP { get; set; }
        public int ISSS { get; set; }
        public int Fecha_Creacion { get; set; }
    }
}
