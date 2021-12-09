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

namespace Proem_NicolasTomeo
{
    public partial class frmAltaPacientes : Form
    {
        public frmAltaPacientes()
        {
            InitializeComponent();
        }

        private void frmIngresoPacientes_Load(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = Datos.ListaPacientes;

            cbObraSocialPaciente.Items.Add(ObraSocial.NoTiene);
            cbObraSocialPaciente.Items.Add(ObraSocial.CoberturaBasica);
            cbObraSocialPaciente.Items.Add(ObraSocial.CoberturaCompleta);
        }

        private void btnIngresarPaciente_Click(object sender, EventArgs e)
        {
            // validate

            var obraSocial = cbObraSocialPaciente.SelectedItem != null ? cbObraSocialPaciente.SelectedItem.ToString() : null;

            var paciente = new Paciente
            {
                ID = ObtenerProximoID(),
                Nombre = txtbNombrePaciente.Text,
                Apellido = txtbApellidoPaciente.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Dni = txtbDniPaciente.Text,
                ObraSocial = obraSocial
            };

            if (!Validaciones.ValidarPaciente(paciente, out List<string> errores))
            {
                var error = string.Join("\r\n", errores);
                MessageBox.Show(error, "Controle los campos");
                return;
            }

            Datos.ListaPacientes.Add(paciente);

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = Datos.ListaPacientes;
        }

        private void btnActualizarPaciente_Click(object sender, EventArgs e)
        {
            // validate

            var obraSocial = cbObraSocialPaciente.SelectedItem != null ? cbObraSocialPaciente.SelectedItem.ToString() : null;

            var paciente = new Paciente
            {
                ID = int.Parse(lblID.Text),
                Nombre = txtbNombrePaciente.Text,
                Apellido = txtbApellidoPaciente.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Dni = txtbDniPaciente.Text,
                ObraSocial = obraSocial
            };

            if (!Validaciones.ValidarPaciente(paciente, out List<string> errores))
            {
                var error = string.Join("\r\n", errores);
                MessageBox.Show(error, "Controle los campos");
                return;
            }

            foreach (var pacienteAEliminar in Datos.ListaPacientes)
            {
                if (pacienteAEliminar.ID == int.Parse(lblID.Text))
                {
                    Datos.ListaPacientes.Remove(pacienteAEliminar);
                    break;
                }
            }

            Datos.ListaPacientes.Add(paciente);

            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = Datos.ListaPacientes;

            btnActualizarPaciente.Visible = false;
            btnIngresarPaciente.Visible = true;

            lblID.Text = "";
            txtbNombrePaciente.Text = "";
            txtbApellidoPaciente.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtbDniPaciente.Text = "";
            cbObraSocialPaciente.SelectedItem = null;

        }

        private void dgvPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;

                lblID.Text = pacienteSeleccionado.ID.ToString();
                txtbNombrePaciente.Text = pacienteSeleccionado.Nombre;
                txtbApellidoPaciente.Text = pacienteSeleccionado.Apellido;
                dtpFechaNacimiento.Value = pacienteSeleccionado.FechaNacimiento;
                txtbDniPaciente.Text = pacienteSeleccionado.Dni;
                cbObraSocialPaciente.SelectedItem = pacienteSeleccionado.ObraSocial;

                btnIngresarPaciente.Visible = false;
                btnActualizarPaciente.Visible = true;
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = (Paciente)dgvPacientes.CurrentRow.DataBoundItem;

                var id = pacienteSeleccionado.ID;

                if (MessageBox.Show("Seguro que desea eliminar el paciente?", "Atencion", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (var pacienteAEliminar in Datos.ListaPacientes)
                    {
                        if (pacienteAEliminar.ID == id)
                        {
                            Datos.ListaPacientes.Remove(pacienteAEliminar);
                            break;
                        }
                    }

                    dgvPacientes.DataSource = null;
                    dgvPacientes.DataSource = Datos.ListaPacientes;
                }
            }
        }


        private int ObtenerProximoID()
        {
            int ultimoID = 0;

            foreach (var paciente in Datos.ListaPacientes)
            {
                if (paciente.ID > ultimoID)
                {
                    ultimoID = paciente.ID;
                }
            }

            return ultimoID + 1;
        }

        private void frmAltaPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
