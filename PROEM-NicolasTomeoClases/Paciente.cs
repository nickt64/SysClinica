using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROEM_NicolasTomeoClases
{           // clase PACIENTE propiedades heredadas de persona mas las especificas 
    public class Paciente : Persona
    {   //REVERSIONADO DE CONSTRUCTORES
        //public Paciente() { }
        //public Paciente(string nombre, string apellido, int edad, int dni, string obraSocial)
        //{

        //    this.dni = dni;
        //    this.nombre = nombre;
        //    this.apellido = apellido;
        //    this.Edad = edad;
        //    this.obraSocial = obraSocial;
        //    this.id = dni;
        //}
        
        //public int id { get; set; }

        public string ObraSocial { get; set; }
    }
}
