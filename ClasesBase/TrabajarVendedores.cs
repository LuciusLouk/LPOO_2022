using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarVendedores
    {
        private static SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.muebleriaConection);
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public static DataTable TraerVendedor()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_vend_consulta";
            cmd.Connection = cnn;

            da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public static void InsertarVendedor(Vendedor vendedor)
        {           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_vend_insertar";
            cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@legajo",vendedor.Legajo);  Depende de si funciona lo de Clave Primaria
            cmd.Parameters.AddWithValue("@nombre",vendedor.Nombre);
            cmd.Parameters.AddWithValue("@apellido",vendedor.Apellido);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarVendedor(Vendedor vendedor)
        {           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_vend_eliminar";
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@legajo",vendedor.Legajo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void ModificarVendedor(Vendedor vendedor)
        {           
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_vend_modificar";
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@legajo", vendedor.Legajo);
            cmd.Parameters.AddWithValue("@nombre",vendedor.Nombre);
            cmd.Parameters.AddWithValue("@apellido",vendedor.Apellido);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
