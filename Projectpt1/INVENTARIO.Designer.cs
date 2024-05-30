namespace Presentacion
{
    partial class Inventario
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
            label1 = new System.Windows.Forms.Label();
            btnEliminar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(115, 181);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(199, 27);
            label1.TabIndex = 6;
            label1.Text = "Lista de Artículos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = System.Drawing.Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnEliminar.Location = new System.Drawing.Point(512, 648);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(113, 63);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = System.Drawing.Color.Lime;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnActualizar.Location = new System.Drawing.Point(375, 648);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(113, 63);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dataGridArtículos
            // 
            dataGridArtículos.AllowUserToAddRows = false;
            dataGridArtículos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridArtículos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridArtículos.BackgroundColor = System.Drawing.Color.White;
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
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComNombre, ComDescripcion, ComPrecio, ComExistencias });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(115, 211);
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
            dataGridArtículos.Size = new System.Drawing.Size(777, 400);
            dataGridArtículos.TabIndex = 10;
            dataGridArtículos.CellContentClick += dataGridArtículos_CellContentClick;
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
            // Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1011, 740);
            Controls.Add(dataGridArtículos);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Inventario";
            Text = "INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComExistencias;
    }
}