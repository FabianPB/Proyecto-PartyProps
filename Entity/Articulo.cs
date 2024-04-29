using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Articulo
    {
        public string idArticulo {  get; set; }
        public string nombreArticulo { get; set; }
        public string Descripcion {  get; set; }    
        public double precioAlquiler { get; set; }
        public int Existencias { get; set; }
        public Categoria categoria { get; set; }    



    }
}
