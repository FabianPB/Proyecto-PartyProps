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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGENDAR));
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnRegistrar = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            dataGridArtículos = new System.Windows.Forms.DataGridView();
            ComId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ComExistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNombreCliente = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            panelAgendar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelAgendar.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            dateTimePicker1.Location = new System.Drawing.Point(45, 417);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(185, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(63, 384);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 21);
            label1.TabIndex = 5;
            label1.Text = "Fecha de Alquiler:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(45, 467);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(194, 21);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Devolución:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            dateTimePicker2.Location = new System.Drawing.Point(45, 495);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(185, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox1.Location = new System.Drawing.Point(45, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(185, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(77, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 21);
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
            btnRegistrar.Location = new System.Drawing.Point(616, 607);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(127, 49);
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
            button2.Location = new System.Drawing.Point(482, 607);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(127, 49);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(499, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(210, 27);
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
            dataGridArtículos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ComId, ComNombre, ComCategoria, ComDescripcion, ComPrecio, ComExistencias });
            dataGridArtículos.EnableHeadersVisualStyles = false;
            dataGridArtículos.GridColor = System.Drawing.Color.Black;
            dataGridArtículos.Location = new System.Drawing.Point(265, 196);
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
            dataGridArtículos.Size = new System.Drawing.Size(733, 379);
            dataGridArtículos.TabIndex = 15;
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
            // ComCategoria
            // 
            ComCategoria.HeaderText = "Categoría";
            ComCategoria.MinimumWidth = 6;
            ComCategoria.Name = "ComCategoria";
            ComCategoria.Width = 112;
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
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label5);
            panel1.Location = new System.Drawing.Point(45, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(919, 63);
            panel1.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(22, 12);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(289, 39);
            label5.TabIndex = 2;
            label5.Text = "Agendar Pedido.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(63, 285);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(151, 21);
            label2.TabIndex = 18;
            label2.Text = "Nombre Cliente :";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtNombreCliente.Location = new System.Drawing.Point(45, 313);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new System.Drawing.Size(185, 27);
            txtNombreCliente.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            label8.Location = new System.Drawing.Point(265, 156);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 23);
            label8.TabIndex = 20;
            label8.Text = "ID Artículo:";
            // 
            // textBox2
            // 
            textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox2.Location = new System.Drawing.Point(349, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(82, 27);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(890, 136);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(53, 53);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            label7.Location = new System.Drawing.Point(439, 160);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 23);
            label7.TabIndex = 23;
            label7.Text = "Artículo :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            label9.Location = new System.Drawing.Point(717, 156);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(83, 23);
            label9.TabIndex = 24;
            label9.Text = "Cantidad:";
            // 
            // textBox4
            // 
            textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox4.Location = new System.Drawing.Point(801, 155);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(82, 27);
            textBox4.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            label10.Location = new System.Drawing.Point(573, 160);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(93, 23);
            label10.TabIndex = 27;
            label10.Text = "Valor C/U :";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label11);
            panel2.Location = new System.Drawing.Point(45, 549);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(185, 152);
            panel2.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(32, 25);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(134, 27);
            label11.TabIndex = 29;
            label11.Text = "Saldo Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Black;
            label12.Location = new System.Drawing.Point(84, 209);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(82, 21);
            label12.TabIndex = 29;
            label12.Text = "Cedula :";
            // 
            // textBox3
            // 
            textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox3.Location = new System.Drawing.Point(45, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(185, 27);
            textBox3.TabIndex = 30;
            // 
            // panelAgendar
            // 
            panelAgendar.BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            panelAgendar.Controls.Add(panel1);
            panelAgendar.Controls.Add(dateTimePicker1);
            panelAgendar.Controls.Add(label1);
            panelAgendar.Controls.Add(textBox3);
            panelAgendar.Controls.Add(label3);
            panelAgendar.Controls.Add(label12);
            panelAgendar.Controls.Add(dateTimePicker2);
            panelAgendar.Controls.Add(panel2);
            panelAgendar.Controls.Add(textBox1);
            panelAgendar.Controls.Add(label10);
            panelAgendar.Controls.Add(label4);
            panelAgendar.Controls.Add(textBox4);
            panelAgendar.Controls.Add(btnRegistrar);
            panelAgendar.Controls.Add(label9);
            panelAgendar.Controls.Add(button2);
            panelAgendar.Controls.Add(label7);
            panelAgendar.Controls.Add(label6);
            panelAgendar.Controls.Add(pictureBox1);
            panelAgendar.Controls.Add(dataGridArtículos);
            panelAgendar.Controls.Add(label8);
            panelAgendar.Controls.Add(txtNombreCliente);
            panelAgendar.Controls.Add(textBox2);
            panelAgendar.Controls.Add(label2);
            panelAgendar.Location = new System.Drawing.Point(0, 0);
            panelAgendar.Name = "panelAgendar";
            panelAgendar.Size = new System.Drawing.Size(1016, 717);
            panelAgendar.TabIndex = 31;
            // 
            // AGENDAR
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            ClientSize = new System.Drawing.Size(1017, 717);
            Controls.Add(panelAgendar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AGENDAR";
            Text = "RESERVAS";
            Load += AGENDAR_Load;
            Resize += AGENDAR_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridArtículos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelAgendar.ResumeLayout(false);
            panelAgendar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridArtículos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComExistencias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelAgendar;
    }
}