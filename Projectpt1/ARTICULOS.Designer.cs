﻿namespace Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            Txt_Id = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtPrecio = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtCantidad = new System.Windows.Forms.TextBox();
            btnRegistrar = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnActualizar = new System.Windows.Forms.DataGridViewImageColumn();
            btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            label7 = new System.Windows.Forms.Label();
            cbCategoria = new System.Windows.Forms.ComboBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panelArtículos = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            panelArtículos.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Id
            // 
            Txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            Txt_Id.Location = new System.Drawing.Point(52, 164);
            Txt_Id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new System.Drawing.Size(170, 27);
            Txt_Id.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(106, 136);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(82, 325);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 21);
            label4.TabIndex = 5;
            label4.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtDescripcion.Location = new System.Drawing.Point(52, 353);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(170, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(58, 516);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(174, 21);
            label5.TabIndex = 7;
            label5.Text = "Precio Alquiler C/U :";
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPrecio.Location = new System.Drawing.Point(53, 447);
            txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(169, 27);
            txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(82, 419);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 21);
            label6.TabIndex = 9;
            label6.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtCantidad.Location = new System.Drawing.Point(53, 544);
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
            btnRegistrar.Location = new System.Drawing.Point(73, 597);
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
            panel1.Location = new System.Drawing.Point(52, 39);
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
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComDescripcion, ComCategoria, ComPrecio, ComExistencias, btnActualizar, btnEliminar });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(312, 273);
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
            dataGridArtículos.Size = new System.Drawing.Size(774, 383);
            dataGridArtículos.TabIndex = 14;
            dataGridArtículos.CellClick += dataGridArtículos_CellClick;
            dataGridArtículos.CellContentClick += dataGridArtículos_CellContentClick;
            // 
            // ComId
            // 
            ComId.HeaderText = "Id";
            ComId.MinimumWidth = 6;
            ComId.Name = "ComId";
            ComId.Width = 53;
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
            btnActualizar.Image = (System.Drawing.Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.MinimumWidth = 6;
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Width = 46;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "X";
            btnEliminar.Image = (System.Drawing.Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.MinimumWidth = 6;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Width = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(82, 225);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(106, 21);
            label7.TabIndex = 15;
            label7.Text = "Categoría :";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new System.Drawing.Point(52, 255);
            cbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new System.Drawing.Size(170, 28);
            cbCategoria.TabIndex = 16;
            // 
            // txtBuscar
            // 
            txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBuscar.Location = new System.Drawing.Point(474, 200);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(188, 27);
            txtBuscar.TabIndex = 17;
            txtBuscar.KeyDown += textBox1_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(335, 204);
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
            label9.Location = new System.Drawing.Point(543, 233);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(208, 28);
            label9.TabIndex = 19;
            label9.Text = "Lista de Artículos";
            // 
            // panelArtículos
            // 
            panelArtículos.BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            panelArtículos.Controls.Add(panel1);
            panelArtículos.Controls.Add(label9);
            panelArtículos.Controls.Add(Txt_Id);
            panelArtículos.Controls.Add(label8);
            panelArtículos.Controls.Add(label1);
            panelArtículos.Controls.Add(txtBuscar);
            panelArtículos.Controls.Add(label4);
            panelArtículos.Controls.Add(cbCategoria);
            panelArtículos.Controls.Add(txtDescripcion);
            panelArtículos.Controls.Add(label7);
            panelArtículos.Controls.Add(label5);
            panelArtículos.Controls.Add(dataGridArtículos);
            panelArtículos.Controls.Add(txtPrecio);
            panelArtículos.Controls.Add(label6);
            panelArtículos.Controls.Add(btnRegistrar);
            panelArtículos.Controls.Add(txtCantidad);
            panelArtículos.Location = new System.Drawing.Point(1, 1);
            panelArtículos.Name = "panelArtículos";
            panelArtículos.Size = new System.Drawing.Size(995, 671);
            panelArtículos.TabIndex = 14;
            // 
            // Articulos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(995, 671);
            Controls.Add(panelArtículos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Articulos";
            Text = "ARTICULOS";
            Resize += Articulos_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            panelArtículos.ResumeLayout(false);
            panelArtículos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComExistencias;
        private System.Windows.Forms.DataGridViewImageColumn btnActualizar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Panel panelArtículos;
    }
}