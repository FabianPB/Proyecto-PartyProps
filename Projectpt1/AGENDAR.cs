using BLL;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;

namespace Presentacion
{
    public partial class AGENDAR : Form
    {
        List<DetalleFactura> detalles = new List<DetalleFactura>();
        LogicaInventario inventario = new LogicaInventario();
        LogicaAgendar agendar = new LogicaAgendar();
        RepositorioFactura repositorioFactura = new RepositorioFactura();   
        
        public AGENDAR()
        {
            InitializeComponent();
            // Assign KeyPress events for validation
            txtIdFactura.KeyPress += txtIdFactura_KeyPress;
            txtCedula.KeyPress += txtCedula_KeyPress;
            txtNombreCliente.KeyPress += txtNombreCliente_KeyPress;
            txtIdArticulo.KeyPress += txtIdArticulo_KeyPress;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            if (string.IsNullOrWhiteSpace(txtIdFactura.Text))
            {
                MessageBox.Show("Campo IdFactura vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            factura.idFactura = txtIdFactura.Text;

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Campo nombre vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            factura.NombreCliente = txtNombreCliente.Text;

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                MessageBox.Show("Campo cédula vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            factura.CedulaCliente = txtCedula.Text;


            if (DateTime.Compare(factura.fechaFacturacion, factura.fechaDevolucion) > 0)
            {
                MessageBox.Show("Fecha devolución es menor a la fecha de alquiler", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            factura.fechaFacturacion = fecha1.Value;
            factura.fechaDevolucion = fecha2.Value;

            if (dataGridArtículos.RowCount == 0)
            {
                MessageBox.Show("Registre artículos para facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            factura.detalles = detalles;
           
            factura.CalcularMonto();
            agendar.Add(factura);
            MessageBox.Show("FACTURA REGISTRADA CON ÉXITO", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LIMPIAR();

        }

        public void LIMPIAR()
        {
            txtCedula.Clear();
            txtCantidad.Clear();
            txtIdArticulo.Clear();
            txtIdFactura.Clear();
            txtNombreCliente.Clear();
            dataGridArtículos.Rows.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtIdArticulo.Text))
            {
                MessageBox.Show("Campo IdArticulo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Campo Cantidad vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (detalles.FirstOrDefault(p => p.articulo.idArticulo == txtIdArticulo.Text) == null)
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.idFactura = int.Parse(txtIdArticulo.Text);
                detalle.articulo = inventario.Buscar(txtIdArticulo.Text);
                if (detalle.articulo == null)
                {
                    MessageBox.Show("Artículo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (int.Parse(txtCantidad.Text) > detalle.articulo.existencias)
                {
                    MessageBox.Show("No hay disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                detalle.cantidadProducto = int.Parse(txtCantidad.Text);

                detalle.CalcularSubtotal();
                dataGridArtículos.Rows.Add(detalle.articulo.idArticulo, detalle.articulo.categoria, detalle.articulo.descripcion, detalle.articulo.existencias, detalle.cantidadProducto, detalle.subtotal);
                detalles.Add(detalle);
            }
            else
            {
                MessageBox.Show("Artículo ya añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridArtículos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridArtículos.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                string id = dataGridArtículos.CurrentRow.Cells["ComId"].Value.ToString();
                var itemToRemove = detalles.FirstOrDefault(item => item.articulo.idArticulo == id);
                if (itemToRemove != null)
                {
                    detalles.Remove(itemToRemove);
                }
                dataGridArtículos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txtIdArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Articulo articulo = inventario.Buscar(txtIdArticulo.Text);
                if (articulo != null)
                {
                    lbArticulo.Text = articulo.descripcion;
                    lbValor.Text = articulo.existencias.ToString();
                }
                else
                {
                    MessageBox.Show("El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtIdFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters and space
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
        }

        private void AGENDAR_Resize(object sender, EventArgs e)
        {
            CentrarFormulario();
        }

        private void CentrarFormulario()
        {
            
            Panel panelContent = this.panelAgendar; 

            
            int x = (this.ClientSize.Width - panelContent.Width) / 2;
            int y = (this.ClientSize.Height - panelContent.Height) / 6;

            
            panelContent.Location = new Point(x, y);
        }
    }
}

