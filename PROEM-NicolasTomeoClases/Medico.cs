using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROEM_NicolasTomeoClases
{//clase medico propiedades heredadas de Persona mas las especificas
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public string EstadoActual { get; set; }
    }
}
