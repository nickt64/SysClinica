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

namespace Proem_NicolasTomeo.Reportes
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            var reporte = new Reporte();

            reporte.ReporteMedicosPacientes = Datos.ListaConsultas.GroupBy(x => x.Medico).Select(x => new ReporteMedicosPacientes
            {
                NombreCompleto = x.Key.NombreCompleto,
                CantidadPacientesAtendidos = x.Count()
            }).OrderByDescending(x => x.CantidadPacientesAtendidos).ToList();

            reporte.MedicoConMasPacientes = reporte.ReporteMedicosPacientes
                .OrderByDescending(x => x.CantidadPacientesAtendidos)
                .FirstOrDefault()?.NombreCompleto;

            reporte.MedicoConMenosPacientes = reporte.ReporteMedicosPacientes
                .OrderBy(x => x.CantidadPacientesAtendidos)
                .FirstOrDefault()?.NombreCompleto;

            reporte.EspecialidadConMasConsultas = 
                Datos.ListaConsultas.GroupBy(x => x.Medico.Especialidad)
                                    .OrderByDescending(x => x.Count())
                                    .FirstOrDefault()?.Key;


            dgvMedicos.DataSource = reporte.ReporteMedicosPacientes;
            lblMedicoConMasPacientes.Text = reporte.MedicoConMasPacientes;
            lblMedicoConMenosPacientes.Text = reporte.MedicoConMenosPacientes;
            lblEspecialidadConMasConsultas.Text = reporte.EspecialidadConMasConsultas;

            //reporte.ReporteMedicosPacientes = new List<ReporteMedicosPacientes>();

            //foreach (var consulta in Datos.ListaConsultas)
            //{
            //    bool encontroMedico = false;
            //    foreach(var itemReporte in reporte.ReporteMedicosPacientes)
            //    {
            //        if (itemReporte.NombreCompleto == consulta.NombreMedico)
            //        {
            //            itemReporte.CantidadPacientesAtendidos++;
            //            encontroMedico = true;
            //            break;
            //        }
            //    }

            //    if (!encontroMedico)
            //    {
            //        reporte.ReporteMedicosPacientes.Add(new ReporteMedicosPacientes
            //        {
            //            NombreCompleto = consulta.NombreMedico,
            //            CantidadPacientesAtendidos = 1
            //        });
            //    }
            //}

        }
    }
}
