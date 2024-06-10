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
        public SERVICIOS()
        {
            InitializeComponent();
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
