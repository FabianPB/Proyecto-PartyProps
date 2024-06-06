
using Entity;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace DAL
{
    public class RepositorioInventario : IRepositorioInventario
    {
        private readonly string FileInventario = "./Inventario.csv";
        Articulo articulo = new Articulo();
        SqlDataReader reader;

        public void Registrar(Articulo articulo)
        {
            //FileStreamOptions opciones = new FileStreamOptions()
            //{
            //    Mode = FileMode.Append,
            //    Access = FileAccess.Write,
            //};

            //StreamWriter escribir = new StreamWriter(FileInventario, opciones);
            //escribir.WriteLine(articulo.ToString());
            //escribir.Close();

            try
            {
                string query = "Insert into idArticulo ([idArticulo],[nombreArticulo],[descripcion],[categoria],[precioAlquiler],[existencias]) values ('" + articulo.idArticulo + "','" + articulo.nombreArticulo + "','" + articulo.descripcion + "" +
                "','" + articulo.categoria + "','" + articulo.precioAlquiler + "','" + articulo.existencias + "')";

                using (SqlConnection conexion = servicioSQL.ObtenerConexion())
                {
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@idArticulo", articulo.idArticulo);
                        command.Parameters.AddWithValue("@nombreArticulo", articulo.nombreArticulo);
                        command.Parameters.AddWithValue("@descripcion", articulo.descripcion);
                        command.Parameters.AddWithValue("@categoria", articulo.categoria);
                        command.Parameters.AddWithValue("@precioAlquiler", articulo.precioAlquiler);
                        command.Parameters.AddWithValue("@existencias", articulo.existencias);

                        conexion.Open();
                        int filasAfectadas = command.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Se insertó el articulo correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el articulo.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el articulo: " + ex.Message);
            }
        }



        private Articulo MapearInventario(SqlDataReader reader) //el tipo de valor que se va a resivir
        {
            
            //var idArticulo = valorLineas[0];
            //var nombreArticulo = valorLineas[1];
            //var categoria = valorLineas[2];
            //var descripcion = valorLineas[3];
            //var precioAlquiler = double.Parse(valorLineas[4]);
            //var existencias = int.Parse(valorLineas[5]);
            //var articulo = new Articulo(idArticulo,categoria, nombreArticulo, descripcion, precioAlquiler, existencias);
            //return articulo;

            
            var idArticulo = reader["idArticulo"].ToString();
            var nombreArticulo = reader["nombreArticulo"].ToString();
            var categoria = reader["categoria"].ToString();
            var descripcion = reader["descripcion"].ToString();
            var precioAlquiler = Convert.ToDouble( reader["precioAlquiler"].ToString());
            var existencias = Convert.ToInt32(reader["existencias"].ToString());
            Articulo articulo = new Articulo(idArticulo,nombreArticulo,categoria,descripcion,precioAlquiler,existencias);
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

        public List<Articulo> EncontrarArticulos()
        {
            //var articulos = new List<Articulo>();
            //var opciones = new FileStreamOptions()
            //{
            //    Access = FileAccess.Read
            //};

            //using var leer = new StreamReader(FileInventario, opciones);
            //var linea = leer.ReadLine();
            //while (linea != null)
            //{
            //    var valorLineas = linea.Split(',');
            //    Articulo articulo = MapearInventario(valorLineas); // Corregido el nombre del método
            //    articulos.Add(articulo); // Agregado el objeto articulo, no Articulo
            //    linea = leer.ReadLine();
            //}
            //return articulos; // Devolver la lista de articulos


            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conexion = servicioSQL.ObtenerConexion())
            {

                string query = "select * from Orden";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    //Falta el Mapeado
                    lista.Add(MapearInventario(reader));

                }
                conexion.Close();
                return lista;
            }

        }

        public void EliminarArticulo(string idArticulo)
        {
            //var articulos = EncontrarArticulos();
            //var ArticuloEncontrado = articulos.FirstOrDefault(articulo => articulo.idArticulo.Equals(idArticulo));
            //if (ArticuloEncontrado == null)
            //    return;
            //foreach (var item in articulos)
            //{
            //    if (item.idArticulo.Equals(ArticuloEncontrado.idArticulo))
            //    {
            //        articulos.Remove(item);
            //        break;
            //    }
            //}
            //FileStreamOptions opciones = new FileStreamOptions()
            //{
            //    Mode = FileMode.Append,
            //    Access = FileAccess.Write,
            //};
            //StreamWriter escribir = new StreamWriter(FileInventario, false);
            //foreach (var articulo in articulos)
            //{
            //    escribir.WriteLine(articulo.ToString());
            //}
            //escribir.Close();

            string query = "DELETE FROM [Articulo]" +
                        $" WHERE [idArticulo] = '{articulo.idArticulo}'";

            using (SqlConnection conexion = servicioSQL.ObtenerConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    
                    command.CommandText = query;
                    command.Connection = servicioSQL.ObtenerConexion();
                    var x = command.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Console.WriteLine("Se elmino el repartidor");
                    }
                    Console.WriteLine("No se elemino el repartidor");
                }
            }
        }
        public void ModificarArticulo(Articulo ArticuloModificar)
        {
            //var articulos = EncontrarArticulos();
            //var ArticuloEncontrado = articulos.FirstOrDefault(articulo => articulo.idArticulo == ArticuloModificar.idArticulo);
            //if (ArticuloEncontrado == null)
            //    return;

            //// Remover el artículo encontrado de la lista
            //articulos.Remove(ArticuloEncontrado);

            //// Agregar el artículo modificado a la lista
            //articulos.Add(ArticuloModificar);

            //// Guardar los cambios en el archivo
            //foreach (var articulo in articulos)
            //{
            //    Registrar(articulo);
            //}

            string query = "UPDATE [Articulo] SET" +
        $"[nombreArticulo]='{articulo.nombreArticulo}',[categoria]='{articulo.categoria}',[descripcion]='{articulo.descripcion}',[precioAlquiler]='{articulo.precioAlquiler}'" +
        $"WHERE [Cedula]='{articulo.idArticulo}'";

            using (SqlConnection conexion = servicioSQL.ObtenerConexion())
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.CommandText = query;
                    command.Connection = servicioSQL.ObtenerConexion();
                    var x = command.ExecuteNonQuery();
                    if (x > 0)
                    {
                        Console.WriteLine("se Actualizo el repartidor");
                    }
                    Console.WriteLine("No se actualizo");
                }
            }
            }

        }
    }

