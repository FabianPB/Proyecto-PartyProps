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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            dataGridReservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReservas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(208, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(555, 39);
            label2.TabIndex = 3;
            label2.Text = "Inventario de Artículos y Reservas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(196, 177);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(199, 27);
            label1.TabIndex = 6;
            label1.Text = "Lista de Artículos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(611, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(200, 27);
            label3.TabIndex = 7;
            label3.Text = "Lista de Reservas";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.Location = new System.Drawing.Point(512, 648);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(113, 63);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
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
            dataGridArtículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridArtículos.Location = new System.Drawing.Point(151, 217);
            dataGridArtículos.Name = "dataGridArtículos";
            dataGridArtículos.RowHeadersWidth = 51;
            dataGridArtículos.Size = new System.Drawing.Size(300, 400);
            dataGridArtículos.TabIndex = 10;
            // 
            // dataGridReservas
            // 
            dataGridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReservas.Location = new System.Drawing.Point(563, 217);
            dataGridReservas.Name = "dataGridReservas";
            dataGridReservas.RowHeadersWidth = 51;
            dataGridReservas.Size = new System.Drawing.Size(300, 400);
            dataGridReservas.TabIndex = 11;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1011, 740);
            Controls.Add(dataGridReservas);
            Controls.Add(dataGridArtículos);
            Controls.Add(btnActualizar);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Inventario";
            Text = "INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.DataGridView dataGridReservas;
    }
}