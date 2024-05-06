using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WSubastas
{
    internal class clsConfirmarUsuario : clsIniciarSesion
    {
        public clsConfirmarUsuario(string usuario, string contraseña, string usuarioIngresado, string contrasenaIngresada)
          : base(usuario, contraseña)
        {
            //bool VerificarCredenciales(string usuario, string contraseña, string usuarioIngresado, string contrasenaIngresada)
            //{
            //    return usuario == usuarioIngresado && contraseña == contrasenaIngresada;
            //}

        }

        
    }

}

