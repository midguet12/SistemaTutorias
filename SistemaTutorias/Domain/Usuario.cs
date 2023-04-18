using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.Domain
{
    internal class Usuario
    {

        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }
        public int tipoUsuario { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario, string contrasena, int tipoUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.tipoUsuario = tipoUsuario;
        }
    }
}

    
