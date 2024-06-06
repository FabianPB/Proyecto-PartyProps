using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Microsoft.Data.SqlClient;

using System.Data.SqlClient;

namespace DAL
{
   public class servicioSQL
    {
        private string cadenaConexion = "Server=.\\SQLEXPRESS;Database=DB_INVENTARIOALQUILER;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        protected SqlConnection conexion;

        public servicioSQL()
        {
            conexion = new SqlConnection(cadenaConexion);
        }


        public bool AbrirConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
                return true;
            }
            return false;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
