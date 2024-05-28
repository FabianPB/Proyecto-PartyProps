namespace Presentacion
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtContraseña = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.PictureBox();
            btnMinimizar = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(435, 659);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(46, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(340, 379);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = System.Drawing.Color.White;
            txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtUsuario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = System.Drawing.Color.DimGray;
            txtUsuario.Location = new System.Drawing.Point(636, 348);
            txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(344, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = System.Drawing.Color.White;
            txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtContraseña.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            txtContraseña.Location = new System.Drawing.Point(636, 395);
            txtContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new System.Drawing.Size(344, 23);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(646, 258);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 34);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.Black;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(636, 485);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(344, 64);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.White;
            btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCerrar.Image = (System.Drawing.Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new System.Drawing.Point(1139, 15);
            btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(28, 30);
            btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 5;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = System.Drawing.Color.White;
            btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinimizar.Image = (System.Drawing.Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new System.Drawing.Point(1105, 15);
            btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(28, 30);
            btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(688, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(243, 280);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // LOGIN
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1179, 659);
            Controls.Add(pictureBox2);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LOGIN";
            Text = "Form1";
            MouseDown += LOGIN_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

