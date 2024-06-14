using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogicaAgendar
    {
        RepositorioFactura datos = new RepositorioFactura();
        public void Add(Factura factura)
        {
            datos.AddFactura(factura);
        }
        public List<Factura> LeerFacturas()
        {
            return datos.leerFactura();
        }
        public Factura Eliminar(string idfactura)
        {
            return datos.EncontrarFactura(idfactura);
        }
        public List<DetalleFactura> LeerDetalles(string idFactura)
        {
            return datos.GetDetalleFacturas(idFactura);
        }

        public List<Factura> BuscarPorFecha(DateTime fecha)
        {
            return datos.BuscarFacturasPorFecha(fecha);
        }

    }
}
