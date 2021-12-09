using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROEM_NicolasTomeoClases
{
    public class Persona
    {
        // public Persona() { }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        //public int Edad { get; set; } CAMBIO DE PROP EDAD POR FECHA NACIMIENTO LUEGO HACER EL CALCULO
        public DateTime FechaNacimiento { get; set; }

        public string NombreCompleto          //propiedad solo lectura para obtener metodo completo
        {
            get
            {
                return Nombre + " " + Apellido;
            }
        }
    }
}
