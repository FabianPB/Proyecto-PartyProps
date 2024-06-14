using BLL;
using Presentacion;
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
    public partial class SERVICIOS : Form
    {
        LogicaAgendar agendar = new LogicaAgendar();
        public SERVICIOS()
        {
            InitializeComponent();
            Cargartabla();
            cmbFechas.SelectedIndexChanged += cmbFechas_SelectedIndexChanged;
        }
        public void Cargartabla()
        {
            var facturas = agendar.LeerFacturas();
            if (facturas != null)
            {
                dataGridArtículos.Rows.Clear();

                foreach (var item in facturas)
                {
                    dataGridArtículos.Rows.Add(item.idFactura, item.CedulaCliente, item.NombreCliente, item.fechaFacturacion, item.fechaDevolucion, item.montoPago);
                }
            }
            LlenarComboBoxFechas();
        }


        private void SERVICIOS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridArtículos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridArtículos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridArtículos.SelectedRows[0];
                // Accede a las celdas de la fila seleccionada
                string idFactura = selectedRow.Cells["ComIdFactura"].Value.ToString();
                VistaDetalles ventana = new VistaDetalles(idFactura);
                ventana.Show();
            }
        }



        private void txtBuscarFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscarFactura.Text.Length == 0)
                {
                    Cargartabla();
                    return;
                }
                var buscado = agendar.Eliminar(txtBuscarFactura.Text);
                if (buscado != null)
                {
                    dataGridArtículos.Rows.Clear();
                    dataGridArtículos.Rows.Add(buscado.idFactura, buscado.CedulaCliente, buscado.NombreCliente, buscado.fechaFacturacion, buscado.fechaDevolucion, buscado.montoPago);
                }
                else
                {
                    MessageBox.Show("El articulo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void SERVICIOS_Resize(object sender, EventArgs e)
        {
            CentrarFormulario();
        }

        private void SERVICIOS_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {

            Panel panelContent = this.panelServicios;

            // Calcula la posición para centrar el panel
            int x = (this.ClientSize.Width - panelContent.Width) / 2;
            int y = (this.ClientSize.Height - panelContent.Height) / 6;


            panelContent.Location = new Point(x, y);
        }
    }
}
