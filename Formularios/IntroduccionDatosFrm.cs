using EduStatsProyecto.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduStatsProyecto.Formularios
{
    public partial class IntroduccionDatosFrm : Form
    {
        public IntroduccionDatosFrm()
        {
            InitializeComponent();
            Constantes.CargarEstadisticas("estadisticas.dat");
        }

        private void lblHumanidadesGenero_Click(object sender, EventArgs e)
        {

        }

        private void txtNoviembre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiciembre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNoviembre_Click(object sender, EventArgs e)
        {

        }

        private void lblDiciembre_Click(object sender, EventArgs e)
        {

        }

        private void btnIntroduccionDatosVolver_Click(object sender, EventArgs e)
        {
            OpcionesFrm frm = new OpcionesFrm();
            frm.Show();
            this.Hide();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            LimpiarCamposCarreras();
            LimpiarCamposGenero();
            LimpiarCamposHoras();
            LimpiarCamposMeses();
        }
        private void LimpiarCamposGenero()
        {
            txtHumanidades.Clear();
            txtNaturales.Clear();
            txtIngenierias.Clear();
            txtSalud.Clear();
            txtArte.Clear();
            txtEconomia.Clear();
            txtDerecho.Clear();
            txtEducacion.Clear();
            txtAplicadas.Clear();
            txtRevistas.Clear();
        }
        private void LimpiarCamposHoras()
        {
            txt7AM.Clear();
            txt8AM.Clear();
            txt9AM.Clear();
            txt10AM.Clear();
            txt11AM.Clear();
            txt12PM.Clear();
            txt1PM.Clear();
            txt2PM.Clear();
            txt3PM.Clear();
            txt4PM.Clear();
            txt5PM.Clear();
            txt6PM.Clear();
            txt7PM.Clear();
        }
        private void LimpiarCamposMeses()
        {
            txtEnero.Clear();
            txtFebrero.Clear();
            txtMarzo.Clear();
            txtAbril.Clear();
            txtMayo.Clear();
            txtJunio.Clear();
            txtJulio.Clear();
            txtAgosto.Clear();
            txtSeptiembre.Clear();
            txtOctubre.Clear();
            txtNoviembre.Clear();
            txtDiciembre.Clear();
        }
        private void LimpiarCamposCarreras()
        {
            txtAdministracion.Clear();
            txtContabilidad.Clear();
            txtEmpresarial.Clear();
            txtNegocios.Clear();
            txtDerechoCarrera.Clear();
            txtDiplomacia.Clear();
            txtMedicina.Clear();
            txtPsicologia.Clear();
            txtArquitectura.Clear();
            txtCivil.Clear();
            txtIndustrial.Clear();
            txtSistemas.Clear();
            txtMarketing.Clear();
            txtDiseno.Clear();
            txtComunicacion.Clear();
            txtOdontologia.Clear();
            txtCollege.Clear();
        }

        private void btnGeneroGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Constantes.Generos[0] = int.Parse(txtHumanidades.Text);
                Constantes.Generos[1] = int.Parse(txtNaturales.Text);
                Constantes.Generos[2] = int.Parse(txtIngenierias.Text);
                Constantes.Generos[3] = int.Parse(txtSalud.Text);
                Constantes.Generos[4] = int.Parse(txtArte.Text);
                Constantes.Generos[5] = int.Parse(txtEconomia.Text);
                Constantes.Generos[6] = int.Parse(txtDerecho.Text);
                Constantes.Generos[7] = int.Parse(txtEducacion.Text);
                Constantes.Generos[8] = int.Parse(txtAplicadas.Text);
                Constantes.Generos[9] = int.Parse(txtRevistas.Text);

                Constantes.GuardarEstadisticas("estadisticas.dat");
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposGenero();
        }

        private void btnHorasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Constantes.Horas[0] = int.Parse(txt7AM.Text);
                Constantes.Horas[1] = int.Parse(txt8AM.Text);
                Constantes.Horas[2] = int.Parse(txt9AM.Text);
                Constantes.Horas[3] = int.Parse(txt10AM.Text);
                Constantes.Horas[4] = int.Parse(txt11AM.Text);
                Constantes.Horas[5] = int.Parse(txt12PM.Text);
                Constantes.Horas[6] = int.Parse(txt1PM.Text);
                Constantes.Horas[7] = int.Parse(txt2PM.Text);
                Constantes.Horas[8] = int.Parse(txt3PM.Text);
                Constantes.Horas[9] = int.Parse(txt4PM.Text);
                Constantes.Horas[10] = int.Parse(txt5PM.Text);
                Constantes.Horas[11] = int.Parse(txt6PM.Text);
                Constantes.Horas[12] = int.Parse(txt7PM.Text);

                Constantes.GuardarEstadisticas("estadisticas.dat");
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposHoras();
        }

        private void btnTemporadaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Constantes.Meses[0] = int.Parse(txtEnero.Text);
                Constantes.Meses[1] = int.Parse(txtFebrero.Text);
                Constantes.Meses[2] = int.Parse(txtMarzo.Text);
                Constantes.Meses[3] = int.Parse(txtAbril.Text);
                Constantes.Meses[4] = int.Parse(txtMayo.Text);
                Constantes.Meses[5] = int.Parse(txtJunio.Text);
                Constantes.Meses[6] = int.Parse(txtJulio.Text);
                Constantes.Meses[7] = int.Parse(txtAgosto.Text);
                Constantes.Meses[8] = int.Parse(txtSeptiembre.Text);
                Constantes.Meses[9] = int.Parse(txtOctubre.Text);
                Constantes.Meses[10] = int.Parse(txtNoviembre.Text);
                Constantes.Meses[11] = int.Parse(txtDiciembre.Text);

                Constantes.GuardarEstadisticas("estadisticas.dat");
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposMeses();
        }

        private void btnCarrerasGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Constantes.Carreras[0] = int.Parse(txtAdministracion.Text);
                Constantes.Carreras[1] = int.Parse(txtContabilidad.Text);
                Constantes.Carreras[2] = int.Parse(txtEmpresarial.Text);
                Constantes.Carreras[3] = int.Parse(txtNegocios.Text);
                Constantes.Carreras[4] = int.Parse(txtDerechoCarrera.Text);
                Constantes.Carreras[5] = int.Parse(txtDiplomacia.Text);
                Constantes.Carreras[6] = int.Parse(txtMedicina.Text);
                Constantes.Carreras[7] = int.Parse(txtPsicologia.Text);
                Constantes.Carreras[8] = int.Parse(txtArquitectura.Text);
                Constantes.Carreras[9] = int.Parse(txtCivil.Text);
                Constantes.Carreras[10] = int.Parse(txtIndustrial.Text);
                Constantes.Carreras[11] = int.Parse(txtSistemas.Text);
                Constantes.Carreras[12] = int.Parse(txtMarketing.Text);
                Constantes.Carreras[13] = int.Parse(txtDiseno.Text);
                Constantes.Carreras[14] = int.Parse(txtComunicacion.Text);
                Constantes.Carreras[15] = int.Parse(txtOdontologia.Text);
                Constantes.Carreras[16] = int.Parse(txtCollege.Text);

                Constantes.GuardarEstadisticas("estadisticas.dat");
            }
            catch (EndOfStreamException)
            {
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCamposCarreras();
        }
    }
}