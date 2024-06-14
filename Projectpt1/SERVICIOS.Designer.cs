namespace Projectpt1
{
    partial class SERVICIOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComFechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            txtBuscarFactura = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panelServicios = new System.Windows.Forms.Panel();
            cmbFechas = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            panelServicios.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(57, 50);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(880, 63);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(22, 12);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(302, 39);
            label2.TabIndex = 2;
            label2.Text = "Pedidos Vigentes.";
            // 
            // dataGridArtículos
            // 
            dataGridArtículos.AllowUserToAddRows = false;
            dataGridArtículos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridArtículos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridArtículos.BackgroundColor = System.Drawing.Color.FromArgb(255, 227, 234);
            dataGridArtículos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridArtículos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridArtículos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridArtículos.ColumnHeadersHeight = 30;
            dataGridArtículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComIdFactura, ComCedula, ComNombreCliente, ComFechaEntrega, ComFechaDevolucion, ComPrecioTotal });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(57, 252);
            dataGridArtículos.Name = "dataGridArtículos";
            dataGridArtículos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridArtículos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridArtículos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridArtículos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridArtículos.Size = new System.Drawing.Size(886, 476);
            dataGridArtículos.TabIndex = 16;
            dataGridArtículos.SelectionChanged += dataGridArtículos_SelectionChanged;
            // 
            // ComIdFactura
            // 
            ComIdFactura.HeaderText = "ID Factura";
            ComIdFactura.MinimumWidth = 6;
            ComIdFactura.Name = "ComIdFactura";
            ComIdFactura.Width = 115;
            // 
            // ComCedula
            // 
            ComCedula.HeaderText = "Cedula";
            ComCedula.MinimumWidth = 6;
            ComCedula.Name = "ComCedula";
            ComCedula.Width = 91;
            // 
            // ComNombreCliente
            // 
            ComNombreCliente.HeaderText = "Nombre Cliente";
            ComNombreCliente.MinimumWidth = 6;
            ComNombreCliente.Name = "ComNombreCliente";
            ComNombreCliente.Width = 159;
            // 
            // ComFechaEntrega
            // 
            ComFechaEntrega.HeaderText = "Fecha Entrega";
            ComFechaEntrega.MinimumWidth = 6;
            ComFechaEntrega.Name = "ComFechaEntrega";
            ComFechaEntrega.Width = 146;
            // 
            // ComFechaDevolucion
            // 
            ComFechaDevolucion.HeaderText = "Fecha Devolución";
            ComFechaDevolucion.MinimumWidth = 6;
            ComFechaDevolucion.Name = "ComFechaDevolucion";
            ComFechaDevolucion.Width = 172;
            // 
            // ComPrecioTotal
            // 
            ComPrecioTotal.HeaderText = "Precio Total";
            ComPrecioTotal.MinimumWidth = 6;
            ComPrecioTotal.Name = "ComPrecioTotal";
            ComPrecioTotal.Width = 126;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(57, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 23);
            label4.TabIndex = 21;
            label4.Text = "Buscar Factura :";
            // 
            // txtBuscarFactura
            // 
            txtBuscarFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscarFactura.Location = new System.Drawing.Point(196, 192);
            txtBuscarFactura.Name = "txtBuscarFactura";
            txtBuscarFactura.Size = new System.Drawing.Size(197, 27);
            txtBuscarFactura.TabIndex = 20;
            txtBuscarFactura.KeyDown += txtBuscarFactura_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(57, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 27);
            label1.TabIndex = 19;
            label1.Text = "Lista de Facturas";
            // 
            // panelServicios
            // 
            panelServicios.BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            panelServicios.Controls.Add(cmbFechas);
            panelServicios.Controls.Add(label3);
            panelServicios.Controls.Add(panel1);
            panelServicios.Controls.Add(label4);
            panelServicios.Controls.Add(dataGridArtículos);
            panelServicios.Controls.Add(txtBuscarFactura);
            panelServicios.Controls.Add(label1);
            panelServicios.Location = new System.Drawing.Point(0, 0);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new System.Drawing.Size(1011, 740);
            panelServicios.TabIndex = 15;
            // 
            // cmbFechas
            // 
            cmbFechas.FormattingEnabled = true;
            cmbFechas.Location = new System.Drawing.Point(676, 192);
            cmbFechas.Name = "cmbFechas";
            cmbFechas.Size = new System.Drawing.Size(195, 28);
            cmbFechas.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new System.Drawing.Point(461, 194);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(209, 23);
            label3.TabIndex = 23;
            label3.Text = "Buscar Factura por Fecha :";
            // 
            // SERVICIOS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(1011, 740);
            Controls.Add(panelServicios);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SERVICIOS";
            Text = "SERVICIOS";
            Load += SERVICIOS_Load;
            Resize += SERVICIOS_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            panelServicios.ResumeLayout(false);
            panelServicios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecioTotal;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.ComboBox cmbFechas;
        private System.Windows.Forms.Label label3;
    }
}