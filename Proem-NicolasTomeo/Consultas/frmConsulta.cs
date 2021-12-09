using PROEM_NicolasTomeoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proem_NicolasTomeo.Consultas
{
    public partial class frmConsulta : Form
    {
        Consulta consultaActual;

        public frmConsulta(Consulta consulta)
        {
            InitializeComponent();

            consultaActual = consulta;
        }

        private void frmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarYSalir();
        }

        private void btnGuardarYCompletar_Click(object sender, EventArgs e)
        {
            consultaActual.Estado = EstadoConsulta.COMPLETADO;

            GuardarYSalir();
        }

        private void GuardarYSalir()
        {
            consultaActual.Procedimiento = txtProcedimiento.Text;

            this.Close();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            txtProcedimiento.Text = consultaActual.Procedimiento;
        }
    }
}
