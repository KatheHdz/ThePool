using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamPrac.Model;
namespace XamPrac.Datos
{
    public interface IApiEmpleados
    {
        Task<IList<EmpleadoModel>> ObtenerLista();
        Task<EmpleadoModel> ObtenerEmpleadosPorId(int Id);
        Task Guardar(EmpleadoModel empleados, bool EsNuevo = false);
        Task Borrar(int id);
    }
  
}
