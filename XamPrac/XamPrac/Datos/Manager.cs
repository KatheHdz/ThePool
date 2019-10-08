using System;
using System.Collections.Generic;
using System.Text;

namespace XamPrac.Datos
{
    public class Manager
    {
        public EmpleadoService Empleados { get; set; }
        public Manager() {
            Empleados = new EmpleadoService();
        }
    }
}
