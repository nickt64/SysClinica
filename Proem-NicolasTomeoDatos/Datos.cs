using PROEM_NicolasTomeoClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proem_NicolasTomeoDatos
{//clase con datos precargados para las diferentes collecciones
    public class Datos
    {
        #region Iniciar Lista Pacientes
        public static List<Paciente> ListaPacientes = new List<Paciente>
        {
            new Paciente
            {
                ID = 1,
                Nombre = "nicolas",
                Apellido = "tomeo",
                FechaNacimiento = new DateTime(1993, 5, 9),
                Dni = "37333921",
                ObraSocial = ObraSocial.NoTiene
            },
            new Paciente
            {
                ID = 2,
                Nombre = "jimena",
                Apellido = "tomeo",
                FechaNacimiento = new DateTime(1997, 8, 30),
                Dni = "37312321",
                ObraSocial = ObraSocial.CoberturaCompleta
            }
        };

        #endregion

        #region Iniciar Lista Medicos
        public static List<Medico> ListaMedicos = new List<Medico>
        {
            new Medico
            {
                ID = 1,
                Nombre = "tomas",
                Apellido = "Prueba",
                FechaNacimiento = new DateTime(1978, 5, 9),
                Dni = "22833921",
                Especialidad = "Traumatologo"
            },
            new Medico
            {
                ID = 2,
                Nombre = "javier",
                Apellido = "Proveta",
                FechaNacimiento = new DateTime(1969, 5, 8),
                Dni = "22384921",
                Especialidad = "pediatra"
            },
            new Medico
            {
                ID = 3,
                Nombre = "Medico",
                Apellido = "Perez",
                FechaNacimiento = new DateTime(1971, 5, 4),
                Dni = "25333921",
                Especialidad = "cardiologo"
            }
        };
        #endregion

        #region Iniciar Lista Consultas

        public static List<Consulta> ListaConsultas = new List<Consulta>
        {
            new Consulta
            {
                Paciente = ListaPacientes[0],
                Medico = ListaMedicos[0],
                FechaDeLlegada = DateTime.Today.AddHours(12),
                Estado = EstadoConsulta.ATENDIENDO
            },
            new Consulta
            {
                Paciente = ListaPacientes[0],
                Medico = ListaMedicos[1],
                FechaDeLlegada = DateTime.Today.AddHours(8),
                Estado = EstadoConsulta.PENDIENTE
            },
            new Consulta
            {
                Paciente = ListaPacientes[0],
                Medico = ListaMedicos[1],
                FechaDeLlegada = DateTime.Today.AddHours(8.5),
                Estado = EstadoConsulta.PENDIENTE
            },
            new Consulta
            {
                Paciente = ListaPacientes[1],
                Medico = ListaMedicos[2],
                FechaDeLlegada = DateTime.Today.AddHours(9),
                Estado = EstadoConsulta.PENDIENTE
            },
            new Consulta
            {
                Paciente = ListaPacientes[1],
                Medico = ListaMedicos[2],
                FechaDeLlegada = DateTime.Today.AddHours(10),
                Estado = EstadoConsulta.PENDIENTE
            },
            new Consulta
            {
                Paciente = ListaPacientes[1],
                Medico = ListaMedicos[2],
                FechaDeLlegada = DateTime.Today.AddHours(11),
                Estado = EstadoConsulta.PENDIENTE
            },
        };

        #endregion
    }
}
