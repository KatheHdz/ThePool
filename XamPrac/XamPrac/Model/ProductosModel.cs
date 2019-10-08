using System;
using System.Collections.Generic;
using System.Text;

namespace XamPrac.Model
{
    public class ProductosModel
    {
        public int Id_Producto { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_SubCategorias { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
