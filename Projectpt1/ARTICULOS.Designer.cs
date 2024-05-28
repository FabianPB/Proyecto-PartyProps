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
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Txt_Id
            // 
            Txt_Id.Location = new System.Drawing.Point(202, 181);
            Txt_Id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Txt_Id.Name = "Txt_Id";
            Txt_Id.Size = new System.Drawing.Size(170, 27);
            Txt_Id.TabIndex = 0;
            Txt_Id.TextChanged += Txt_Id_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(158, 180);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 21);
            label1.TabIndex = 1;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(313, 47);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(343, 39);
            label2.TabIndex = 2;
            label2.Text = "Registro de Artículos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(555, 180);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 21);
            label3.TabIndex = 3;
            label3.Text = "Nombre :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(649, 179);
            txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(169, 27);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(79, 288);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 21);
            label4.TabIndex = 5;
            label4.Text = "Descripción :";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(202, 287);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(170, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(479, 289);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(164, 21);
            label5.TabIndex = 7;
            label5.Text = "Precio de Alquiler :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new System.Drawing.Point(649, 289);
            txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(169, 27);
            txtPrecio.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(94, 408);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 21);
            label6.TabIndex = 9;
            label6.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(202, 407);
            txtCantidad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(170, 27);
            txtCantidad.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.Lime;
            btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.Black;
            btnRegistrar.Location = new System.Drawing.Point(649, 504);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(127, 49);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.Red;
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.Black;
            btnCancelar.Location = new System.Drawing.Point(498, 504);
            btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(127, 49);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Articulos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(904, 639);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCantidad);
            Controls.Add(label6);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txt_Id);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Articulos";
            Text = "ARTICULOS";
            Load += Articulos_Load;
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
        private System.Windows.Forms.Button btnCancelar;
    }
}