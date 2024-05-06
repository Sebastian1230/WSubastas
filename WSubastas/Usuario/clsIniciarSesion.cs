using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WSubastas
{
    internal class clsIniciarSesion
    {
        private string Usuario {get; set; }
        private string Contraseña { get; set; } 

        public clsIniciarSesion(string usuario, string contraseña)
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }   
        public bool Iniciar_Sesion() 
        {
            if (File.Exists($"{Usuario}.txt"))
            {
                string almacenarcontraseña = File.ReadAllText($"{Usuario}.txt");
                return almacenarcontraseña == Contraseña;
            }
            else 
            {
                return false; 
            }
        }
            
    
    }
}
