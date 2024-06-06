using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Articulo
    {
        public string idArticulo { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public double precioAlquiler { get; set; }
        public int existencias { get; set; }

        
        public Articulo()
        {

        }
        
    }
}
