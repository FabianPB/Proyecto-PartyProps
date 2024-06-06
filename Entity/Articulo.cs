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
        public string nombreArticulo { get; set; }
        public string descripcion { get; set; }
        public string categoria { get; set; }
        public double precioAlquiler { get; set; }
        public int existencias { get; set; }

        public Articulo(string idArticulo, string nombreArticulo,string categoria, string descripcion, double precioAlquiler, int existencias)
        {
            this.idArticulo = idArticulo;
            this.nombreArticulo = nombreArticulo;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.precioAlquiler = precioAlquiler;
            this.existencias = existencias;
        }
        public Articulo()
        {

        }
        public override string ToString()
        {
            return $"{idArticulo},{nombreArticulo},{categoria},{descripcion},{precioAlquiler},{existencias} ";
        }
    }
}
