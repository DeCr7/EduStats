<<<<<<< HEAD
﻿using EduStatsProyecto.Clases;
using EduStatsProyecto.Formularios;
using System;
=======
﻿using System;
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

namespace EduStatsProyecto
{
    public partial class MenuPrincipalFrm : Form
    {
        public static bool validarBoton = false;
        public MenuPrincipalFrm()
        {
            InitializeComponent();
            PersonalBibliotecario.CargarDatos("usuarios.dat");
=======
using EduStats.Formularios;

namespace EduStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlvidar_Click(object sender, EventArgs e)
        {
            OlvidarFrm frm = new OlvidarFrm();
            frm.Show();
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Application.Exit();
        }

        private void picMenuPrincipalUAM_Click(object sender, EventArgs e)
        {

        }

        private void picMenuPrincipalBanner_Click(object sender, EventArgs e)
        {

        }

        private void picMenuPrincipalBackground_Click(object sender, EventArgs e)
        {

        }

        private void btnOlvidarUsuarioClave_Click(object sender, EventArgs e)
        {
            OlvidarFrm frm = new OlvidarFrm();
            frm.Show();
            this.Hide();
            LimpiarCampos();
        }
        private bool ValidarUsuario()
        {
            bool validado = false;
            for (int i = 0; i < PersonalBibliotecario.personal.Count; i++)
            {
                if (PersonalBibliotecario.personal[i].Usuario == txtUsuario.Text &&
                    PersonalBibliotecario.personal[i].Clave == txtClave.Text)
                {
                    validado = true;
                    break;
                }
            }
            return validado;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == Constantes.usuarioMaestro && txtClave.Text == Constantes.claveMaestra)
            {
                validarBoton = true;
                OpcionesFrm frm = new OpcionesFrm();
                frm.Show();
                this.Hide();
                LimpiarCampos();
            }
            else if (ValidarUsuario())
            {
                validarBoton = false;
                OpcionesFrm frm = new OpcionesFrm();
                frm.Show();
                this.Hide();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El usuario o clave no son válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }
    }
}
=======
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            OpcionesFrm frm = new OpcionesFrm();
            frm.Show();
        }
    }
}
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
