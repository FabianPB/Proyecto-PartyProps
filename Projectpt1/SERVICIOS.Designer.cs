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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComIdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComFechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            panelServicios.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(43, 44);
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
            dataGridArtículos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridArtículos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridArtículos.BackgroundColor = System.Drawing.Color.FromArgb(255, 227, 234);
            dataGridArtículos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridArtículos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridArtículos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridArtículos.ColumnHeadersHeight = 30;
            dataGridArtículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComIdFactura, ComCedula, ComNombreCliente, ComFechaEntrega, ComFechaDevolucion, ComPrecioTotal });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(43, 246);
            dataGridArtículos.Name = "dataGridArtículos";
            dataGridArtículos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridArtículos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridArtículos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridArtículos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridArtículos.Size = new System.Drawing.Size(880, 344);
            dataGridArtículos.TabIndex = 16;
            dataGridArtículos.SelectionChanged += dataGridArtículos_SelectionChanged;
            // 
            // ComIdFactura
            // 
            ComIdFactura.HeaderText = "ID Factura";
            ComIdFactura.MinimumWidth = 6;
            ComIdFactura.Name = "ComIdFactura";
            ComIdFactura.Width = 96;
            // 
            // ComCedula
            // 
            ComCedula.HeaderText = "Cedula";
            ComCedula.Name = "ComCedula";
            ComCedula.Width = 75;
            // 
            // ComNombreCliente
            // 
            ComNombreCliente.HeaderText = "Nombre Cliente";
            ComNombreCliente.MinimumWidth = 6;
            ComNombreCliente.Name = "ComNombreCliente";
            ComNombreCliente.Width = 129;
            // 
            // ComFechaEntrega
            // 
            ComFechaEntrega.HeaderText = "Fecha Entrega";
            ComFechaEntrega.MinimumWidth = 6;
            ComFechaEntrega.Name = "ComFechaEntrega";
            ComFechaEntrega.Width = 119;
            // 
            // ComFechaDevolucion
            // 
            ComFechaDevolucion.HeaderText = "Fecha Devolución";
            ComFechaDevolucion.MinimumWidth = 6;
            ComFechaDevolucion.Name = "ComFechaDevolucion";
            ComFechaDevolucion.Width = 140;
            // 
            // ComPrecioTotal
            // 
            ComPrecioTotal.HeaderText = "Precio Total";
            ComPrecioTotal.MinimumWidth = 6;
            ComPrecioTotal.Name = "ComPrecioTotal";
            ComPrecioTotal.Width = 103;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(349, 641);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(127, 49);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            btn.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn.ForeColor = System.Drawing.Color.Black;
            btn.Location = new System.Drawing.Point(501, 641);
            btn.Name = "btn";
            btn.Size = new System.Drawing.Size(127, 49);
            btn.TabIndex = 17;
            btn.Text = "Detalle";
            btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new System.Drawing.Point(43, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 23);
            label4.TabIndex = 21;
            label4.Text = "Buscar Factura :";
            // 
            // textBox1
            // 
            textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox1.Location = new System.Drawing.Point(182, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(197, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(43, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 27);
            label1.TabIndex = 19;
            label1.Text = "Lista de Facturas";
            // 
            // SERVICIOS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(1011, 740);
            Controls.Add(panelServicios);
            Controls.Add(button2);
            Controls.Add(btn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SERVICIOS";
            Text = "SERVICIOS";
            Load += SERVICIOS_Load;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComIdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecioTotal;
        private System.Windows.Forms.Panel panelServicios;
    }
}