using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inventario : Form
    {
        LogicaInventario logicaInventario = new LogicaInventario();
        public Inventario()
        {

            InitializeComponent();
            CargarDatosTabla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }



        private void CargarDatosTabla()
        {
            string rutaArchivo = @"C:\\Users\\HOME\\OneDrive\\Escritorio\\PROYECTO\\Projectpt1\\bin\\Debug\\net8.0-windows\\Inventario.csv";

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            dataGridArtículos.Rows.Clear();

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (datos.Length == 5)
                {
                    dataGridArtículos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridArtículos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridArtículos.SelectedRows[0];
                dataGridArtículos.Rows.Remove(filaSeleccionada);
                string id = filaSeleccionada.Cells["ComId"].Value.ToString();
                string nombre = filaSeleccionada.Cells["ComNombre"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["ComDescripcion"].Value.ToString();
                string precio = filaSeleccionada.Cells["ComPrecio"].Value.ToString();
                string existencias = filaSeleccionada.Cells["ComExistencias"].Value.ToString();

                string lineaAEliminar = $"{id},{nombre},{descripcion},{precio},{existencias}";

                string rutaArchivo = @"C:\\Users\\HOME\\OneDrive\\Escritorio\\PROYECTO\\Projectpt1\\bin\\Debug\\net8.0-windows\\Inventario.csv";

                EliminarArchivo(rutaArchivo, lineaAEliminar);

            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna fila.");
            }


        }

        private void EliminarArchivo(string rutaArchivo, string lineaAEliminar)
        {
            try
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                List<string> lineasNoEliminadas = new List<string>();


                foreach (string linea in lineas)
                {
                    if (linea != lineaAEliminar)
                    {
                        lineasNoEliminadas.Add(linea);
                    }
                }
                File.WriteAllLines(rutaArchivo, lineasNoEliminadas);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al eliminar la línea del archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridArtículos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = Columns;
        }
    }
}
