<<<<<<< HEAD
﻿namespace EduStatsProyecto.Formularios
=======
﻿namespace EduStats.Formularios
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
{
    partial class OlvidarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlvidarFrm));
<<<<<<< HEAD
            this.btnOlvidarVolver = new System.Windows.Forms.Button();
            this.picMenuPrincipalBanner = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalUAM = new System.Windows.Forms.PictureBox();
            this.picMenuPrincipalBackground = new System.Windows.Forms.PictureBox();
            this.pbxOlvidarRecordatorio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalUAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOlvidarRecordatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlvidarVolver
            // 
            this.btnOlvidarVolver.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidarVolver.Location = new System.Drawing.Point(686, 387);
            this.btnOlvidarVolver.Name = "btnOlvidarVolver";
            this.btnOlvidarVolver.Size = new System.Drawing.Size(102, 51);
            this.btnOlvidarVolver.TabIndex = 10;
            this.btnOlvidarVolver.Text = "Volver";
            this.btnOlvidarVolver.UseVisualStyleBackColor = true;
            this.btnOlvidarVolver.Click += new System.EventHandler(this.btnOlvidarVolver_Click);
            // 
            // picMenuPrincipalBanner
            // 
            this.picMenuPrincipalBanner.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalBanner.Image")));
            this.picMenuPrincipalBanner.Location = new System.Drawing.Point(-2, -2);
            this.picMenuPrincipalBanner.Name = "picMenuPrincipalBanner";
            this.picMenuPrincipalBanner.Size = new System.Drawing.Size(804, 44);
            this.picMenuPrincipalBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalBanner.TabIndex = 8;
            this.picMenuPrincipalBanner.TabStop = false;
            // 
            // picMenuPrincipalUAM
            // 
            this.picMenuPrincipalUAM.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalUAM.Image")));
            this.picMenuPrincipalUAM.Location = new System.Drawing.Point(-2, 42);
            this.picMenuPrincipalUAM.Name = "picMenuPrincipalUAM";
            this.picMenuPrincipalUAM.Size = new System.Drawing.Size(804, 44);
            this.picMenuPrincipalUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalUAM.TabIndex = 9;
            this.picMenuPrincipalUAM.TabStop = false;
            // 
            // picMenuPrincipalBackground
            // 
            this.picMenuPrincipalBackground.Image = ((System.Drawing.Image)(resources.GetObject("picMenuPrincipalBackground.Image")));
            this.picMenuPrincipalBackground.Location = new System.Drawing.Point(-2, -2);
            this.picMenuPrincipalBackground.Name = "picMenuPrincipalBackground";
            this.picMenuPrincipalBackground.Size = new System.Drawing.Size(804, 455);
            this.picMenuPrincipalBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuPrincipalBackground.TabIndex = 7;
            this.picMenuPrincipalBackground.TabStop = false;
