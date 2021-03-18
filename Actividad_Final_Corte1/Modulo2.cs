using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Actividad_Final_Corte1
{
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double Base;
            Double Altura;
            Base = Convert.ToDouble(txtbase.Text);
            Altura = Convert.ToDouble(txtAltura.Text);
            Double Resultado;
            Resultado = Base * Altura;
            txtArea.Text = Convert.ToString(Resultado);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbase.Clear();
            txtAltura.Clear();
            txtArea.Clear();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
          ContenidoModulos CModulos = new ContenidoModulos();
            this.Hide();
           CModulos.Show();
        }

        private void Modulo2_Load(object sender, EventArgs e)
        {

        }
    }
}
