using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.Domain
{
    internal class Docente
    {
        public int numeroDocente { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string correoInstitucional { get; set; }
        public int rol { get; set; }
        public bool tutor { get; set; }
        public int idProgramaEducativo { get; set; }

        public Docente()
        {
        }

        public Docente(int numeroDocente, string nombre, string apellidoPaterno, string apellidoMaterno, string correoInstitucional, int rol, bool tutor, int idProgramaEducativo)
        {
            this.numeroDocente = numeroDocente;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.correoInstitucional = correoInstitucional;
            this.rol = rol;
            this.tutor = tutor;
            this.idProgramaEducativo = idProgramaEducativo;
        }


    }
}
