namespace Presentacion
{
    partial class AGENDAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGENDAR));
            fecha1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fecha2 = new System.Windows.Forms.DateTimePicker();
            txtIdFactura = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnRegistrar = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNombreCliente = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtIdArticulo = new System.Windows.Forms.TextBox();
            btnAgregar = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtCantidad = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            txtCedula = new System.Windows.Forms.TextBox();
            lbArticulo = new System.Windows.Forms.Label();
            lbValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // fecha1
            // 
            fecha1.Cursor = System.Windows.Forms.Cursors.Hand;
            fecha1.Location = new System.Drawing.Point(45, 309);
            fecha1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fecha1.Name = "fecha1";
            fecha1.Size = new System.Drawing.Size(162, 23);
            fecha1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(60, 288);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 19);
            label1.TabIndex = 5;
            label1.Text = "Fecha de Alquiler:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(45, 350);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(162, 19);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Devolución:";
            // 
            // fecha2
            // 
            fecha2.Cursor = System.Windows.Forms.Cursors.Hand;
            fecha2.Location = new System.Drawing.Point(45, 371);
            fecha2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            fecha2.Name = "fecha2";
            fecha2.Size = new System.Drawing.Size(162, 23);
            fecha2.TabIndex = 7;
            // 
            // txtIdFactura
            // 
            txtIdFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIdFactura.Location = new System.Drawing.Point(45, 120);
            txtIdFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtIdFactura.Name = "txtIdFactura";
            txtIdFactura.Size = new System.Drawing.Size(162, 23);
            txtIdFactura.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(73, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 19);
            label4.TabIndex = 9;
            label4.Text = "ID Factura :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.Black;
            btnRegistrar.Location = new System.Drawing.Point(544, 455);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(111, 37);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Agendar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(427, 455);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(111, 37);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(442, 80);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(173, 23);
            label6.TabIndex = 14;
            label6.Text = "Reservar Artículos";
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
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComCategoria, ComDescripcion, ComPrecio, ComExistencias, colSubtotal, btnEliminar });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(237, 147);
            dataGridArtículos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            dataGridArtículos.Size = new System.Drawing.Size(641, 284);
            dataGridArtículos.TabIndex = 15;
            dataGridArtículos.CellContentClick += dataGridArtículos_CellContentClick;
            // 
            // ComId
            // 
            ComId.HeaderText = "Id";
            ComId.MinimumWidth = 6;
            ComId.Name = "ComId";
            ComId.Width = 45;
            // 
            // ComCategoria
            // 
            ComCategoria.HeaderText = "Categoría";
            ComCategoria.Name = "ComCategoria";
            ComCategoria.Width = 92;
            // 
            // ComDescripcion
            // 
            ComDescripcion.HeaderText = "Descripcion";
            ComDescripcion.MinimumWidth = 6;
            ComDescripcion.Name = "ComDescripcion";
            ComDescripcion.Width = 103;
            // 
            // ComPrecio
            // 
            ComPrecio.HeaderText = "Precio";
            ComPrecio.MinimumWidth = 6;
            ComPrecio.Name = "ComPrecio";
            ComPrecio.Width = 70;
            // 
            // ComExistencias
            // 
            ComExistencias.HeaderText = "Existencias";
            ComExistencias.MinimumWidth = 6;
            ComExistencias.Name = "ComExistencias";
            ComExistencias.Width = 97;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "colSubtotal";
            colSubtotal.Width = 84;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 5;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label5);
            panel1.Location = new System.Drawing.Point(45, 9);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(804, 47);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(19, 9);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(237, 32);
            label5.TabIndex = 2;
            label5.Text = "Agendar Pedido.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(60, 214);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(125, 19);
            label2.TabIndex = 18;
            label2.Text = "Nombre Cliente :";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNombreCliente.Location = new System.Drawing.Point(45, 235);
            txtNombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new System.Drawing.Size(162, 23);
            txtNombreCliente.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(237, 117);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 19);
            label8.TabIndex = 20;
            label8.Text = "ID Artículo:";
            // 
            // txtIdArticulo
            // 
            txtIdArticulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIdArticulo.Location = new System.Drawing.Point(311, 116);
            txtIdArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtIdArticulo.Name = "txtIdArticulo";
            txtIdArticulo.Size = new System.Drawing.Size(72, 23);
            txtIdArticulo.TabIndex = 19;
            txtIdArticulo.KeyDown += txtIdArticulo_KeyDown;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregar.Image = (System.Drawing.Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new System.Drawing.Point(843, 99);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(46, 40);
            btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnAgregar.TabIndex = 22;
            btnAgregar.TabStop = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(384, 116);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 19);
            label7.TabIndex = 23;
            label7.Text = "Artículo :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(719, 120);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 19);
            label9.TabIndex = 24;
            label9.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCantidad.Location = new System.Drawing.Point(792, 116);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(45, 23);
            txtCantidad.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            label10.Location = new System.Drawing.Point(502, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(75, 19);
            label10.TabIndex = 27;
            label10.Text = "Valor C/U :";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(45, 412);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(162, 114);
            panel2.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(28, 19);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(112, 23);
            label11.TabIndex = 29;
            label11.Text = "Saldo Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(79, 157);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(69, 19);
            label12.TabIndex = 29;
            label12.Text = "Cedula :";
            // 
            // txtCedula
            // 
            txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCedula.Location = new System.Drawing.Point(45, 178);
            txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new System.Drawing.Size(162, 23);
            txtCedula.TabIndex = 30;
            // 
            // lbArticulo
            // 
            lbArticulo.AutoSize = true;
            lbArticulo.Location = new System.Drawing.Point(464, 122);
            lbArticulo.Name = "lbArticulo";
            lbArticulo.Size = new System.Drawing.Size(0, 15);
            lbArticulo.TabIndex = 31;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new System.Drawing.Point(615, 123);
            lbValor.Name = "lbValor";
            lbValor.Size = new System.Drawing.Size(0, 15);
            lbValor.TabIndex = 32;
            // 
            // AGENDAR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(890, 538);
            Controls.Add(lbValor);
            Controls.Add(lbArticulo);
            Controls.Add(txtCedula);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(txtCantidad);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(btnAgregar);
            Controls.Add(label8);
            Controls.Add(txtIdArticulo);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(panel1);
            Controls.Add(dataGridArtículos);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btnRegistrar);
            Controls.Add(label4);
            Controls.Add(txtIdFactura);
            Controls.Add(fecha2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(fecha1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "AGENDAR";
            Text = "RESERVAS";
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAgregar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComExistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}