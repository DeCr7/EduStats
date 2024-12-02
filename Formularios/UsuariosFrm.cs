using EduStatsProyecto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduStatsProyecto.Formularios
{
    public partial class UsuariosFrm : Form
    {
        public UsuariosFrm()
        {
            InitializeComponent();
            PersonalBibliotecario.CargarDatos("usuarios.dat");
            ActualizarDataGridView();
        }

        private void btnGuardarUsuarios_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtUsuarioUsuarios.Text;
            string nuevaClave = txtClaveUsuarios.Text;

            PersonalBibliotecario.personal.Add(new PersonalBibliotecario(nuevoUsuario, nuevaClave));
            PersonalBibliotecario.GuardarDatos("usuarios.dat");
            ActualizarDataGridView();
            LimpiarCampos();
        }
        private void ActualizarDataGridView()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = PersonalBibliotecario.personal;
        }
        private void LimpiarCampos()
        {
            txtUsuarioUsuarios.Clear();
            txtClaveUsuarios.Clear();
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            int i = dgvUsuarios.CurrentCell.RowIndex;
            PersonalBibliotecario.personal.RemoveAt(i);
            PersonalBibliotecario.GuardarDatos("usuarios.dat");
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private void btnActualizarUsuarios_Click(object sender, EventArgs e)
        {
            int i = dgvUsuarios.CurrentCell.RowIndex;

            PersonalBibliotecario.personal[i].Usuario = txtUsuarioUsuarios.Text;
            PersonalBibliotecario.personal[i].Clave = txtClaveUsuarios.Text;

            PersonalBibliotecario.GuardarDatos("usuarios.dat");
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private void btnMenuOpcionesVolver_Click(object sender, EventArgs e)
        {
            OpcionesFrm frm = new OpcionesFrm();
            frm.Show();
            this.Hide();
            LimpiarCampos();
        }
    }
}