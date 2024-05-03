using BLL;

namespace DAL
{
    public class RepositorioInventario
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
            var descripcion = valorLineas[2];
            var precioAlquiler = double.Parse(valorLineas[3]);
            var existencias = int.Parse(valorLineas[4]);
            var articulo = new Articulo(idArticulo, nombreArticulo, descripcion, precioAlquiler, existencias);
            return articulo;
        }
        
    }
}
