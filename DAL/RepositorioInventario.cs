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
        public Factura EncontrarFactura(string cedula)
        {
            var FileFactura = "./Facturas.csv";
            var opciones = new FileStreamOptions()
            {
                Access = FileAccess.Read
            };

            using var leer = new StreamReader(FileFactura, opciones);
            var linea = leer.ReadLine();
            while (linea != null)
            {
                var lineaValor = linea.Split(';');
                var idFactura = lineaValor[0];
                var nombre = lineaValor[1];
                var telefono = lineaValor[2];
                var fechaingreso = DateTime.Parse(lineaValor[3]);
                var repartidor = new Repartidor(cedulaRepartidor, nombre, telefono, fechaingreso);

                if (cedulaRepartidor == cedula)
                {
                    return repartidor;
                }
                linea = leer.ReadLine();
            }
            return null;
        }
    }
}
