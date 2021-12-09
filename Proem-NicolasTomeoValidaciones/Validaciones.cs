using PROEM_NicolasTomeoClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proem_NicolasTomeoValidaciones
{
    //clase con validaciones para abm de pacientes
    //muestra todos los mensajes de error a traves de un mismo metodo
    public class Validaciones
    {
        public static bool ValidarPaciente(Paciente paciente, out List<string> errores)
        {
            errores = new List<string>();

            if (string.IsNullOrEmpty(paciente.Nombre))
            {
                errores.Add("Nombre no puede ser vacio.");
            }

            if (string.IsNullOrEmpty(paciente.Apellido))
            {
                errores.Add("Apellido no puede ser vacio.");
            }

            if (paciente.FechaNacimiento > DateTime.Today)
            {
                errores.Add("Fecha de nacimiento no puede ser mayor a hoy.");
            }

            // ...

            if (errores.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
