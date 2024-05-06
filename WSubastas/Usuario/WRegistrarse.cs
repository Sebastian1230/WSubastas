using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSubastas
{
    public partial class WRegistrarse : Form
    {
        public WRegistrarse()
        {
            InitializeComponent();
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {
            string Nuevo_Usuario = txtUsuarioNuevo.Text;
            string Nueva_Contraseña = txtNuevaContraseña.Text;

            clsResgistrarse clsResgistrarse = new clsResgistrarse(Nuevo_Usuario, Nueva_Contraseña);
            bool RegistroExitoso = clsResgistrarse.Registrar();

            if (RegistroExitoso) 
            {
                MessageBox.Show("Registro exitoso");
                WSubasta Gestion = new WSubasta();
                Gestion.Show();
            }
            else 
            {
                MessageBox.Show("Usario vacio o contraseña es menor a 8 caracteres");
            }
            
        }
    }
}
