namespace Presentacion
{
    partial class Reservas
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
            ListaArticulos = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            btnRegistrar = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // ListaArticulos
            // 
            ListaArticulos.FormattingEnabled = true;
            ListaArticulos.Location = new System.Drawing.Point(637, 177);
            ListaArticulos.Name = "ListaArticulos";
            ListaArticulos.Size = new System.Drawing.Size(312, 484);
            ListaArticulos.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(309, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(358, 39);
            label2.TabIndex = 3;
            label2.Text = "Reservas de Artículos";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(317, 252);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(257, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(136, 252);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 21);
            label1.TabIndex = 5;
            label1.Text = "Fecha de Alquiler:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(101, 335);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(194, 21);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Devolución:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(317, 335);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(257, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(307, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(200, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(193, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 21);
            label4.TabIndex = 9;
            label4.Text = "ID Factura :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(184, 428);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 21);
            label5.TabIndex = 10;
            label5.Text = "Precio Total :";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(307, 429);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(200, 27);
            textBox2.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.Lime;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = System.Drawing.Color.Black;
            btnRegistrar.Location = new System.Drawing.Point(403, 560);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(127, 49);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(245, 560);
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
            label6.Location = new System.Drawing.Point(741, 138);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 27);
            label6.TabIndex = 14;
            label6.Text = "Artículos";
            // 
            // Reservas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1017, 718);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(btnRegistrar);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(ListaArticulos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Reservas";
            Text = "RESERVAS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ListaArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}