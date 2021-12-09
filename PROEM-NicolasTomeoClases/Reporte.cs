using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROEM_NicolasTomeoClases
{
    public class Reporte
    {
        public List<ReporteMedicosPacientes> ReporteMedicosPacientes { get; set; }   
        public string MedicoConMasPacientes { get; set; }
        public string MedicoConMenosPacientes { get; set; }
        public string EspecialidadConMasConsultas { get; set; }
    }

    public class ReporteMedicosPacientes
    {
        public string NombreCompleto { get; set; }
        public int CantidadPacientesAtendidos { get; set; }
    }
}
