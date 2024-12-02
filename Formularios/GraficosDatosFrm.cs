using EduStatsProyecto.Clases;
using EduStatsProyecto.DataSet;
using EduStatsProyecto.Reportes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EduStatsProyecto.Formularios
{
    public partial class GraficosDatosFrm : Form
    {
        public GraficosDatosFrm()
        {
            InitializeComponent();
            CargarTodosLosDatos();
            CargarDataGridViews();
        }

        private void btnIntroduccionDatosVolver_Click(object sender, EventArgs e)
        {
            OpcionesFrm frm = new OpcionesFrm();
            frm.Show();
            this.Hide();
        }

        //DATOS EN COLUMNA
        private void CargarDatosGeneroColumna()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartColumnaGeneros.Series.Clear();
            chartColumnaGeneros.Titles.Clear();

            chartColumnaGeneros.Titles.Add("Cantidad de Prestaciones por Género");
            chartColumnaGeneros.ChartAreas[0].AxisX.Title = "Géneros";
            chartColumnaGeneros.ChartAreas[0].AxisX.Interval = 1;
            chartColumnaGeneros.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            string[] generos = {"Ciencias Sociales y Humanidades", "Ciencias Naturales", "Ciencias de la Computación e Ingenierías", "Ciencias de la Salud", "Arte y Diseño", "Economía y Negocios", "Derecho", "Educación","Tecnologías y Ciencias Aplicadas", "Revistas Académicas y Periódicos"};
             
            int valorMaximo = Constantes.Generos.Max();

            for (int i = 0; i < generos.Length; i++)
            {
                serie.Points.AddXY(generos[i], Constantes.Generos[i]);
            }

            chartColumnaGeneros.ChartAreas[0].AxisY.Minimum = 0;
            chartColumnaGeneros.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartColumnaGeneros.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartColumnaGeneros.Series.Add(serie);
            chartColumnaGeneros.Invalidate();
        }
        private void CargarDatosHoraColumna()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartHoraColumna.Series.Clear();
            chartHoraColumna.Titles.Clear();

            chartHoraColumna.Titles.Add("Cantidad de Prestaciones por Hora");
            chartHoraColumna.ChartAreas[0].AxisX.Title = "Horas";
            chartHoraColumna.ChartAreas[0].AxisX.Interval = 1;
            chartHoraColumna.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            string[] horas = {"7 AM", "8 AM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM", "5 PM", "6 PM", "7 PM"};

            int valorMaximo = Constantes.Horas.Max();

            for (int i = 0; i < horas.Length; i++)
            {
                serie.Points.AddXY(horas[i], Constantes.Horas[i]);
            }

            chartHoraColumna.ChartAreas[0].AxisY.Minimum = 0;
            chartHoraColumna.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartHoraColumna.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartHoraColumna.Series.Add(serie);
            chartHoraColumna.Invalidate();
        }
        private void CargarDatosMesColumna()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartColumnaMes.Series.Clear();
            chartColumnaMes.Titles.Clear();

            chartColumnaMes.Titles.Add("Cantidad de Prestaciones por Mes");
            chartColumnaMes.ChartAreas[0].AxisX.Title = "Meses";
            chartColumnaMes.ChartAreas[0].AxisX.Interval = 1;
            chartColumnaMes.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int valorMaximo = Constantes.Meses.Max();

            for (int i = 0; i < meses.Length; i++)
            {
                serie.Points.AddXY(meses[i], Constantes.Meses[i]);
            }

            chartColumnaMes.ChartAreas[0].AxisY.Minimum = 0;
            chartColumnaMes.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartColumnaMes.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartColumnaMes.Series.Add(serie);
            chartColumnaMes.Invalidate();
        }

        //DATOS EN LINEA
        private void CargarDatosGeneroLinea()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartLineaGeneros.Series.Clear();
            chartLineaGeneros.Titles.Clear();

            chartLineaGeneros.Titles.Add("Cantidad de Prestaciones por Género");
            chartLineaGeneros.ChartAreas[0].AxisX.Title = "Géneros";
            chartLineaGeneros.ChartAreas[0].AxisX.Interval = 1;
            chartLineaGeneros.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            string[] generos = { "Ciencias Sociales y Humanidades", "Ciencias Naturales", "Ciencias de la Computación e Ingenierías", "Ciencias de la Salud", "Arte y Diseño", "Economía y Negocios", "Derecho", "Educación", "Tecnologías y Ciencias Aplicadas", "Revistas Académicas y Periódicos" };

            int valorMaximo = Constantes.Generos.Max();

            for (int i = 0; i < generos.Length; i++)
            {
                serie.Points.AddXY(generos[i], Constantes.Generos[i]);
            }

            chartLineaGeneros.ChartAreas[0].AxisY.Minimum = 0;
            chartLineaGeneros.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartLineaGeneros.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartLineaGeneros.Series.Add(serie);
            chartLineaGeneros.Invalidate();
        }
        private void CargarDatosHoraLinea()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartLineaHoras.Series.Clear();
            chartLineaHoras.Titles.Clear();

            chartLineaHoras.Titles.Add("Cantidad de Prestaciones por Hora");
            chartLineaHoras.ChartAreas[0].AxisX.Title = "Horas";
            chartLineaHoras.ChartAreas[0].AxisX.Interval = 1;
            chartLineaHoras.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            string[] horas = { "7 AM", "8 AM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM", "5 PM", "6 PM", "7 PM" };

            int valorMaximo = Constantes.Horas.Max();

            for (int i = 0; i < horas.Length; i++)
            {
                serie.Points.AddXY(horas[i], Constantes.Horas[i]);
            }

            chartLineaHoras.ChartAreas[0].AxisY.Minimum = 0;
            chartLineaHoras.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartLineaHoras.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartLineaHoras.Series.Add(serie);
            chartLineaHoras.Invalidate();
        }
        private void CargarDatosMesLinea()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartLineaMeses.Series.Clear();
            chartLineaMeses.Titles.Clear();

            chartLineaMeses.Titles.Add("Cantidad de Prestaciones por Mes");
            chartLineaMeses.ChartAreas[0].AxisX.Title = "Meses";
            chartLineaMeses.ChartAreas[0].AxisX.Interval = 1;
            chartLineaMeses.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int valorMaximo = Constantes.Meses.Max();

            for (int i = 0; i < meses.Length; i++)
            {
                serie.Points.AddXY(meses[i], Constantes.Meses[i]);
            }

            chartLineaMeses.ChartAreas[0].AxisY.Minimum = 0;
            chartLineaMeses.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartLineaMeses.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartLineaMeses.Series.Add(serie);
            chartLineaMeses.Invalidate();
        }
        //DATOS EN PASTEL
        private void CargarDatosGeneroPastel()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartPastelGeneros.Series.Clear();
            chartPastelGeneros.Titles.Clear();

            chartPastelGeneros.Titles.Add("Cantidad de Prestaciones por Género");

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            string[] generos = { "Ciencias Sociales y Humanidades", "Ciencias Naturales", "Ciencias de la Computación e Ingenierías", "Ciencias de la Salud", "Arte y Diseño", "Economía y Negocios", "Derecho", "Educación", "Tecnologías y Ciencias Aplicadas", "Revistas Académicas y Periódicos" };

            for (int i = 0; i < generos.Length; i++)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(generos[i], Constantes.Generos[i]);
                punto.LegendText = generos[i];
                serie.Points.Add(punto);
            }

            chartPastelGeneros.Series.Add(serie);
            chartPastelGeneros.Invalidate();
        }
        private void CargarDatosCarreraPastel()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartPastelCarreras.Series.Clear();
            chartPastelCarreras.Titles.Clear();

            chartPastelCarreras.Titles.Add("Cantidad de Prestaciones por Carrera");

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            string[] carreras = { "Administración de Empresas", "Contabilidad y Finanzas", "Economía Empresarial", "Negocios Internacionales", "Derecho", "Diplomacia y Relaciones Internacionales", "Medicina", "Psicología", "Arquitectura", "Ingeniería Civil", "Ingeniería Industrial", "Ingeniería en Sistemas de Información", "Marketing y Publicidad", "Diseño y Comunicación Visual", "Comunicación y Relaciones Internacionales", "Odontología", "UAM College" };

            for (int i = 0; i < carreras.Length; i++)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(carreras[i], Constantes.Carreras[i]);
                punto.LegendText = carreras[i];
                serie.Points.Add(punto);
            }

            chartPastelCarreras.Series.Add(serie);
            chartPastelCarreras.Invalidate();
        }

        private void chartColumnaGeneros_Click(object sender, EventArgs e)
        {

        }
        //DATOS EN BARRA
        private void CargarDatosGeneroBarra()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartBarraGeneros.Series.Clear();
            chartBarraGeneros.Titles.Clear();

            chartBarraGeneros.Titles.Add("Cantidad de Prestaciones por Género");
            chartBarraGeneros.ChartAreas[0].AxisX.Title = "Géneros";
            chartBarraGeneros.ChartAreas[0].AxisX.Interval = 1;
            chartBarraGeneros.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true
            };

            string[] generos = { "Ciencias Sociales y Humanidades", "Ciencias Naturales", "Ciencias de la Computación e Ingenierías", "Ciencias de la Salud", "Arte y Diseño", "Economía y Negocios", "Derecho", "Educación", "Tecnologías y Ciencias Aplicadas", "Revistas Académicas y Periódicos" };

            int valorMaximo = Constantes.Generos.Max();

            for (int i = 0; i < generos.Length; i++)
            {
                serie.Points.AddXY(generos[i], Constantes.Generos[i]);
            }

            chartBarraGeneros.ChartAreas[0].AxisY.Minimum = 0;
            chartBarraGeneros.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartBarraGeneros.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartBarraGeneros.Series.Add(serie);
            chartBarraGeneros.Invalidate();
        }
        private void CargarDatosHoraBarra()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartBarraHoras.Series.Clear();
            chartBarraHoras.Titles.Clear();

            chartBarraHoras.Titles.Add("Cantidad de Prestaciones por Hora");
            chartBarraHoras.ChartAreas[0].AxisX.Title = "Horas";
            chartBarraHoras.ChartAreas[0].AxisX.Interval = 1;
            chartBarraHoras.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true
            };

            string[] horas = { "7 AM", "8 AM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM", "5 PM", "6 PM", "7 PM" };

            int valorMaximo = Constantes.Horas.Max();

            for (int i = 0; i < horas.Length; i++)
            {
                serie.Points.AddXY(horas[i], Constantes.Horas[i]);
            }

            chartBarraHoras.ChartAreas[0].AxisY.Minimum = 0;
            chartBarraHoras.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartBarraHoras.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartBarraHoras.Series.Add(serie);
            chartBarraHoras.Invalidate();
        }
        private void CargarDatosMesBarra()
        {
            Constantes.CargarEstadisticas("estadisticas.dat");

            chartBarraMeses.Series.Clear();
            chartBarraMeses.Titles.Clear();

            chartBarraMeses.Titles.Add("Cantidad de Prestaciones por Mes");
            chartBarraMeses.ChartAreas[0].AxisX.Title = "Meses";
            chartBarraMeses.ChartAreas[0].AxisX.Interval = 1;
            chartBarraMeses.ChartAreas[0].AxisY.Title = "Cantidad de Prestaciones";

            Series serie = new Series("Prestaciones")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true
            };

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            int valorMaximo = Constantes.Meses.Max();

            for (int i = 0; i < meses.Length; i++)
            {
                serie.Points.AddXY(meses[i], Constantes.Meses[i]);
            }

            chartBarraMeses.ChartAreas[0].AxisY.Minimum = 0;
            chartBarraMeses.ChartAreas[0].AxisY.Maximum = valorMaximo + 10;
            chartBarraMeses.ChartAreas[0].AxisY.Interval = Math.Ceiling(valorMaximo / 10.0);

            chartBarraMeses.Series.Add(serie);
            chartBarraMeses.Invalidate();
        }
        private void CargarDataGridViews()
        {
            string[] generos = { "Ciencias Sociales y Humanidades", "Ciencias Naturales", "Ciencias de la Computación e Ingenierías", "Ciencias de la Salud", "Arte y Diseño", "Economía y Negocios", "Derecho", "Educación", "Tecnologías y Ciencias Aplicadas", "Revistas Académicas y Periódicos" };

            dgvGeneros.ColumnCount = 2;
            dgvGeneros.Columns[0].HeaderText = "GÉNERO";
            dgvGeneros.Columns[1].HeaderText = "CANTIDAD";

            for (int i = 0; i < generos.Length; i++)
            {
                dgvGeneros.Rows.Add(generos[i], Constantes.Generos[i]);
            }

            //------------------------------

            string[] horas = { "7 AM", "8 AM", "9 AM", "10 AM", "11 AM", "12 PM", "1 PM", "2 PM", "3 PM", "4 PM", "5 PM", "6 PM", "7 PM" };

            dgvHoras.ColumnCount = 2;
            dgvHoras.Columns[0].HeaderText = "HORA";
            dgvHoras.Columns[1].HeaderText = "CANTIDAD";

            for (int i = 0; i < horas.Length; i++)
            {
                dgvHoras.Rows.Add(horas[i], Constantes.Horas[i]);
            }

            //------------------------------

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            dgvMeses.ColumnCount = 2;
            dgvMeses.Columns[0].HeaderText = "MES";
            dgvMeses.Columns[1].HeaderText = "CANTIDAD";

            for (int i = 0; i < meses.Length; i++)
            {
                dgvMeses.Rows.Add(meses[i], Constantes.Meses[i]);
            }

            //------------------------------

            string[] carreras = { "Administración de Empresas", "Contabilidad y Finanzas", "Economía Empresarial", "Negocios Internacionales", "Derecho", "Diplomacia y Relaciones Internacionales", "Medicina", "Psicología", "Arquitectura", "Ingeniería Civil", "Ingeniería Industrial", "Ingeniería en Sistemas de Información", "Marketing y Publicidad", "Diseño y Comunicación Visual", "Comunicación y Relaciones Internacionales", "Odontología", "UAM College" };

            dgvCarreras.ColumnCount = 2;
            dgvCarreras.Columns[0].HeaderText = "CARRERA";
            dgvCarreras.Columns[1].HeaderText = "CANTIDAD";

            for (int i = 0; i < carreras.Length; i++)
            {
                dgvCarreras.Rows.Add(carreras[i], Constantes.Carreras[i]);
            }
        }
        private void CargarTodosLosDatos()
        {
            CargarDatosGeneroColumna();
            CargarDatosHoraColumna();
            CargarDatosMesColumna();
            CargarDatosGeneroBarra();
            CargarDatosHoraBarra();
            CargarDatosMesBarra();
            CargarDatosGeneroPastel();
            CargarDatosCarreraPastel();
            CargarDatosGeneroLinea();
            CargarDatosHoraLinea();
            CargarDatosMesLinea();
            Constantes.CargarEstadisticas("estadisticas.dat");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MostrarReporteConDatos();
        }

        public void MostrarReporteConDatos()
        {
            dsDatos dataset = new dsDatos();

            LlenarDataTable(dataset.dtGeneros, Constantes.Generos, new string[] { "Humanidades", "Naturales", "Ingenierias", "Salud", "Arte", "Economia", "Derecho", "Educacion", "Aplicadas", "Revistas" });
            LlenarDataTable(dataset.dtHoras, Constantes.Horas, new string[] { "SieteManana", "OchoManana", "NueveManana", "DiezManana", "OnceManana", "DoceTarde", "UnaTarde", "DosTarde", "TresTarde", "CuatroTarde", "CincoTarde", "SeisTarde", "SieteTarde" });
            LlenarDataTable(dataset.dtMeses, Constantes.Meses, new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            LlenarDataTable(dataset.dtCarreras, Constantes.Carreras, new string[] { "Administracion", "Contabilidad", "Empresarial", "Negocios", "DerechoCarrera", "Diplomacia", "Medicina", "Psicologia", "Arquitectura", "Civil", "Industrial", "Sistemas", "Marketing", "Diseno", "Comunicacion", "Odontologia", "College" });

            VistaPreviaFrm frm = new VistaPreviaFrm();
            frm.reportViewer1.LocalReport.DataSources.Clear();

            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataset.dtGeneros.DefaultView));
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dataset.dtHoras.DefaultView));
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet3", dataset.dtMeses.DefaultView));
            frm.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet4", dataset.dtCarreras.DefaultView));

            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "EduStatsProyecto.Reportes.RptEduStats.rdlc";

            frm.reportViewer1.RefreshReport();
            frm.Show();
        }

        private void LlenarDataTable(DataTable dataTable, int[] valores, string[] nombresColumnas)
        {
            DataRow row = dataTable.NewRow();

            for (int i = 0; i < nombresColumnas.Length; i++)
            {
                if (dataTable.Columns.Contains(nombresColumnas[i]))
                {
                    row[nombresColumnas[i]] = valores.Length > i ? valores[i] : 0;
                }
            }

            dataTable.Rows.Add(row);
        }
    }
}