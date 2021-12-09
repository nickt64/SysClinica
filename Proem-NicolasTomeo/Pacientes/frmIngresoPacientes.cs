using Proem_NicolasTomeo.Consultas;
using PROEM_NicolasTomeoClases;
using Proem_NicolasTomeoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proem_NicolasTomeo.Pacientes
{
    public partial class frmIngresoPacientes : Form
    {
        public frmIngresoPacientes()
        {
            InitializeComponent();
        }

        private void frmIngresoPacientes_Load(object sender, EventArgs e)
        {
            lstPacientes.DataSource = Datos.ListaPacientes;
            lstPacientes.DisplayMember = "NombreCompleto";

            dgvListaDeEspera.DataSource = Datos.ListaConsultas.OrderBy(x => x.FechaDeLlegada).ToList();

            cbMedico.DataSource = Datos.ListaMedicos;
            cbMedico.DisplayMember = "NombreCompleto";

            var especialidades = new List<string>();

            foreach(var medico in Datos.ListaMedicos)
            {
                if (!especialidades.Contains(medico.Especialidad))
                {
                    especialidades.Add(medico.Especialidad);
                }
            }

            cbEspecialidades.DataSource = especialidades;
        }

        private void btnConsultarPacientes_Click(object sender, EventArgs e)
        {
            var frmAlta = new frmAltaPacientes();
            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                lstPacientes.DataSource = null;
                lstPacientes.DataSource = Datos.ListaPacientes;
                lstPacientes.DisplayMember = "NombreCompleto";
            }
        }

        private void btnRegistrarLlegada_Click(object sender, EventArgs e)
        {
            var paciente = (Paciente)lstPacientes.SelectedItem;

            if (paciente == null)
            {
                MessageBox.Show("Seleccione un paciente");
                return;
            }

            Medico medico = null;

            if (rdbMedico.Checked)
            {
                medico = (Medico)cbMedico.SelectedItem;
            }
            else if (rdbEspecialidad.Checked)
            {
                var especialidad = (string)cbEspecialidades.SelectedItem;

                medico = Datos.ListaMedicos.Where(x => x.Especialidad == especialidad).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Seleccione un medico o especialidad");
                return;
            }

            if (Datos.ListaConsultas.Where(x => x.Medico == medico).Any(x => x.Estado == EstadoConsulta.ATENDIENDO))
            {
                MessageBox.Show("El medico ya esta atendiendo");
                return;
            }

            Datos.ListaConsultas.Add(new Consulta
            {
                Paciente = paciente,
                Medico = medico,
                FechaDeLlegada = DateTime.Now
            });

            dgvListaDeEspera.DataSource = null;
            dgvListaDeEspera.DataSource = Datos.ListaConsultas.OrderBy(x => x.FechaDeLlegada).ToList();
        }

        private void rdbMedicoEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedico.Checked)
            {
                cbMedico.Enabled = true;
                cbEspecialidades.Enabled = false;
            }

            if (rdbEspecialidad.Checked)
            {
                cbMedico.Enabled = false;
                cbEspecialidades.Enabled = true;
            }
        }

        private void btnIniciarConsulta_Click(object sender, EventArgs e)
        {
            if (dgvListaDeEspera.CurrentRow != null)
            {
                var consulta = (Consulta)dgvListaDeEspera.CurrentRow.DataBoundItem;

                if (consulta.Estado == EstadoConsulta.COMPLETADO)
                {
                    MessageBox.Show("La consulta ya fue completada");
                    return;
                }

                consulta.Estado = EstadoConsulta.ATENDIENDO;

                var frmConsulta = new frmConsulta(consulta);
                if (frmConsulta.ShowDialog() == DialogResult.OK)
                {
                    dgvListaDeEspera.DataSource = null;
                    dgvListaDeEspera.DataSource = Datos.ListaConsultas.OrderBy(x => x.FechaDeLlegada).ToList();
                }
            }
        }
    }
}
