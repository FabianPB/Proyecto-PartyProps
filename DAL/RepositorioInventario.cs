
using Entity;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace DAL
{
    public class RepositorioInventario : servicioSQL
    {
        public void Registrar(Articulo articulo)
        {
            string registro = "INSERT INTO ARTICULO (IdArticulo, Descripcion, Categoria, PrecioAlquiler, Existencias) VALUES " +
                "(@IdArticulo, @Descripcion, @Categoria, @PrecioAlquiler, @Existencias)";
            try
            {
                using (SqlCommand command = new SqlCommand(registro, conexion))
                {
                    command.Parameters.AddWithValue("@IdArticulo", articulo.idArticulo);
                    command.Parameters.AddWithValue("@Descripcion", articulo.descripcion);
                    command.Parameters.AddWithValue("@Categoria", articulo.categoria);
                    command.Parameters.AddWithValue("@PrecioAlquiler", articulo.precioAlquiler);
                    command.Parameters.AddWithValue("@Existencias", articulo.existencias);
                    AbrirConexion();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                return;

            }
            finally
            {
                CerrarConexion();
            }
        }



        private Articulo MapearInventario(SqlDataReader reader) 
        {
            Articulo articulo = new Articulo
            {
                idArticulo = Convert.ToString(reader["IdArticulo"]),
                descripcion = Convert.ToString(reader["Descripcion"]),
                categoria = Convert.ToString(reader["Categoria"]),
                precioAlquiler = Convert.ToDouble(reader["PrecioAlquiler"]),
                existencias = Convert.ToInt16(reader["Existencias"])
            };
            return articulo;

        }


        public Articulo EncontrarArticulo(string id)
        {
            foreach (var item in EncontrarArticulos())
            {
                if (item.idArticulo.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }

        //public Articulo buscar(string idArticulo)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        public List<Articulo> EncontrarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            string query = "select * from ARTICULO";
            try
            {
                SqlCommand command = new SqlCommand(query, conexion);
                AbrirConexion();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(MapearInventario(reader));
                }
                reader.Close();
                CerrarConexion();
            }
            catch(Exception )
            {
                
                return null;
            }
            return lista;

        }

        public void EliminarArticulo(string idArticulo)
        {
            string query = "DELETE FROM ARTICULO WHERE IdArticulo = @IdArticulo";
            try
            {
                using(SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@IdArticulo", idArticulo);
                    AbrirConexion() ;
                    var afectado = command.ExecuteNonQuery();
                    CerrarConexion();
                }
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                CerrarConexion() ;
            }
        }


    }
}

        //public void ModificarArticulo(Articulo ArticuloModificar)
        //{
        //    string query = "UPDATE ARTICULO SET "
        //}