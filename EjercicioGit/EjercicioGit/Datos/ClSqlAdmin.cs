using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGit.Datos
{
    internal class ClSqlAdmin
    {
        public DataTable mtdSelect(string consulta)
        {
            ClConexion oConexion = new ClConexion();
            SqlConnection conexion = oConexion.MtdAbrirConexion();
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);

            DataTable datos = new DataTable();
            adapter.Fill(datos);
            oConexion.MtdCerrarConexion();
            return datos;
        }

        public int mtdIUD(string consulta)
        {
            ClConexion oConexion = new ClConexion();
            SqlConnection sqlConnection = oConexion.MtdAbrirConexion();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = consulta;
            int resultado = cmd.ExecuteNonQuery();
            return resultado;
        }

    }
}
