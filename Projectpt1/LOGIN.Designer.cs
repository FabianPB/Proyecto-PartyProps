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
            btnLogin = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.PictureBox();
            btnMinimizar = new System.Windows.Forms.PictureBox();
            logo = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 227, 234);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(381, 494);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(40, 86);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(298, 284);
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
            txtUsuario.Location = new System.Drawing.Point(556, 274);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(301, 18);
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
            txtContraseña.Location = new System.Drawing.Point(556, 308);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new System.Drawing.Size(301, 18);
            txtContraseña.TabIndex = 2;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
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
            btnLogin.Location = new System.Drawing.Point(556, 364);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(301, 48);
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
            btnCerrar.Location = new System.Drawing.Point(997, 11);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(24, 22);
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
            btnMinimizar.Location = new System.Drawing.Point(967, 11);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(24, 22);
            btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 6;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // logo
            // 
            logo.Image = (System.Drawing.Image)resources.GetObject("logo.Image");
            logo.Location = new System.Drawing.Point(600, 46);
            logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new System.Drawing.Size(213, 210);
            logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            logo.TabIndex = 7;
            logo.TabStop = false;
            logo.MouseDown += logo_MouseDown;
            // 
            // LOGIN
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1032, 494);
            Controls.Add(logo);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "LOGIN";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += LOGIN_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
    }
}

