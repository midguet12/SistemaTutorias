using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.Domain
{
    internal class Student
    {

        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string periodo { get; set; }
        public string matricula { get; set; }

        public Student()
        {

        }

        public Student(string nombre, string apellidoPaterno, string apellidoMaterno, string periodo, string matricula)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.periodo = periodo;
            this.matricula = matricula;
        }
    }

    
}
