using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private string codProducto, categoria, color, descripcion;
        private decimal precio;

        public Producto()
        {

        }

        public string CodProducto { get { return codProducto; } set { codProducto = value; } }
        public string Categoría { get { return categoria; } set { categoria = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public decimal Precio { get { return precio; } set { precio = value; } }

        public override string ToString()
        {
            string msg = "Desea guardar este producto?"+"\nCodigo: " + codProducto + "\nCategoria: " + categoria + "\nColor: " + color + "\nDescripcion: " + descripcion + "\nPrecio: " + precio;
            return msg;
        }
    }
}
