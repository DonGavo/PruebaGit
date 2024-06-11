using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGit.Datos
{
    internal class ClConexion
    {
        private SqlConnection oConexion = null;

        public ClConexion()
        {
            oConexion = new SqlConnection("Data Source=DESKTOP-0K2FE29\\SQLEXPRESS;Initial Catalog=dbIntegradorMayo;Integrated Security=True;");
        }
        public SqlConnection MtdAbrirConexion()
        {
            oConexion.Open();
            return oConexion;
        }
        public void MtdCerrarConexion()
        {
            oConexion.Close();
        }
    }
}
