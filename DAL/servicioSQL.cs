using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class servicioSQL
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Server=localhost;Database=delivery_express_db;User ID=sa;Password=Sup3r5tr0ngP4ss;");
            conexion.Open();

            return conexion;

        }
    }
}
