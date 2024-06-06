using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public interface ILogicaIventario
    {




        public void Registrar(Articulo articulo);
        
        public Articulo Buscar(string idArticulo);
        
        public void Eliminar(string idArticulo);

        public List<Articulo> ListaArticulo();



    }
}
