namespace EduStatsProyecto.Formularios
{
    partial class UsuariosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosFrm));
            this.btnMenuOpcionesVolver = new System.Windows.Forms.Button();
            this.picMenuOpcionesBanner = new System.Windows.Forms.PictureBox();
            this.picMenuOpcionesUAM = new System.Windows.Forms.PictureBox();
            this.picMenuOpcionesBackground = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEstadoUsuarios = new System.Windows.Forms.TabPage();
            this.btnActualizarUsuarios = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnGuardarUsuarios = new System.Windows.Forms.Button();
            this.txtClaveUsuarios = new System.Windows.Forms.TextBox();
            this.lblClaveUsuarios = new System.Windows.Forms.Label();
            this.txtUsuarioUsuarios = new System.Windows.Forms.TextBox();
            this.lblUsuarioUsuarios = new System.Windows.Forms.Label();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.tabTablaUsuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesUAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesBackground)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEstadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.tabTablaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuOpcionesVolver
            // 
            this.btnMenuOpcionesVolver.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOpcionesVolver.Location = new System.Drawing.Point(686, 387);
            this.btnMenuOpcionesVolver.Name = "btnMenuOpcionesVolver";
            this.btnMenuOpcionesVolver.Size = new System.Drawing.Size(102, 51);
            this.btnMenuOpcionesVolver.TabIndex = 14;
            this.btnMenuOpcionesVolver.Text = "Volver";
            this.btnMenuOpcionesVolver.UseVisualStyleBackColor = true;
            this.btnMenuOpcionesVolver.Click += new System.EventHandler(this.btnMenuOpcionesVolver_Click);
            // 
            // picMenuOpcionesBanner
            // 
            this.picMenuOpcionesBanner.Image = ((System.Drawing.Image)(resources.GetObject("picMenuOpcionesBanner.Image")));
            this.picMenuOpcionesBanner.Location = new System.Drawing.Point(-2, -2);
            this.picMenuOpcionesBanner.Name = "picMenuOpcionesBanner";
            this.picMenuOpcionesBanner.Size = new System.Drawing.Size(804, 44);
            this.picMenuOpcionesBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuOpcionesBanner.TabIndex = 12;
            this.picMenuOpcionesBanner.TabStop = false;
            // 
            // picMenuOpcionesUAM
            // 
            this.picMenuOpcionesUAM.Image = ((System.Drawing.Image)(resources.GetObject("picMenuOpcionesUAM.Image")));
            this.picMenuOpcionesUAM.Location = new System.Drawing.Point(-2, 42);
            this.picMenuOpcionesUAM.Name = "picMenuOpcionesUAM";
            this.picMenuOpcionesUAM.Size = new System.Drawing.Size(804, 44);
            this.picMenuOpcionesUAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuOpcionesUAM.TabIndex = 13;
            this.picMenuOpcionesUAM.TabStop = false;
            // 
            // picMenuOpcionesBackground
            // 
            this.picMenuOpcionesBackground.Image = ((System.Drawing.Image)(resources.GetObject("picMenuOpcionesBackground.Image")));
            this.picMenuOpcionesBackground.Location = new System.Drawing.Point(-2, -2);
            this.picMenuOpcionesBackground.Name = "picMenuOpcionesBackground";
            this.picMenuOpcionesBackground.Size = new System.Drawing.Size(804, 455);
            this.picMenuOpcionesBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuOpcionesBackground.TabIndex = 11;
            this.picMenuOpcionesBackground.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEstadoUsuarios);
            this.tabControl1.Controls.Add(this.tabTablaUsuarios);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 346);
            this.tabControl1.TabIndex = 17;
            // 
            // tabEstadoUsuarios
            // 
            this.tabEstadoUsuarios.Controls.Add(this.btnActualizarUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.btnEliminarUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.btnGuardarUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.txtClaveUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.lblClaveUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.txtUsuarioUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.lblUsuarioUsuarios);
            this.tabEstadoUsuarios.Controls.Add(this.picBackground);
            this.tabEstadoUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabEstadoUsuarios.Name = "tabEstadoUsuarios";
            this.tabEstadoUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadoUsuarios.Size = new System.Drawing.Size(602, 320);
            this.tabEstadoUsuarios.TabIndex = 0;
            this.tabEstadoUsuarios.Text = "Estado de Usuarios";
            this.tabEstadoUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnActualizarUsuarios
            // 
            this.btnActualizarUsuarios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarUsuarios.Location = new System.Drawing.Point(405, 177);
            this.btnActualizarUsuarios.Name = "btnActualizarUsuarios";
            this.btnActualizarUsuarios.Size = new System.Drawing.Size(190, 69);
            this.btnActualizarUsuarios.TabIndex = 20;
            this.btnActualizarUsuarios.Text = "Actualizar";
            this.btnActualizarUsuarios.UseVisualStyleBackColor = true;
            this.btnActualizarUsuarios.Click += new System.EventHandler(this.btnActualizarUsuarios_Click);
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(207, 177);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(190, 69);
            this.btnEliminarUsuarios.TabIndex = 19;
            this.btnEliminarUsuarios.Text = "Eliminar";
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            this.btnEliminarUsuarios.Click += new System.EventHandler(this.btnEliminarUsuarios_Click);
            // 
            // btnGuardarUsuarios
            // 
            this.btnGuardarUsuarios.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuarios.Location = new System.Drawing.Point(9, 177);
            this.btnGuardarUsuarios.Name = "btnGuardarUsuarios";
            this.btnGuardarUsuarios.Size = new System.Drawing.Size(190, 69);
            this.btnGuardarUsuarios.TabIndex = 18;
            this.btnGuardarUsuarios.Text = "Guardar";
            this.btnGuardarUsuarios.UseVisualStyleBackColor = true;
            this.btnGuardarUsuarios.Click += new System.EventHandler(this.btnGuardarUsuarios_Click);
            // 
            // txtClaveUsuarios
            // 
            this.txtClaveUsuarios.Location = new System.Drawing.Point(9, 129);
            this.txtClaveUsuarios.Name = "txtClaveUsuarios";
            this.txtClaveUsuarios.Size = new System.Drawing.Size(586, 20);
            this.txtClaveUsuarios.TabIndex = 5;
            // 
            // lblClaveUsuarios
            // 
            this.lblClaveUsuarios.AutoSize = true;
            this.lblClaveUsuarios.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveUsuarios.Location = new System.Drawing.Point(6, 110);
            this.lblClaveUsuarios.Name = "lblClaveUsuarios";
            this.lblClaveUsuarios.Size = new System.Drawing.Size(45, 16);
            this.lblClaveUsuarios.TabIndex = 4;
            this.lblClaveUsuarios.Text = "Clave:";
            // 
            // txtUsuarioUsuarios
            // 
            this.txtUsuarioUsuarios.Location = new System.Drawing.Point(9, 67);
            this.txtUsuarioUsuarios.Name = "txtUsuarioUsuarios";
            this.txtUsuarioUsuarios.Size = new System.Drawing.Size(586, 20);
            this.txtUsuarioUsuarios.TabIndex = 3;
            // 
            // lblUsuarioUsuarios
            // 
            this.lblUsuarioUsuarios.AutoSize = true;
            this.lblUsuarioUsuarios.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioUsuarios.Location = new System.Drawing.Point(6, 48);
            this.lblUsuarioUsuarios.Name = "lblUsuarioUsuarios";
            this.lblUsuarioUsuarios.Size = new System.Drawing.Size(60, 16);
            this.lblUsuarioUsuarios.TabIndex = 2;
            this.lblUsuarioUsuarios.Text = "Usuario:";
            // 
            // picBackground
            // 
            this.picBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBackground.BackgroundImage")));
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(602, 320);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 1;
            this.picBackground.TabStop = false;
            // 
            // tabTablaUsuarios
            // 
            this.tabTablaUsuarios.Controls.Add(this.dgvUsuarios);
            this.tabTablaUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabTablaUsuarios.Name = "tabTablaUsuarios";
            this.tabTablaUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabTablaUsuarios.Size = new System.Drawing.Size(602, 320);
            this.tabTablaUsuarios.TabIndex = 1;
            this.tabTablaUsuarios.Text = "Tabla de Usuarios";
            this.tabTablaUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(602, 320);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // UsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuOpcionesVolver);
            this.Controls.Add(this.picMenuOpcionesBanner);
            this.Controls.Add(this.picMenuOpcionesUAM);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.picMenuOpcionesBackground);
            this.Name = "UsuariosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosFrm";
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesUAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuOpcionesBackground)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEstadoUsuarios.ResumeLayout(false);
            this.tabEstadoUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.tabTablaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuOpcionesVolver;
        private System.Windows.Forms.PictureBox picMenuOpcionesBanner;
        private System.Windows.Forms.PictureBox picMenuOpcionesUAM;
        private System.Windows.Forms.PictureBox picMenuOpcionesBackground;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEstadoUsuarios;
        private System.Windows.Forms.TabPage tabTablaUsuarios;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblUsuarioUsuarios;
        private System.Windows.Forms.TextBox txtClaveUsuarios;
        private System.Windows.Forms.Label lblClaveUsuarios;
        private System.Windows.Forms.TextBox txtUsuarioUsuarios;
        private System.Windows.Forms.Button btnActualizarUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnGuardarUsuarios;
    }
}