using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class AGENDAR : Form
    {
        public AGENDAR()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridArtículos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AGENDAR_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
           
            Panel panelContent = this.panelAgendar;

            // Calcula la posición para centrar el panel
            int x = (this.ClientSize.Width - panelContent.Width) / 2;
            int y = (this.ClientSize.Height - panelContent.Height) / 6;

            
            panelContent.Location = new Point(x, y);
        }

        private void AGENDAR_Load(object sender, EventArgs e)
        {
            
        }
    }
}
