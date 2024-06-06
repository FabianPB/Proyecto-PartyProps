namespace Presentacion
{
    partial class Articulos
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
            Txt_Id = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtCantidad = new System.Windows.Forms.TextBox();
            btnRegistrar = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            cbCategoria = new System.Windows.Forms.ComboBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ComId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnActualizar = new System.Windows.Forms.DataGridViewImageColumn();
            btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            SuspendLayout();
            // 
            // Txt_Id
            // 
            Txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            Txt_Id.Location = new System.Drawing.Point(29, 148);
            Txt_Id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new System.Drawing.Size(170, 27);
            Txt_Id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(83, 120);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 21);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(22, 12);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(352, 39);
            label2.TabIndex = 2;
            label2.Text = "Registro de Artículos.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(59, 197);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNombre.Location = new System.Drawing.Point(29, 225);
            txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(169, 27);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(59, 355);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 21);
            label4.TabIndex = 5;
            label4.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescripcion.Location = new System.Drawing.Point(29, 383);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(170, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(35, 517);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(174, 21);
            label5.TabIndex = 7;
            label5.Text = "Precio Alquiler C/U :";
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrecio.Location = new System.Drawing.Point(30, 465);
            txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(169, 27);
            txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(59, 437);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 21);
            label6.TabIndex = 9;
            label6.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCantidad.Location = new System.Drawing.Point(30, 545);
            txtCantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(170, 27);
            txtCantidad.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.Black;
            btnRegistrar.Location = new System.Drawing.Point(50, 581);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(127, 49);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(29, 23);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(925, 63);
            panel1.TabIndex = 13;
            // 
            // dataGridArtículos
            // 
            dataGridArtículos.AllowUserToAddRows = false;
            dataGridArtículos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridArtículos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
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
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComNombre, ComDescripcion, ComCategoria, ComPrecio, ComExistencias, btnActualizar, btnEliminar });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(219, 247);
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
            dataGridArtículos.Size = new System.Drawing.Size(776, 329);
            dataGridArtículos.TabIndex = 14;
            dataGridArtículos.CellClick += dataGridArtículos_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(59, 273);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 21);
            label7.TabIndex = 15;
            label7.Text = "Categoría :";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new System.Drawing.Point(29, 303);
            cbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new System.Drawing.Size(170, 28);
            cbCategoria.TabIndex = 16;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscar.Location = new System.Drawing.Point(351, 161);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(188, 27);
            txtBuscar.TabIndex = 17;
            txtBuscar.KeyDown += textBox1_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(222, 163);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(133, 23);
            label8.TabIndex = 18;
            label8.Text = "Buscar Artículo :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(515, 213);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(208, 28);
            label9.TabIndex = 19;
            label9.Text = "Lista de Artículos";
            // 
            // ComId
            // 
            ComId.HeaderText = "Id";
            ComId.MinimumWidth = 6;
            ComId.Name = "ComId";
            ComId.Width = 53;
            // 
            // ComNombre
            // 
            ComNombre.HeaderText = "Nombre";
            ComNombre.MinimumWidth = 6;
            ComNombre.Name = "ComNombre";
            ComNombre.Width = 101;
            // 
            // ComDescripcion
            // 
            ComDescripcion.HeaderText = "Descripcion";
            ComDescripcion.MinimumWidth = 6;
            ComDescripcion.Name = "ComDescripcion";
            ComDescripcion.Width = 126;
            // 
            // ComCategoria
            // 
            ComCategoria.HeaderText = "Categoría";
            ComCategoria.MinimumWidth = 6;
            ComCategoria.Name = "ComCategoria";
            ComCategoria.Width = 112;
            // 
            // ComPrecio
            // 
            ComPrecio.HeaderText = "Precio";
            ComPrecio.MinimumWidth = 6;
            ComPrecio.Name = "ComPrecio";
            ComPrecio.Width = 85;
            // 
            // ComExistencias
            // 
            ComExistencias.HeaderText = "Existencias";
            ComExistencias.MinimumWidth = 6;
            ComExistencias.Name = "ComExistencias";
            ComExistencias.Width = 119;
            // 
            // btnActualizar
            // 
            btnActualizar.HeaderText = "ACT";
            btnActualizar.MinimumWidth = 6;
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Width = 46;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "X";
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 25;
            // 
            // Articulos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(995, 671);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtBuscar);
            Controls.Add(cbCategoria);
            Controls.Add(label7);
            Controls.Add(dataGridArtículos);
            Controls.Add(panel1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidad);
            Controls.Add(label6);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Txt_Id);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Articulos";
            Text = "ARTICULOS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComExistencias;
        private System.Windows.Forms.DataGridViewImageColumn btnActualizar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}