=======
            this.pbxHeaderOlvidar = new System.Windows.Forms.PictureBox();
            this.pbxBackgroundOlvidar = new System.Windows.Forms.PictureBox();
            this.pbxUAMOlvidar = new System.Windows.Forms.PictureBox();
            this.btnVolverOlvidar = new System.Windows.Forms.Button();
            this.pbxOlvidarRecordatorio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeaderOlvidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundOlvidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUAMOlvidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOlvidarRecordatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxHeaderOlvidar
            // 
            this.pbxHeaderOlvidar.Image = ((System.Drawing.Image)(resources.GetObject("pbxHeaderOlvidar.Image")));
            this.pbxHeaderOlvidar.Location = new System.Drawing.Point(12, 12);
            this.pbxHeaderOlvidar.Name = "pbxHeaderOlvidar";
            this.pbxHeaderOlvidar.Size = new System.Drawing.Size(776, 81);
            this.pbxHeaderOlvidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHeaderOlvidar.TabIndex = 1;
            this.pbxHeaderOlvidar.TabStop = false;
            // 
            // pbxBackgroundOlvidar
            // 
            this.pbxBackgroundOlvidar.Image = ((System.Drawing.Image)(resources.GetObject("pbxBackgroundOlvidar.Image")));
            this.pbxBackgroundOlvidar.Location = new System.Drawing.Point(12, 12);
            this.pbxBackgroundOlvidar.Name = "pbxBackgroundOlvidar";
            this.pbxBackgroundOlvidar.Size = new System.Drawing.Size(776, 426);
            this.pbxBackgroundOlvidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBackgroundOlvidar.TabIndex = 2;
            this.pbxBackgroundOlvidar.TabStop = false;
            // 
            // pbxUAMOlvidar
            // 
            this.pbxUAMOlvidar.Image = ((System.Drawing.Image)(resources.GetObject("pbxUAMOlvidar.Image")));
            this.pbxUAMOlvidar.Location = new System.Drawing.Point(12, 89);
            this.pbxUAMOlvidar.Name = "pbxUAMOlvidar";
            this.pbxUAMOlvidar.Size = new System.Drawing.Size(776, 41);
            this.pbxUAMOlvidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUAMOlvidar.TabIndex = 9;
            this.pbxUAMOlvidar.TabStop = false;
            // 
            // btnVolverOlvidar
            // 
            this.btnVolverOlvidar.Location = new System.Drawing.Point(21, 136);
            this.btnVolverOlvidar.Name = "btnVolverOlvidar";
            this.btnVolverOlvidar.Size = new System.Drawing.Size(93, 35);
            this.btnVolverOlvidar.TabIndex = 7;
            this.btnVolverOlvidar.Text = "Volver";
            this.btnVolverOlvidar.UseVisualStyleBackColor = true;
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            // 
            // pbxOlvidarRecordatorio
            // 
            this.pbxOlvidarRecordatorio.Image = ((System.Drawing.Image)(resources.GetObject("pbxOlvidarRecordatorio.Image")));
<<<<<<< HEAD
            this.pbxOlvidarRecordatorio.Location = new System.Drawing.Point(12, 92);
            this.pbxOlvidarRecordatorio.Name = "pbxOlvidarRecordatorio";
            this.pbxOlvidarRecordatorio.Size = new System.Drawing.Size(610, 346);
            this.pbxOlvidarRecordatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOlvidarRecordatorio.TabIndex = 11;
=======
            this.pbxOlvidarRecordatorio.Location = new System.Drawing.Point(199, 136);
            this.pbxOlvidarRecordatorio.Name = "pbxOlvidarRecordatorio";
            this.pbxOlvidarRecordatorio.Size = new System.Drawing.Size(520, 292);
            this.pbxOlvidarRecordatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxOlvidarRecordatorio.TabIndex = 8;
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            this.pbxOlvidarRecordatorio.TabStop = false;
            // 
            // OlvidarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.btnOlvidarVolver);
            this.Controls.Add(this.picMenuPrincipalBanner);
            this.Controls.Add(this.picMenuPrincipalUAM);
            this.Controls.Add(this.pbxOlvidarRecordatorio);
            this.Controls.Add(this.picMenuPrincipalBackground);
            this.Name = "OlvidarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Como Recuperar Usuario y/o Contraseña - EduStats";
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalUAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuPrincipalBackground)).EndInit();
=======
            this.Controls.Add(this.pbxUAMOlvidar);
            this.Controls.Add(this.pbxOlvidarRecordatorio);
            this.Controls.Add(this.btnVolverOlvidar);
            this.Controls.Add(this.pbxHeaderOlvidar);
            this.Controls.Add(this.pbxBackgroundOlvidar);
            this.Name = "OlvidarFrm";
            this.Text = "OlvidarFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeaderOlvidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackgroundOlvidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUAMOlvidar)).EndInit();
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
            ((System.ComponentModel.ISupportInitialize)(this.pbxOlvidarRecordatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button btnOlvidarVolver;
        private System.Windows.Forms.PictureBox picMenuPrincipalBanner;
        private System.Windows.Forms.PictureBox picMenuPrincipalUAM;
        private System.Windows.Forms.PictureBox picMenuPrincipalBackground;
=======
        private System.Windows.Forms.PictureBox pbxHeaderOlvidar;
        private System.Windows.Forms.PictureBox pbxBackgroundOlvidar;
        private System.Windows.Forms.PictureBox pbxUAMOlvidar;
        private System.Windows.Forms.Button btnVolverOlvidar;
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
        private System.Windows.Forms.PictureBox pbxOlvidarRecordatorio;
    }
}