using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaCompra
    {
        public string idFactura { get; set; }
        public double montoTotal { get; set; }
        public DateTime fechaCompra { get; set; }

        public List<DetalleCompra> detalles { get; set; } 

        public Proveedor proveedor { get; set; }
    }
}
