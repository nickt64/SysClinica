using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROEM_NicolasTomeoClases
{
    //clase con propiedades para la generacion de las consultas
    public class Consulta
    {
        public Paciente Paciente;
        public Medico Medico;
        public string Procedimiento;

        public DateTime FechaDeLlegada { get; set; }

        public EstadoConsulta Estado { get; set; }

        public string NombrePaciente
        {
            get
            {
                if (Paciente != null)
                {
                    return Paciente.NombreCompleto;
                }

                return "";
            }
        }

        public string NombreMedico
        {
            get
            {
                if (Medico != null)
                {
                    return Medico.NombreCompleto;
                }

                return "";
            }
        }
    }
}
