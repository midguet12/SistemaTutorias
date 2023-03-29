﻿using System;
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
        public string matricula { get; set; }
        public string programaEducativo { get; set; }



        public Student()
        {

        }

        public Student(string nombre, string apellidoPaterno, string apellidoMaterno, string programaEducativo, string matricula)
        {
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.matricula = matricula;
            this.programaEducativo = programaEducativo;
           
        }
    }

    
}
