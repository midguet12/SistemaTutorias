using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.Domain
{
    internal class Estudiante
    {   
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string matricula { get; set; }
        public string programaEducativo { get; set; }
        public string correoInstitucional { get; set; }

        public Estudiante() { }

        public Estudiante(string nombre, string apellidoPaterno, string apellidoMaterno, string matricula, string programaEducativo, string correoInstitucional)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.matricula = matricula;
            this.programaEducativo = programaEducativo;
            this.correoInstitucional = correoInstitucional;
        }
    }
}
