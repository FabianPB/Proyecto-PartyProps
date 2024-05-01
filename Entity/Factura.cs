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
        public double MontoCambio {  get; set; }

        public DateTime fechaFacturacion { get; set; }

        public DateTime fechaDevolucion { get; set; }   
        public Cliente Cliente { get; set; }    
    }
}
