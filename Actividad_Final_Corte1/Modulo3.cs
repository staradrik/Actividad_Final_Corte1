using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class Modulo3 : Form
    {
        public Modulo3()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            String cadena = txtFrase.Text;
            int ocurrencias = 0;
            ocurrencias = cadena.Split(txtLetra.Text).Length - 1;
            txtResultado.Text = Convert.ToString(ocurrencias);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtFrase.Clear();
            txtLetra.Clear();
            txtResultado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ContenidoModulos Contemd = new ContenidoModulos();
            this.Hide();
            Contemd.Show();
        }

        private void Modulo3_Load(object sender, EventArgs e)
        {

        }
    }
}
