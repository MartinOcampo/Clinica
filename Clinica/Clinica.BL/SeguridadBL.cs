using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.BL
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contrasena)
        {
         if (usuario == "admin" && contrasena == "123") //Creacion de usuario y contraseñas
            {
                return true;
            }
            else
            {
                if (usuario == "user1" && contrasena == "456")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
