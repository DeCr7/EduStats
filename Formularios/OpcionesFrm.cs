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
    public partial class OpcionesFrm : Form
    {
        public OpcionesFrm()
        {
            InitializeComponent();

            if (MenuPrincipalFrm.validarBoton)
            {
                btnMenuUsuarios.Visible = true;
            }
            else
            {
                btnMenuUsuarios.Visible = false;
            }
        }
        private void btnMenuOpcionesVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipalFrm frm = new MenuPrincipalFrm();
            frm.Show();
            this.Hide();
        }
        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosFrm frm = new UsuariosFrm();
            frm.Show();
            this.Hide();
        }

        private void btnIntroduccionDatos_Click(object sender, EventArgs e)
        {
            IntroduccionDatosFrm frm = new IntroduccionDatosFrm();
            frm.Show();
            this.Hide();
        }

        private void btnGraficasTablas_Click(object sender, EventArgs e)
        {
            GraficosDatosFrm frm = new GraficosDatosFrm();
            frm.Show();
            this.Hide();
        }
    }
}