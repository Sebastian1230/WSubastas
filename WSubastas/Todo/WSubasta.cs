using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace WSubastas
{
    public partial class WSubasta : Form
    {
        public WSubasta()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.HeaderText = "Producto";
            col0.Width = 200;
            col0.ReadOnly = true;
            dgvSubastas.Columns.Add(col0);

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Precio";
            col1.Width = 200;
            col1.ReadOnly = true;
            dgvSubastas.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Duracion";
            col2.Width = 200;
            col2.ReadOnly = true;
            dgvSubastas.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Reglas";
            col3.Width = 500;
            col3.ReadOnly = true;
            dgvSubastas.Columns.Add(col3);
        }
 
        private Stream myStream;
        int counter = 0;
        string line;

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string producto = txtProducto.Text;
            double precioinical = Convert.ToDouble(txtPrecioInicial.Text);
            /*Convert.ToDouble(txtPrecioInicial.Text);*/
            int duracionEnSegundos = Convert.ToInt32(txtDuracion.Text);
            string reglas = txtReglas.Text;


            clsSubasta InfoSubasta = new clsSubasta(txtProducto.Text, precioinical, duracionEnSegundos, txtReglas.Text);
            dgvSubastas.Rows.Add(InfoSubasta.Producto, InfoSubasta.PrecioInicial, InfoSubasta.Duracion, InfoSubasta.Reglas);

        }


        private void btnCSV_Click(object sender, EventArgs e)
        {
            
            char delimitador = ';';
            string[] valores;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.csv) | *.csv;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new StreamReader(openFileDialog.FileName);
                            while ((line = file.ReadLine()) != null)
                            {
                                if (counter >= 1)
                                {
                                    valores = line.Split(delimitador);
                                    dgvSubastas.Rows.Add(valores.ToArray());
                                    counter++;
                                }
                                else
                                {
                                    counter++;
                                }

                            }
                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }
}


