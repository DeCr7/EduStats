namespace EduStatsProyecto
{
    partial class MenuPrincipalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalFrm));
            this.picMenuPrincipalBackground = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalBanner = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalUAM = new System.Windows.Forms.PictureBox();
            this.grpInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnOlvidarUsuarioClave = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalUAM)).BeginInit();
            this.grpInformacionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMenuPrincipalBackground
            // 
            this.picMenuPrincipalBackground.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalBackground.Image")));
            this.picMenuPrincipalBackground.Location = new System.Drawing.Point(-2, -1);
            this.picMenuPrincipalBackground.Name = "picMenuPrincipalBackground";
            this.picMenuPrincipalBackground.Size = new System.Drawing.Size(804, 455);
            this.picMenuPrincipalBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalBackground.TabIndex = 0;
            this.picMenuPrincipalBackground.TabStop = false;
            this.picMenuPrincipalBackground.Click += new System.EventHandler(this.picMenuPrincipalBackground_Click);
            // 
            // picMenuPrincipalBanner
            // 
            this.picMenuPrincipalBanner.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalBanner.Image")));
            this.picMenuPrincipalBanner.Location = new System.Drawing.Point(-2, -1);
            this.picMenuPrincipalBanner.Name = "picMenuPrincipalBanner";
            this.picMenuPrincipalBanner.Size = new System.Drawing.Size(804, 44);
            this.picMenuPrincipalBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalBanner.TabIndex = 1;
            this.picMenuPrincipalBanner.TabStop = false;
            this.picMenuPrincipalBanner.Click += new System.EventHandler(this.picMenuPrincipalBanner_Click);
            // 
            // picMenuPrincipalUAM
            // 
            this.picMenuPrincipalUAM.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalUAM.Image")));
            this.picMenuPrincipalUAM.Location = new System.Drawing.Point(-2, 43);
            this.picMenuPrincipalUAM.Name = "picMenuPrincipalUAM";
            this.picMenuPrincipalUAM.Size = new System.Drawing.Size(804, 44);
            this.picMenuPrincipalUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalUAM.TabIndex = 2;
            this.picMenuPrincipalUAM.TabStop = false;
            this.picMenuPrincipalUAM.Click += new System.EventHandler(this.picMenuPrincipalUAM_Click);
            // 
            // grpInformacionUsuario
            // 
            this.grpInformacionUsuario.Controls.Add(this.btnOlvidarUsuarioClave);
            this.grpInformacionUsuario.Controls.Add(this.btnIngresar);
            this.grpInformacionUsuario.Controls.Add(this.txtClave);
            this.grpInformacionUsuario.Controls.Add(this.lblClave);
            this.grpInformacionUsuario.Controls.Add(this.txtUsuario);
            this.grpInformacionUsuario.Controls.Add(this.lblUsuario);
            this.grpInformacionUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacionUsuario.Location = new System.Drawing.Point(175, 93);
            this.grpInformacionUsuario.Name = "grpInformacionUsuario";
            this.grpInformacionUsuario.Size = new System.Drawing.Size(481, 268);
            this.grpInformacionUsuario.TabIndex = 0;
            this.grpInformacionUsuario.TabStop = false;
            this.grpInformacionUsuario.Text = "Información de Usuario";
            // 
            // btnOlvidarUsuarioClave
            // 
            this.btnOlvidarUsuarioClave.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidarUsuarioClave.Location = new System.Drawing.Point(18, 204);
            this.btnOlvidarUsuarioClave.Name = "btnOlvidarUsuarioClave";
            this.btnOlvidarUsuarioClave.Size = new System.Drawing.Size(102, 51);
            this.btnOlvidarUsuarioClave.TabIndex = 5;
            this.btnOlvidarUsuarioClave.Text = "¿Olvidó el usuario o clave?";
            this.btnOlvidarUsuarioClave.UseVisualStyleBackColor = true;
            this.btnOlvidarUsuarioClave.Click += new System.EventHandler(this.btnOlvidarUsuarioClave_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(360, 202);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 51);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(18, 133);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(444, 26);
            this.txtClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(15, 111);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(48, 18);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(18, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(444, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(686, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 51);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuPrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpInformacionUsuario);
            this.Controls.Add(this.picMenuPrincipalBanner);
            this.Controls.Add(this.picMenuPrincipalUAM);
            this.Controls.Add(this.picMenuPrincipalBackground);
            this.Name = "MenuPrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - EduStats";
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalUAM)).EndInit();
            this.grpInformacionUsuario.ResumeLayout(false);
            this.grpInformacionUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenuPrincipalBackground;
        private System.Windows.Forms.PictureBox picMenuPrincipalBanner;
        private System.Windows.Forms.PictureBox picMenuPrincipalUAM;
        private System.Windows.Forms.GroupBox grpInformacionUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOlvidarUsuarioClave;
        private System.Windows.Forms.Button btnSalir;
    }
}

