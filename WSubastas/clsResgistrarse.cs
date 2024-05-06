using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WSubastas
{
    internal class clsResgistrarse
    {
        private string Nuevo_Usuario {  get; set; }   
        private string Nueva_Contraseña { get; set; }

        public clsResgistrarse(string nuevo_Usuario, string nueva_Contraseña)
        {
            this.Nuevo_Usuario = nuevo_Usuario;
            this.Nueva_Contraseña = nueva_Contraseña;
        }

        public bool Registrar() 
        {
            if (Nuevo_Usuario != ""&& Nueva_Contraseña.Length >= 8 )
            {
                File.WriteAllText($"{Nuevo_Usuario}.txt", Nueva_Contraseña);
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
