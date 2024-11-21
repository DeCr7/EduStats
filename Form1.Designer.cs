namespace EduStats
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxBackgroundMainPage = new System.Windows.Forms.PictureBox();
            this.pbxHeaderMainPage = new System.Windows.Forms.PictureBox();
            this.gpbInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnOlvidar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbxUAMMainPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundMainPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeaderMainPage)).BeginInit();
            this.gpbInformacionUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUAMMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBackgroundMainPage
            // 
            this.pbxBackgroundMainPage.Image = ((System.Drawing.Image)(resources.GetObject("pbxBackgroundMainPage.Image")));
            this.pbxBackgroundMainPage.Location = new System.Drawing.Point(12, 12);
            this.pbxBackgroundMainPage.Name = "pbxBackgroundMainPage";
            this.pbxBackgroundMainPage.Size = new System.Drawing.Size(776, 426);
            this.pbxBackgroundMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBackgroundMainPage.TabIndex = 0;
            this.pbxBackgroundMainPage.TabStop = false;
            // 
            // pbxHeaderMainPage
            // 
            this.pbxHeaderMainPage.Image = ((System.Drawing.Image)(resources.GetObject("pbxHeaderMainPage.Image")));
            this.pbxHeaderMainPage.Location = new System.Drawing.Point(12, 12);
            this.pbxHeaderMainPage.Name = "pbxHeaderMainPage";
            this.pbxHeaderMainPage.Size = new System.Drawing.Size(776, 81);
            this.pbxHeaderMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHeaderMainPage.TabIndex = 0;
            this.pbxHeaderMainPage.TabStop = false;
            // 
            // gpbInformacionUsuario
            // 
            this.gpbInformacionUsuario.Controls.Add(this.btnOlvidar);
            this.gpbInformacionUsuario.Controls.Add(this.btnEntrar);
            this.gpbInformacionUsuario.Controls.Add(this.txtClave);
            this.gpbInformacionUsuario.Controls.Add(this.lblClave);
            this.gpbInformacionUsuario.Controls.Add(this.txtUsuario);
            this.gpbInformacionUsuario.Controls.Add(this.lblUsuario);
            this.gpbInformacionUsuario.Location = new System.Drawing.Point(172, 161);
            this.gpbInformacionUsuario.Name = "gpbInformacionUsuario";
            this.gpbInformacionUsuario.Size = new System.Drawing.Size(461, 187);
            this.gpbInformacionUsuario.TabIndex = 1;
            this.gpbInformacionUsuario.TabStop = false;
            this.gpbInformacionUsuario.Text = "Información de Usuario";
            // 
            // btnOlvidar
            // 
            this.btnOlvidar.Location = new System.Drawing.Point(9, 146);
            this.btnOlvidar.Name = "btnOlvidar";
            this.btnOlvidar.Size = new System.Drawing.Size(93, 35);
            this.btnOlvidar.TabIndex = 5;
            this.btnOlvidar.Text = "¿Olvidó su usuario o clave?";
            this.btnOlvidar.UseVisualStyleBackColor = true;
            this.btnOlvidar.Click += new System.EventHandler(this.btnOlvidar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(364, 146);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(91, 35);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(9, 102);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(446, 20);
            this.txtClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(6, 86);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(446, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbxUAMMainPage
            // 
            this.pbxUAMMainPage.Image = ((System.Drawing.Image)(resources.GetObject("pbxUAMMainPage.Image")));
            this.pbxUAMMainPage.Location = new System.Drawing.Point(12, 90);
            this.pbxUAMMainPage.Name = "pbxUAMMainPage";
            this.pbxUAMMainPage.Size = new System.Drawing.Size(776, 41);
            this.pbxUAMMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUAMMainPage.TabIndex = 7;
            this.pbxUAMMainPage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxUAMMainPage);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbInformacionUsuario);
            this.Controls.Add(this.pbxHeaderMainPage);
            this.Controls.Add(this.pbxBackgroundMainPage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundMainPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeaderMainPage)).EndInit();
            this.gpbInformacionUsuario.ResumeLayout(false);
            this.gpbInformacionUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUAMMainPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBackgroundMainPage;
        private System.Windows.Forms.PictureBox pbxHeaderMainPage;
        private System.Windows.Forms.GroupBox gpbInformacionUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnOlvidar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbxUAMMainPage;
    }
}

