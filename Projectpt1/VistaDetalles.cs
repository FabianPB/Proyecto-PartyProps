﻿using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectpt1
{
    public partial class VistaDetalles : Form
    {
        LogicaAgendar agendar = new LogicaAgendar();
        public VistaDetalles( string idFactura)
        {
            InitializeComponent();
            List<DetalleFactura> detalles= agendar.LeerDetalles(idFactura);
            if (detalles != null)
            {
                foreach (var item in detalles)
                {
                    dataGridArtículosDetalle.Rows.Add(item.articulo.idArticulo,item.articulo.categoria,item.articulo.descripcion, item.articulo.existencias, item.articulo.precioAlquiler);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para esta factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
