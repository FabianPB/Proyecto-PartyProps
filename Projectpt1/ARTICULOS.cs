using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Articulos : Form
    {
        LogicaInventario logica = new LogicaInventario();
        public Articulos()
        {
            InitializeComponent();
            CargarDatosTabla();
            cbCategoria.Items.Add("Mesas");
            cbCategoria.Items.Add("Sillas");
            cbCategoria.Items.Add("Paredes");
            cbCategoria.Items.Add("Paneles");
            cbCategoria.Items.Add("Bases");
            cbCategoria.Items.Add("Fondos");
            cbCategoria.Items.Add("Numeros");
            cbCategoria.Items.Add("Letras");
            cbCategoria.Items.Add("Letreros");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios() == false)
            {
                MessageBox.Show("Error campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Articulo articulo = new Articulo();
            if (ValidarLetras(txtNombre.Text))
            {
                articulo.nombreArticulo = txtNombre.Text;
            }
            else
            {
                MessageBox.Show("El nombre solo permite letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbCategoria.SelectedItem != null)
            {
                articulo.categoria = cbCategoria.Text;
            }
            else
            {
                MessageBox.Show("Seleccione una categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarNumero(Txt_Id.Text))
            {
                articulo.idArticulo = Txt_Id.Text;
            }
            else
            {
                MessageBox.Show("El ID solo puede contener números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            articulo.descripcion = txtDescripcion.Text;
            if (ValidarNumero(txtPrecio.Text))
            {
                articulo.precioAlquiler = double.Parse(txtPrecio.Text);
            }
            else
            {
                MessageBox.Show("El precio debe ser solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidarNumero(txtCantidad.Text) && int.Parse(txtCantidad.Text) > 0)
            {
                articulo.existencias = int.Parse(txtCantidad.Text);
            }
            else
            {
                MessageBox.Show("La cantidad debe ser numérica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logica.Registrar(articulo);
            CargarDatosTabla();
            MessageBox.Show("Artículo registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void CargarDatosTabla()
        {
            //string rutaArchivo = @"C:\\Users\\HOME\\OneDrive\\Escritorio\\PROYECTO\\Projectpt1\\bin\\Debug\\net8.0-windows\\Inventario.csv";

            //if (!File.Exists(rutaArchivo))
            //{
            //    return;
            //}

            //string[] lineas = File.ReadAllLines(rutaArchivo);

            //dataGridArtículos.Rows.Clear();

            //foreach (string linea in lineas)
            //{
            //    string[] datos = linea.Split(',');
            //    if (datos.Length == 6)
            //    {
            //        dataGridArtículos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
            //    }
            //}



            var articulos = logica.ListaArticulo();
            dataGridArtículos.Rows.Clear();

            foreach (var articulo in articulos)
            {
              dataGridArtículos.Rows.Add(articulo.idArticulo, articulo.nombreArticulo, articulo.categoria, articulo.descripcion, articulo.precioAlquiler, articulo.existencias);
            }


        }
        bool ValidarLetras(string campo)
        {
            foreach (var item in campo)
            {
                if (!Char.IsLetter(item) && item != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        bool ValidarNumero(string validar)
        {
            foreach (var item in validar)
            {
                if (!Char.IsDigit(item) && item != '.')
                {
                    return false;
                }
            }
            return true;
        }
        bool ValidarVacios()
        {
            if (txtCantidad.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
            {
                return false;
            }
            return true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscar.Text.Length == 0)
                {
                    CargarDatosTabla();
                    return;
                }
                var buscado = logica.Buscar(txtBuscar.Text);
                if (buscado != null)
                {
                    dataGridArtículos.Rows.Clear();
                    dataGridArtículos.Rows.Add(buscado.idArticulo, buscado.nombreArticulo, buscado.categoria, buscado.descripcion, buscado.precioAlquiler, buscado.existencias);
                }
                else
                {
                    MessageBox.Show("El articulo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dataGridArtículos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridArtículos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar el articulo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    logica.Eliminar(dataGridArtículos.CurrentRow.Cells["ComId"].Value.ToString());
                    CargarDatosTabla();
                    MessageBox.Show("El articulo ha sido eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
