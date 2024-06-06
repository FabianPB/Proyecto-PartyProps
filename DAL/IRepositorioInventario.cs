using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositorioInventario
    {
        public void Registrar(Articulo articulo);

        public Articulo EncontrarArticulo(string id);

        public List<Articulo> EncontrarArticulos();

        public void EliminarArticulo(string idEliminar);

        public void ModificarArticulo(Articulo ArticuloModificar);
    }
}
