using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {
        public string idFactura { get; set; }
        public string NombreCliente { get; set; }
        public string CedulaCliente { get; set; }
        public List<DetalleFactura> detalles { get; set; }
        public double montoPago { get; set; }
        public DateTime fechaFacturacion { get; set; }

        public DateTime fechaDevolucion { get; set; }
        public void CalcularMonto()
        {
            foreach (var detalle in detalles)
            {
                montoPago += detalle.subtotal;
            }
        }

    }


}
