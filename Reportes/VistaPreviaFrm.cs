﻿using EduStatsProyecto.Clases;
using EduStatsProyecto.DataSet;
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

namespace EduStatsProyecto.Reportes
{
    public partial class VistaPreviaFrm : Form
    {
        public VistaPreviaFrm()
        {
            InitializeComponent();
        }

        private void VistaPreviaFrm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
