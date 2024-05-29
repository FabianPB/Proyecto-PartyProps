using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogicaInventario : ILogicaIventario
    {
        RepositorioInventario datos = new RepositorioInventario();
        


        public void Registrar(Articulo articulo)
        {

            datos.Registrar(articulo);
             
        }
        public Articulo Buscar(string idArticulo)
        {
            return datos.EncontrarArticulo(idArticulo);
        }
        public void Eliminar(Articulo articulo)
        {
            datos.EliminarArticulo(articulo);
        }
        public List<Articulo> ListaArticulo()
        {
            var articulos = datos.EncontrarArticulos();
            return datos.EncontrarArticulos();
        }
    }
}
