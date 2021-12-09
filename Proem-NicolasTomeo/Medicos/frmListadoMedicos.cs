using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROEM_NicolasTomeoClases;
using Proem_NicolasTomeoDatos;
using Proem_NicolasTomeoValidaciones;

namespace Proem_NicolasTomeo.Medicos
{
    public partial class frmListadoMedicos : Form
    {
        public frmListadoMedicos()
        {
            InitializeComponent();
        }

        private void frmListadoMedicos_Load(object sender, EventArgs e)
        {
            foreach(var medico in Datos.ListaMedicos)
            {
                medico.EstadoActual = "LIBRE";

                foreach(var consulta in Datos.ListaConsultas)
                {
                    if (consulta.Medico == medico && consulta.Estado == EstadoConsulta.ATENDIENDO)
                    {
                        medico.EstadoActual = "ATENDIENDO";
                        break;
                    }
                }
            }

            dgvMedicos.DataSource = Datos.ListaMedicos;
        }
    }
}
