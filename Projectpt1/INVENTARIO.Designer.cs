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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            label2 = new System.Windows.Forms.Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(296, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(385, 39);
            label2.TabIndex = 3;
            label2.Text = "Inventario de Artículos ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(393, 160);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridArtículos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridArtículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComNombre, ComDescripcion, ComPrecio, ComExistencias });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.Location = new System.Drawing.Point(159, 211);
            dataGridArtículos.Name = "dataGridArtículos";
            dataGridArtículos.RowHeadersWidth = 51;
            dataGridArtículos.Size = new System.Drawing.Size(632, 400);
            dataGridArtículos.TabIndex = 10;
            dataGridArtículos.CellContentClick += dataGridArtículos_CellContentClick;
            // 
            // ComId
            // 
            ComId.HeaderText = "Id";
            ComId.MinimumWidth = 6;
            ComId.Name = "ComId";
            ComId.Width = 125;
            // 
            // ComNombre
            // 
            ComNombre.HeaderText = "Nombre";
            ComNombre.MinimumWidth = 6;
            ComNombre.Name = "ComNombre";
            ComNombre.Width = 125;
            // 
            // ComDescripcion
            // 
            ComDescripcion.HeaderText = "Descripcion";
            ComDescripcion.MinimumWidth = 6;
            ComDescripcion.Name = "ComDescripcion";
            ComDescripcion.Width = 125;
            // 
            // ComPrecio
            // 
            ComPrecio.HeaderText = "Precio";
            ComPrecio.MinimumWidth = 6;
            ComPrecio.Name = "ComPrecio";
            ComPrecio.Width = 125;
            // 
            // ComExistencias
            // 
            ComExistencias.HeaderText = "Existencias";
            ComExistencias.MinimumWidth = 6;
            ComExistencias.Name = "ComExistencias";
            ComExistencias.Width = 125;
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
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Inventario";
            Text = "INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
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