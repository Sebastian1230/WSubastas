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
    public partial class WIniciarSesion : Form
    {
        public WIniciarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = txtusuario.Text;
            string Contraseña = txtcontraseña.Text;

            clsIniciarSesion clsIniciarSesion = new clsIniciarSesion(Usuario, Contraseña);
            bool InicioSesionExitoso = clsIniciarSesion.Iniciar_Sesion();

            if (InicioSesionExitoso) 
            {
                MessageBox.Show("Inicio de sesion exitoso");
                WSubasta Gestion = new WSubasta();
                Gestion.Show();
            }
            else 
            {
                MessageBox.Show("Nombre o usuario incorrectos");
            }
           

            
        }
    }
}
