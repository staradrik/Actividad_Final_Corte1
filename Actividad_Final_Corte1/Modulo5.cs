using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class Modulo5 : Form
    {
        public Modulo5()
        {
            InitializeComponent();
        }

        private void Modulo6_Load(object sender, EventArgs e)
        {
            gd_datos.Columns.Add("frase", "Frase");
            gd_datos.Columns.Add("pangrama", "Pangrama");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ContenidoModulos Contemd = new ContenidoModulos();
            this.Hide();
            Contemd.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
            txtPangrama.Clear();          
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int n = 1;
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++, pangrama = true)
            {
                exp = txtFrase.Text;
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;

                        break;
                    }
                }
                txtPangrama.Text = Convert.ToString((pangrama ? "SI" : "NO"));
                gd_datos.Rows.Add(txtFrase.Text, txtPangrama.Text);

            }
        }

        private void gd_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(gd_datos.CurrentCell.RowIndex.ToString());
        }
    }
}
