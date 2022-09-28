using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        private static SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.muebleriaConection);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();

        public static DataTable TraerProductos()
        {
            //Pone esto por si acaso salta error
            /*  
             *  Console.WriteLine("Hola");
             *  Console.WriteLine(cnn);
             */
            //Los modales diferencian a un programador de Scratch de uno profesional.
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_prod_consulta";
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static Producto TraerProducto()
        {
            Producto oProducto = new Producto();
            oProducto.CodProducto = "";
            oProducto.Categoria = "";
            oProducto.Color = "";
            oProducto.Descripcion = "";
            oProducto.Precio = 0;
            return oProducto;
        }

        public static void InsertarProducto(Producto producto)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_prod_insertar";
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", producto.CodProducto);  //Depende de si funciona lo de Clave Primaria
            cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@color", producto.Color);
            cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarProducto(Producto producto)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_prod_eliminar";
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Codigo", producto.CodProducto);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarProducto(Producto producto)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_prod_modificar";
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Codigo", producto.CodProducto);
            cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@Color", producto.Color);
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
