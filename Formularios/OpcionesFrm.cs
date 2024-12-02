using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace EduStatsProyecto.Formularios
=======
namespace EduStats.Formularios
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
{
    public partial class OpcionesFrm : Form
    {
        public OpcionesFrm()
        {
            InitializeComponent();
<<<<<<< HEAD

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
=======
        }

        private void btnVolverGenero_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnVolverHoras_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnVolverTemporada_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
>>>>>>> 46364e390b423297e5843e6c407a0adc7c7baf80
