using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSubastas
{
    public partial class fmrGestionSubastas : Form
    {
        public fmrGestionSubastas()
        {
            InitializeComponent();
        }




        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void subastasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmsubastas = this.ActiveMdiChild;
            if (frmsubastas != null)
            {
                frmsubastas.Close();
            }
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WIniciarSesion frminiciarsesion = new WIniciarSesion();
            frminiciarsesion.MdiParent = this;
            frminiciarsesion.Show();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WRegistrarse frmRegistrarse = new WRegistrarse();
            frmRegistrarse.MdiParent = this;
            frmRegistrarse.Show();
        }
    }
}

