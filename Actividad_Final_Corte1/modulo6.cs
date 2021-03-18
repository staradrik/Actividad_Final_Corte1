using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class modulo6 : Form
    {
        public modulo6()
        {
            InitializeComponent();
        }

        private void modulo6_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Double sum = 0;
            String numeros;
            numeros = txtNumeros.Text;

            string[] listanumeros = numeros.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < listanumeros.Length; i++)
                {
                    sum += Double.Parse(listanumeros[i]);
                }
                txtRESUL.Text = ("" + sum);
            }
            catch (Exception)
            {

            }

        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
            txtRESUL.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
               ContenidoModulos CModulos = new ContenidoModulos();
              this.Hide();
            CModulos.Show();
        }
    }
}
