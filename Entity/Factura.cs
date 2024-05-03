using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura

    {
        public string idFactura {  get; set; }  
        public double montoPago { get; set; }
        public double montoCambio {  get; set; }

        public DateTime fechaFacturacion { get; set; }

        public DateTime fechaDevolucion { get; set; }

        public Factura(string idFactura, double montoPago, double montoCambio, DateTime fechaFacturacion, DateTime fechaDevolucion)
        {
            this.idFactura = idFactura;
            this.montoPago = montoPago;
            this.montoCambio = montoCambio;
            this.fechaFacturacion = fechaFacturacion;
            this.fechaDevolucion = fechaDevolucion;
        }
    }


}
