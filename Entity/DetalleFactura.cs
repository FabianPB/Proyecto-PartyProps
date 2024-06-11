using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public int IdDetalleFactura {  get; set; }
        public int idFactura {  get; set; }
        public Articulo articulo { get; set; }
        public int cantidadProducto { get; set; }
        public double subtotal;
        public void CalcularSubtotal()
        {
            subtotal = cantidadProducto * articulo.existencias;
        }
    }
}
