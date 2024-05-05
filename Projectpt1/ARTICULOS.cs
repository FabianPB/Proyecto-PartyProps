using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(ValidarVacios() == false )
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
            if (ValidarNumero(txtPrecio.Text) )
            {
                articulo.precioAlquiler = double.Parse(txtPrecio.Text);
            }
            else
            {
                MessageBox.Show("El precio debe ser solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidarNumero(txtCantidad.Text) && int.Parse(txtCantidad.Text)>0)
            {
                articulo.existencias = int.Parse(txtCantidad.Text);
            }
            else
            {
                MessageBox.Show("La cantidad debe ser numérica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logica.Registrar(articulo);
            MessageBox.Show("Artículo registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (!Char.IsDigit(item) && item!='.')
                {
                    return false;
                }
            }
            return true;
        }
        bool ValidarVacios()
        {
            if(txtCantidad.Text=="" || txtDescripcion.Text=="" || txtNombre.Text=="" || txtPrecio.Text=="" || txtCantidad.Text == "")
            {
                return false;
            }
            return true;
        }
        private void Articulos_Load(object sender, EventArgs e)
        {

        }
    }
}
