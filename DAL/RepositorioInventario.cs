
using Entity;
namespace DAL
{
    public class RepositorioInventario : IRepositorioInventario
    {
        private readonly string FileInventario = "./Inventario.csv";

        public void Registrar(Articulo articulo)
        {
            FileStreamOptions opciones = new FileStreamOptions()
            {
                Mode = FileMode.Append,
                Access = FileAccess.Write,
            };

            StreamWriter escribir = new StreamWriter(FileInventario, opciones);
            escribir.WriteLine(articulo.ToString());
            escribir.Close();
        }
        private Articulo MapearInventario(string[]? valorLineas) //el tipo de valor que se va a resivir
        {
            var idArticulo = valorLineas[0];
            var nombreArticulo = valorLineas[1];
            var categoria = valorLineas[2];
            var descripcion = valorLineas[3];
            var precioAlquiler = double.Parse(valorLineas[4]);
            var existencias = int.Parse(valorLineas[5]);
            var articulo = new Articulo(idArticulo,categoria, nombreArticulo, descripcion, precioAlquiler, existencias);
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
            var articulos = new List<Articulo>();
            var opciones = new FileStreamOptions()
            {
                Access = FileAccess.Read
            };

            using var leer = new StreamReader(FileInventario, opciones);
            var linea = leer.ReadLine();
            while (linea != null)
            {
                var valorLineas = linea.Split(',');
                Articulo articulo = MapearInventario(valorLineas); // Corregido el nombre del método
                articulos.Add(articulo); // Agregado el objeto articulo, no Articulo
                linea = leer.ReadLine();
            }
            return articulos; // Devolver la lista de articulos
        }

        public void EliminarArticulo(string idArticulo)
        {
            var articulos = EncontrarArticulos();
            var ArticuloEncontrado = articulos.FirstOrDefault(articulo => articulo.idArticulo.Equals(idArticulo));
            if (ArticuloEncontrado == null)
                return;
            foreach (var item in articulos)
            {
                if (item.idArticulo.Equals(ArticuloEncontrado.idArticulo))
                {
                    articulos.Remove(item);
                    break;
                }
            }
            FileStreamOptions opciones = new FileStreamOptions()
            {
                Mode = FileMode.Append,
                Access = FileAccess.Write,
            };
            StreamWriter escribir = new StreamWriter(FileInventario, false);
            foreach (var articulo in articulos)
            {
                escribir.WriteLine(articulo.ToString());
            }
            escribir.Close();
        }
        public void ModificarArticulo(Articulo ArticuloModificar)
        {
            var articulos = EncontrarArticulos();
            var ArticuloEncontrado = articulos.FirstOrDefault(articulo => articulo.idArticulo == ArticuloModificar.idArticulo);
            if (ArticuloEncontrado == null)
                return;

            // Remover el artículo encontrado de la lista
            articulos.Remove(ArticuloEncontrado);

            // Agregar el artículo modificado a la lista
            articulos.Add(ArticuloModificar);

            // Guardar los cambios en el archivo
            foreach (var articulo in articulos)
            {
                Registrar(articulo);
            }
        }
    }
}
