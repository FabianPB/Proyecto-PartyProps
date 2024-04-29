using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleCompra
    {
        public string articulo {  get; set; }   
        public double precioArticulo { get; set; }

        public int cantidad { get; set; }

        public double total { get; set; }
    }
}
