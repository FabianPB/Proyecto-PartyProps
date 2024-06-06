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
        RepositorioInventario repositorioInventario = new RepositorioInventario();
        


        public void Registrar(Articulo articulo)
        {

            repositorioInventario.Registrar(articulo);
             
        }
        public Articulo Buscar(string idArticulo)
        {
            return repositorioInventario.EncontrarArticulo(idArticulo);
        }
        public void Eliminar(string idArticulo)
        {
            repositorioInventario.EliminarArticulo(idArticulo);
        }
        public List<Articulo> ListaArticulo()
        {
            var articulos = repositorioInventario.EncontrarArticulos();
            return repositorioInventario.EncontrarArticulos();
        }
    }
}
