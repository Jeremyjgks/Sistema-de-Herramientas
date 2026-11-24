using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClsAutenticacion
    {
        public string Usuario = "Jeremy Klinger";
        public string Clave = "examen123";

        public bool Autenticacion(string usuario, string clave)
        {
            if (Usuario == usuario && Clave == clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarAcceso(string txtUsuario, string txtClave)
        {
            throw new NotImplementedException();
        }
    }
}
