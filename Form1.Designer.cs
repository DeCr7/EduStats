<<<<<<< HEAD
﻿namespace EduStatsProyecto
{
    partial class MenuPrincipalFrm
=======
﻿namespace EduStats
{
    partial class Form1
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalFrm));
            this.picMenuPrincipalBackground = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalBanner = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalUAM = new System.Windows.Forms.PictureBox();
            this.grpInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnOlvidarUsuarioClave = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbxBackgroundMainPage = new System.Windows.Forms.PictureBox();
            this.pbxHeaderMainPage = new System.Windows.Forms.PictureBox();
            this.gpbInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnOlvidar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
<<<<<<< HEAD
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
=======
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
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.txtClave.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
<<<<<<< HEAD
            this.lblClave.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(15, 111);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(48, 18);
=======
            this.lblClave.Location = new System.Drawing.Point(6, 86);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave:";
            // 
            // txtUsuario
            // 
<<<<<<< HEAD
            this.txtUsuario.Location = new System.Drawing.Point(18, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(444, 26);
=======
            this.txtUsuario.Location = new System.Drawing.Point(9, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(446, 20);
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
<<<<<<< HEAD
            this.lblUsuario.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 18);
=======
            this.lblUsuario.Location = new System.Drawing.Point(6, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnSalir
            // 
<<<<<<< HEAD
            this.btnSalir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(686, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 51);
=======
            this.btnSalir.Location = new System.Drawing.Point(25, 161);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 35);
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
<<<<<<< HEAD
            // MenuPrincipalFrm
=======
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
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
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
=======
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
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
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
=======
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
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
    }
}

