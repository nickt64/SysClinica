using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proem_NicolasTomeo.Medicos;
using Proem_NicolasTomeo.Pacientes;
using Proem_NicolasTomeo.Reportes;
using PROEM_NicolasTomeoClases;

namespace Proem_NicolasTomeo
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {//patron para declarar formularios hijos
            var frmIngreso = new frmIngresoPacientes();
            frmIngreso.MdiParent = this;
            frmIngreso.Show();

        }

        private void listaDeMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMedicos = new frmListadoMedicos();
            frmMedicos.MdiParent = this;
            frmMedicos.Show();
        }

        private void estadisticasHistoricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmReporte = new frmReporte();
            frmReporte.MdiParent = this;
            frmReporte.Show();
        }
    }

}
